using Aevatar.Core;
using Aevatar.Core.Abstractions;
using Microsoft.Extensions.Logging;
using Neo4j.Driver;
using Org.OpenAPITools;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Extensions;
using Org.OpenAPITools.Model;

namespace TweetDownloader.GAgents;

[GenerateSerializer]
public class Configuration
{
    [Id(0)] public string BearerToken { get; set; } = string.Empty;
    [Id(1)] public List<string> UserIds { get; set; } = new List<string>();
    [Id(2)] public TimeSpan PollingInterval { get; set; } = TimeSpan.FromMinutes(15);
    [Id(3)] public string Neo4jUri { get; set; } = "bolt://localhost:7687";
    [Id(4)] public string Neo4jUser { get; set; } = "neo4j";
    [Id(5)] public string Neo4jPassword { get; set; } = "password";
}

[GenerateSerializer]
public class TwitterDownloaderConfiguration : ConfigurationBase
{
    [Id(0)] public Configuration Configuration { get; set; } = new Configuration();
}

[GenerateSerializer]
public class TweetsDownloaderState : StateBase
{
    [Id(0)] public bool Configured { get; set; } = false;
    [Id(1)] public Configuration Configuration { get; set; } = new Configuration();
    [Id(2)] public Dictionary<string, string> LastTweetIdPerUser { get; set; } = new Dictionary<string, string>();

    public void Apply(TweetsDownloaderConfiguredEvent @event)
    {
        this.Configuration = @event.Configuration;
        this.Configured = true;
    }

    public void Apply(TweetsDownloadedEvent @event)
    {
        this.LastTweetIdPerUser[@event.UserId] = @event.Tweets.Last().Id;
    }
}

[GenerateSerializer]
public class TweetsDownloaderStateLogEvent : StateLogEventBase<TweetsDownloaderStateLogEvent>;

[GenerateSerializer]
public class TweetsDownloaderConfiguredEvent : TweetsDownloaderStateLogEvent
{
    [Id(0)] public Configuration Configuration { get; set; } = new Configuration();
}

[GenerateSerializer]
public class TweetsDownloadedEvent : TweetsDownloaderStateLogEvent
{
    [Id(0)] public string UserId { get; set; } = string.Empty;
    [Id(1)] public List<Tweet> Tweets { get; set; } = new List<Tweet>();
}

[GAgent]
public class TweetsDownloaderGrain :
    GAgentBase<TweetsDownloaderState, TweetsDownloaderStateLogEvent, EventBase, TwitterDownloaderConfiguration>,
    IRemindable
{
    private TweetsApi? _tweetsApi;
    private readonly ILogger<TweetsDownloaderGrain> _logger;
    private readonly ILoggerFactory _loggerFactory;
    private readonly HttpClient _httpClient;
    private TokenProvider<BearerToken>? _bearerTokenProvider;
    private TokenProvider<OAuthToken>? _oauthTokenProvider;
    private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
    private IDisposable? _downloadTimer;
    private IDriver? _neo4jDriver;

    private IDriver Neo4jDriver
    {
        get
        {
            if (_neo4jDriver != null) return _neo4jDriver;
            _neo4jDriver = GraphDatabase.Driver(
                State.Configuration.Neo4jUri,
                AuthTokens.Basic(State.Configuration.Neo4jUser, State.Configuration.Neo4jPassword));
            return _neo4jDriver;
        }
    }

    private TokenProvider<BearerToken> BearerTokenProvider
    {
        get
        {
            if (_bearerTokenProvider != null) return _bearerTokenProvider;
            var bearerToken = new BearerToken(State.Configuration.BearerToken);
            var bearerTokenContainer = new TokenContainer<BearerToken>(new[] { bearerToken });
            _bearerTokenProvider = new RateLimitProvider<BearerToken>(bearerTokenContainer);

            return _bearerTokenProvider;
        }
    }

    public TokenProvider<OAuthToken> OAuthTokenProvider
    {
        get
        {
            if (_oauthTokenProvider != null) return _oauthTokenProvider;
            var oauthToken = new OAuthToken(State.Configuration.BearerToken);
            var oauthTokenContainer = new TokenContainer<OAuthToken>(new[] { oauthToken });
            _oauthTokenProvider = new RateLimitProvider<OAuthToken>(oauthTokenContainer);

            return _oauthTokenProvider;
        }
    }

    private TweetsApi TweetsApi
    {
        get
        {
            if (_tweetsApi != null) return _tweetsApi;
            var tweetsApiLogger = _loggerFactory.CreateLogger<TweetsApi>();
            var tweetsApiEvents = new TweetsApiEvents();
            _tweetsApi = new TweetsApi(
                tweetsApiLogger,
                _loggerFactory,
                _httpClient,
                _jsonSerializerOptionsProvider,
                tweetsApiEvents,
                BearerTokenProvider,
                OAuthTokenProvider // oauthTokenProvider
            );
            return _tweetsApi;
        }
    }

    public TweetsDownloaderGrain(
        ILogger<TweetsDownloaderGrain> logger,
        ILoggerFactory loggerFactory,
        IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _loggerFactory = loggerFactory;
        _httpClient = httpClientFactory.CreateClient("TwitterApi");
        _httpClient.BaseAddress = new Uri("https://api.twitter.com");
        _jsonSerializerOptionsProvider = new Org.OpenAPITools.Client.JsonSerializerOptionsProvider(
            new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                IncludeFields = true
            }.AddConverters()
        );
    }

    public override Task<string> GetDescriptionAsync()
    {
        return Task.FromResult("This GAgent downloads and monitors posts from X (Twitter) accounts.");
    }

    protected override async Task PerformConfigAsync(TwitterDownloaderConfiguration config)
    {
        State.Configuration = config.Configuration;
        State.Configured = true;

        RaiseEvent(new TweetsDownloaderConfiguredEvent
        {
            Configuration = config.Configuration
        });
        await ConfirmEvents();

        // RegisterTimer in OnGAgentActivateAsync won't work if the grain is activated for the first time
        // when it's not received configuration. So we need to try to register it again here.
        RegisterTimer();
    }

    protected override Task OnGAgentActivateAsync(CancellationToken token)
    {
        RegisterTimer();

        return Task.CompletedTask;
    }

    public override async Task OnDeactivateAsync(
        DeactivationReason reason,
        CancellationToken cancellationToken)
    {
        await base.OnDeactivateAsync(reason, cancellationToken);
        await DisposeNeo4jDriverAsync();
    }

    private async Task DisposeNeo4jDriverAsync()
    {
        if (_neo4jDriver != null)
        {
            await _neo4jDriver.DisposeAsync();
            _neo4jDriver = null;
        }
    }

    private void RegisterTimer()
    {
        if (!State.Configured)
            return;
        UnregisterTimer();

        if (State.Configuration.UserIds is not [_, ..] || string.IsNullOrEmpty(State.Configuration.BearerToken))
        {
            _logger.LogWarning("Skipping timer registration as either UserIds or BearerToken is not set.");
            return;
        }

        _downloadTimer = this.RegisterGrainTimer(
            DownloadPostsTimerCallbackAsync,
            TimeSpan.Zero,
            State.Configuration.PollingInterval
        );
    }

    private void UnregisterTimer()
    {
        if (_downloadTimer == null) return;
        _downloadTimer.Dispose();
        _downloadTimer = null;
    }

    Task IRemindable.ReceiveReminder(string reminderName, TickStatus status)
    {
        return Task.CompletedTask;
    }

    private async Task DownloadPostsTimerCallbackAsync()
    {
        try
        {
            await DownloadPostsForAllMonitoredAccountsAsync();
            _logger.LogInformation("Successfully downloaded posts for all monitored accounts");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error downloading posts for monitored accounts");
        }
    }

    public async Task<List<Tweet>> DownloadPostsForUserAsync(string userId, int maxPosts = 10)
    {
        if (string.IsNullOrEmpty(State.Configuration.BearerToken))
        {
            throw new InvalidOperationException("Bearer token not set. Call SetBearerTokenAsync first.");
        }

        var retryPolicy = ApiExtensions.GetRetryPolicy();
        var sinceId = new Option<string>();

        // Get the last tweet ID for this user if available
        if (State.LastTweetIdPerUser.TryGetValue(userId, out var lastId) && !string.IsNullOrEmpty(lastId))
        {
            sinceId = lastId;
            _logger.LogInformation("Fetching tweets for user {UserId} since tweet {TweetId}", userId, sinceId);
        }
        else
        {
            _logger.LogInformation("Fetching tweets for user {UserId} (no since_id available)", userId);
        }

        // Get tweets with retry policy
        var tweetsResponse = await retryPolicy.ExecuteAsync(async () =>
        {
            return await Task.Run(() => TweetsApi.UsersIdTweetsAsync(
                userId,
                sinceId: sinceId, // Use the stored sinceId
                maxResults: maxPosts,
                tweetFields: new List<string> { "created_at", "author_id", "text" }));
        });
        var posts = new List<Tweet>();

        if (!tweetsResponse.TryOk(out var tweetsPayload))
        {
            return posts;
        }

        if (tweetsPayload?.Data != null && tweetsPayload.Data.Count > 0)
        {
            // Sort tweets by ID to ensure we're processing them in chronological order
            // (Twitter IDs are sortable by time)
            var sortedTweets = tweetsPayload.Data.OrderBy(t => t.Id).ToList();

            foreach (var tweet in sortedTweets)
            {
                await StoreTweetInNeo4jAsync(tweet, userId);
                posts.Add(tweet);
            }

            RaiseEvent(new TweetsDownloadedEvent
            {
                UserId = userId,
                Tweets = posts
            });
            await ConfirmEvents();

            _logger.LogInformation("Updated last tweet ID for user {UserId} to {TweetId}", userId, posts.Last().Id);
        }
        else
        {
            _logger.LogInformation("No new tweets found for user {UserId}", userId);
        }

        return posts;
    }

    public async Task DownloadPostsForAllMonitoredAccountsAsync(int maxPostsPerAccount = 10)
    {
        foreach (var userId in State.Configuration.UserIds)
        {
            try
            {
                await DownloadPostsForUserAsync(userId, maxPostsPerAccount);
            }
            catch (Exception ex)
            {
                _logger.LogException(ex);
            }
        }
    }

    private async Task StoreTweetInNeo4jAsync(Tweet tweet, string authorId)
    {
        try
        {
            var session = Neo4jDriver.AsyncSession();
            try
            {
                // Create or update User node
                await session.ExecuteWriteAsync(async tx =>
                {
                    // Create User node if not exists
                    await tx.RunAsync(@"
                        MERGE (u:User {id: $authorId})
                        ON CREATE SET u.createdAt = datetime()
                        ON MATCH SET u.lastUpdated = datetime()",
                        new { authorId });

                    // Create Tweet node and relationship to User
                    await tx.RunAsync(@"
                        MERGE (t:Tweet {id: $tweetId})
                        ON CREATE SET 
                            t.text = $text,
                            t.createdAt = $createdAt,
                            t.authorId = $authorId
                        
                        WITH t
                        MATCH (u:User {id: $authorId})
                        MERGE (u)-[:POSTED]->(t)",
                        new
                        {
                            tweetId = tweet.Id,
                            text = tweet.Text,
                            createdAt = tweet.CreatedAt?.ToString("o") ?? DateTime.UtcNow.ToString("o"),
                            authorId
                        });
                });

                _logger.LogInformation("Successfully stored tweet {TweetId} in Neo4j", tweet.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error storing tweet {TweetId} in Neo4j", tweet.Id);
            }
            finally
            {
                await session.CloseAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error storing tweet {TweetId} in Neo4j", tweet.Id);
        }
    }
}
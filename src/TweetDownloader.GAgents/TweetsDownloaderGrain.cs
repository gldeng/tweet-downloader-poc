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
public class TwitterDownloaderConfiguration : ConfigurationBase
{
    [Id(1)] public string BearerToken { get; set; } = string.Empty;
    [Id(2)] public List<string> UserIds { get; set; } = new List<string>();
    [Id(3)] public TimeSpan PollingInterval { get; set; } = TimeSpan.FromMinutes(15);
    [Id(4)] public string Neo4jUri { get; set; } = "bolt://localhost:7687";
    [Id(5)] public string Neo4jUser { get; set; } = "neo4j";
    [Id(6)] public string Neo4jPassword { get; set; } = "password";
}

[GenerateSerializer]
public class TweetsDownloaderState : StateBase
{
    [Id(0)] public string BearerToken { get; set; } = string.Empty;
    [Id(1)] public List<string> UserIds { get; set; } = new List<string>();

    [Id(2)]
    public Dictionary<string, List<Tweet>> DownloadedPosts { get; set; } = new Dictionary<string, List<Tweet>>();

    [Id(3)] public TimeSpan PollingInterval { get; set; } = TimeSpan.FromMinutes(15);
    [Id(4)] public bool Configured { get; set; } = false;
    [Id(5)] public string Neo4jUri { get; set; } = string.Empty;
    [Id(6)] public string Neo4jUser { get; set; } = string.Empty;
    [Id(7)] public string Neo4jPassword { get; set; } = string.Empty;
    [Id(8)] public Dictionary<string, string> LastTweetIdPerUser { get; set; } = new Dictionary<string, string>();
}

[GenerateSerializer]
public class TweetsDownloaderStateLogEvent : StateLogEventBase<TweetsDownloaderStateLogEvent>;

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

    private bool _neo4jConfigured => !string.IsNullOrEmpty(State.Neo4jUri) &&
                                     !string.IsNullOrEmpty(State.Neo4jUser) &&
                                     !string.IsNullOrEmpty(State.Neo4jPassword);

    private TokenProvider<BearerToken> BearerTokenProvider
    {
        get
        {
            if (_bearerTokenProvider != null) return _bearerTokenProvider;
            var bearerToken = new BearerToken(State.BearerToken);
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
            var oauthToken = new OAuthToken(State.BearerToken);
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

    protected override Task PerformConfigAsync(TwitterDownloaderConfiguration config)
    {
        State.BearerToken = config.BearerToken;
        State.UserIds = config.UserIds;
        State.PollingInterval = config.PollingInterval;
        State.Neo4jUri = config.Neo4jUri;
        State.Neo4jUser = config.Neo4jUser;
        State.Neo4jPassword = config.Neo4jPassword;
        State.Configured = true;

        // Initialize Neo4j driver
        InitializeNeo4jDriver();

        // RegisterTimer in OnGAgentActivateAsync won't work if the grain is activated for the first time
        // when it's not received configuration. So we need to try to register it again here.
        RegisterTimer();

        return Task.CompletedTask;
    }

    protected override Task OnGAgentActivateAsync(CancellationToken token)
    {
        InitializeNeo4jDriver();
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

    private void InitializeNeo4jDriver()
    {
        if (_neo4jDriver != null || !_neo4jConfigured)
            return;

        try
        {
            _neo4jDriver = GraphDatabase.Driver(
                State.Neo4jUri,
                AuthTokens.Basic(State.Neo4jUser, State.Neo4jPassword));
            _logger.LogInformation("Neo4j driver initialized successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize Neo4j driver");
        }
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

        if (State.UserIds is not [_, ..] || string.IsNullOrEmpty(State.BearerToken))
        {
            _logger.LogWarning("Skipping timer registration as either UserIds or BearerToken is not set.");
            return;
        }

        _downloadTimer = this.RegisterGrainTimer(
            DownloadPostsTimerCallbackAsync,
            TimeSpan.Zero,
            State.PollingInterval
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
        if (string.IsNullOrEmpty(State.BearerToken))
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
        if (!State.DownloadedPosts.ContainsKey(userId))
        {
            State.DownloadedPosts[userId] = new List<Tweet>();
        }

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
                // Add only new posts to state
                if (!State.DownloadedPosts[userId].Any(p => p.Id == tweet.Id))
                {
                    State.DownloadedPosts[userId].Add(tweet);
                    await StoreTweetInNeo4jAsync(tweet, userId);
                }
            }

            // Update the last tweet ID for this user with the most recent tweet ID
            var latestTweetId = sortedTweets.Last().Id;
            State.LastTweetIdPerUser[userId] = latestTweetId;
            _logger.LogInformation("Updated last tweet ID for user {UserId} to {TweetId}", userId, latestTweetId);
        }
        else
        {
            _logger.LogInformation("No new tweets found for user {UserId}", userId);
        }

        return posts;
    }

    public async Task DownloadPostsForAllMonitoredAccountsAsync(int maxPostsPerAccount = 10)
    {
        foreach (var userId in State.UserIds)
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
        if (_neo4jDriver == null || !_neo4jConfigured)
            return;

        try
        {
            var session = _neo4jDriver.AsyncSession();
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
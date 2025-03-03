using Aevatar.Core.Abstractions;
using Aevatar.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TweetDownloader.GAgents;

var builder = Host.CreateDefaultBuilder(args)
    .UseOrleansClient(client =>
    {
        client.UseLocalhostClustering()
            .UseMongoDBClient("mongodb://localhost:27017/?maxPoolSize=555")
            .AddMemoryStreams(AevatarCoreConstants.StreamProvider)
            .UseAevatar();
    })
    .ConfigureLogging(logging => logging.AddConsole())
    .UseConsoleLifetime();

using var host = builder.Build();
await host.StartAsync();

var gAgentFactory = host.Services.GetRequiredService<IGAgentFactory>();
var guid = Guid.AllBitsSet;

// Get the bearer token from environment variable with fallback
var twitterBearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN") ?? "";

// Get user IDs from environment variable with fallback
var userIdsString = Environment.GetEnvironmentVariable("TWITTER_USER_IDS") ?? "";
var userIds = userIdsString.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .ToList();

// Get user IDs from environment variable with fallback
var interval = Environment.GetEnvironmentVariable("TWITTER_DOWNLOAD_INTERVAL") ?? "00:01:00";

var gAgent = await gAgentFactory.GetGAgentAsync<IStateGAgent<TweetsDownloaderState>>(guid,
    new TwitterDownloaderConfiguration
    {
        BearerToken = twitterBearerToken,
        UserIds = userIds,
        PollingInterval = TimeSpan.Parse(interval),
        Neo4jUri = "bolt://localhost:7687",
        Neo4jUser = "neo4j",
        Neo4jPassword = "neo4jneo4j"
    });

Console.WriteLine("Twitter downloader initialized.");
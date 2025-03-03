using System.Net;
using Org.OpenAPITools.Client;
using Polly;
using Polly.Retry;

namespace TweetDownloader.GAgents
{
    public static class ApiExtensions
    {
        public static AsyncRetryPolicy GetRetryPolicy()
        {
            return Policy
                .Handle<ApiException>(ex =>
                    ex.StatusCode == HttpStatusCode.TooManyRequests ||
                    (int)ex.StatusCode >= 500)
                .WaitAndRetryAsync(
                    3,
                    retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                    (exception, timeSpan, retryCount, context) =>
                    {
                        Console.WriteLine(
                            $"Retry {retryCount} after {timeSpan.TotalSeconds}s due to: {exception.Message}");
                    }
                );
        }
    }
}
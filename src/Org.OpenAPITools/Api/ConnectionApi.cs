// <auto-generated>
/*
 * Twitter API v2
 *
 * Twitter API v2 available endpoints
 *
 * The version of the OpenAPI document: 2.128
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Diagnostics.CodeAnalysis;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IConnectionApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ConnectionApiEvents Events { get; }

        /// <summary>
        /// Force kills all streaming connections of the authenticated application.
        /// </summary>
        /// <remarks>
        /// Force kills all streaming connections of the authenticated application.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IKillAllAppConnectionsApiResponse"/>&gt;</returns>
        Task<IKillAllAppConnectionsApiResponse> KillAllAppConnectionsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Force kills all streaming connections of the authenticated application.
        /// </summary>
        /// <remarks>
        /// Force kills all streaming connections of the authenticated application.
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IKillAllAppConnectionsApiResponse"/>?&gt;</returns>
        Task<IKillAllAppConnectionsApiResponse?> KillAllAppConnectionsOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IKillAllAppConnectionsApiResponse"/>
    /// </summary>
    public interface IKillAllAppConnectionsApiResponse : Org.OpenAPITools.Client.IApiResponse, IOk<Org.OpenAPITools.Model.KillAllConnectionsResponse?>, IDefault<Org.OpenAPITools.Model.Error?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is the default response type
        /// </summary>
        /// <returns></returns>
        bool IsDefault { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnKillAllAppConnections;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorKillAllAppConnections;

        internal void ExecuteOnKillAllAppConnections(ConnectionApi.KillAllAppConnectionsApiResponse apiResponse)
        {
            OnKillAllAppConnections?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorKillAllAppConnections(Exception exception)
        {
            OnErrorKillAllAppConnections?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ConnectionApi : IConnectionApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ConnectionApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ConnectionApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionApi(ILogger<ConnectionApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ConnectionApiEvents connectionApiEvents,
            TokenProvider<BearerToken> bearerTokenProvider,
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ConnectionApi>();
            HttpClient = httpClient;
            Events = connectionApiEvents;
            BearerTokenProvider = bearerTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        private void AfterKillAllAppConnectionsDefaultImplementation(IKillAllAppConnectionsApiResponse apiResponseLocalVar)
        {
            bool suppressDefaultLog = false;
            AfterKillAllAppConnections(ref suppressDefaultLog, apiResponseLocalVar);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        partial void AfterKillAllAppConnections(ref bool suppressDefaultLog, IKillAllAppConnectionsApiResponse apiResponseLocalVar);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        private void OnErrorKillAllAppConnectionsDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorKillAllAppConnections(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        partial void OnErrorKillAllAppConnections(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar);

        /// <summary>
        /// Force kills all streaming connections of the authenticated application. Force kills all streaming connections of the authenticated application.
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IKillAllAppConnectionsApiResponse"/>&gt;</returns>
        public async Task<IKillAllAppConnectionsApiResponse?> KillAllAppConnectionsOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await KillAllAppConnectionsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Force kills all streaming connections of the authenticated application. Force kills all streaming connections of the authenticated application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IKillAllAppConnectionsApiResponse"/>&gt;</returns>
        public async Task<IKillAllAppConnectionsApiResponse> KillAllAppConnectionsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/2/connections/all";

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    BearerToken bearerTokenLocalVar1 = (BearerToken) await BearerTokenProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(bearerTokenLocalVar1);

                    bearerTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar, "");

                    string[] acceptLocalVars = new string[] {
                        "application/json",
                        "application/problem+json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Delete;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<KillAllAppConnectionsApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<KillAllAppConnectionsApiResponse>();

                        KillAllAppConnectionsApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/2/connections/all", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterKillAllAppConnectionsDefaultImplementation(apiResponseLocalVar);

                        Events.ExecuteOnKillAllAppConnections(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorKillAllAppConnectionsDefaultImplementation(e, "/2/connections/all", uriBuilderLocalVar.Path);
                Events.ExecuteOnErrorKillAllAppConnections(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="KillAllAppConnectionsApiResponse"/>
        /// </summary>
        public partial class KillAllAppConnectionsApiResponse : Org.OpenAPITools.Client.ApiResponse, IKillAllAppConnectionsApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<KillAllAppConnectionsApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="KillAllAppConnectionsApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public KillAllAppConnectionsApiResponse(ILogger<KillAllAppConnectionsApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.KillAllConnectionsResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.KillAllConnectionsResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Org.OpenAPITools.Model.KillAllConnectionsResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is the default response type
            /// </summary>
            /// <returns></returns>
            public bool IsDefault => !IsOk;

            /// <summary>
            /// Deserializes the response if the response is 0 Default
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.Error? Default()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsDefault
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.Error>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 0 Default and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryDefault([NotNullWhen(true)]out Org.OpenAPITools.Model.Error? result)
            {
                result = null;

                try
                {
                    result = Default();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)0);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}

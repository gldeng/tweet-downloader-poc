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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TweetUnviewable
    /// </summary>
    public partial class TweetUnviewable : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetUnviewable" /> class.
        /// </summary>
        /// <param name="application">If the label is being applied or removed. Possible values are ‘apply’ or ‘remove’.</param>
        /// <param name="eventAt">Event time.</param>
        /// <param name="tweet">tweet</param>
        [JsonConstructor]
        public TweetUnviewable(string application, DateTime eventAt, TweetComplianceSchemaTweet tweet)
        {
            Application = application;
            EventAt = eventAt;
            Tweet = tweet;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// If the label is being applied or removed. Possible values are ‘apply’ or ‘remove’.
        /// </summary>
        /// <value>If the label is being applied or removed. Possible values are ‘apply’ or ‘remove’.</value>
        /* <example>apply</example> */
        [JsonPropertyName("application")]
        public string Application { get; set; }

        /// <summary>
        /// Event time.
        /// </summary>
        /// <value>Event time.</value>
        /* <example>2021-07-06T18:40:40Z</example> */
        [JsonPropertyName("event_at")]
        public DateTime EventAt { get; set; }

        /// <summary>
        /// Gets or Sets Tweet
        /// </summary>
        [JsonPropertyName("tweet")]
        public TweetComplianceSchemaTweet Tweet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TweetUnviewable {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  EventAt: ").Append(EventAt).Append("\n");
            sb.Append("  Tweet: ").Append(Tweet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TweetUnviewable" />
    /// </summary>
    public class TweetUnviewableJsonConverter : JsonConverter<TweetUnviewable>
    {
        /// <summary>
        /// The format to use to serialize EventAt
        /// </summary>
        public static string EventAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="TweetUnviewable" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TweetUnviewable Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> application = default;
            Option<DateTime?> eventAt = default;
            Option<TweetComplianceSchemaTweet?> tweet = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "application":
                            application = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "event_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                eventAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "tweet":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tweet = new Option<TweetComplianceSchemaTweet?>(JsonSerializer.Deserialize<TweetComplianceSchemaTweet>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!application.IsSet)
                throw new ArgumentException("Property is required for class TweetUnviewable.", nameof(application));

            if (!eventAt.IsSet)
                throw new ArgumentException("Property is required for class TweetUnviewable.", nameof(eventAt));

            if (!tweet.IsSet)
                throw new ArgumentException("Property is required for class TweetUnviewable.", nameof(tweet));

            if (application.IsSet && application.Value == null)
                throw new ArgumentNullException(nameof(application), "Property is not nullable for class TweetUnviewable.");

            if (eventAt.IsSet && eventAt.Value == null)
                throw new ArgumentNullException(nameof(eventAt), "Property is not nullable for class TweetUnviewable.");

            if (tweet.IsSet && tweet.Value == null)
                throw new ArgumentNullException(nameof(tweet), "Property is not nullable for class TweetUnviewable.");

            return new TweetUnviewable(application.Value!, eventAt.Value!.Value!, tweet.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TweetUnviewable" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetUnviewable"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TweetUnviewable tweetUnviewable, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tweetUnviewable, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TweetUnviewable" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetUnviewable"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TweetUnviewable tweetUnviewable, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tweetUnviewable.Application == null)
                throw new ArgumentNullException(nameof(tweetUnviewable.Application), "Property is required for class TweetUnviewable.");

            if (tweetUnviewable.Tweet == null)
                throw new ArgumentNullException(nameof(tweetUnviewable.Tweet), "Property is required for class TweetUnviewable.");

            writer.WriteString("application", tweetUnviewable.Application);

            writer.WriteString("event_at", tweetUnviewable.EventAt.ToString(EventAtFormat));

            writer.WritePropertyName("tweet");
            JsonSerializer.Serialize(writer, tweetUnviewable.Tweet, jsonSerializerOptions);
        }
    }
}

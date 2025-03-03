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
    /// TweetNotice
    /// </summary>
    public partial class TweetNotice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetNotice" /> class.
        /// </summary>
        /// <param name="application">If the label is being applied or removed. Possible values are ‘apply’ or ‘remove’.</param>
        /// <param name="eventAt">Event time.</param>
        /// <param name="eventType">The type of label on the Tweet</param>
        /// <param name="tweet">tweet</param>
        /// <param name="details">Information shown on the Tweet label</param>
        /// <param name="extendedDetailsUrl">Link to more information about this kind of label</param>
        /// <param name="labelTitle">Title/header of the Tweet label</param>
        [JsonConstructor]
        public TweetNotice(string application, DateTime eventAt, string eventType, TweetComplianceSchemaTweet tweet, Option<string?> details = default, Option<string?> extendedDetailsUrl = default, Option<string?> labelTitle = default)
        {
            Application = application;
            EventAt = eventAt;
            EventType = eventType;
            Tweet = tweet;
            DetailsOption = details;
            ExtendedDetailsUrlOption = extendedDetailsUrl;
            LabelTitleOption = labelTitle;
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
        /// The type of label on the Tweet
        /// </summary>
        /// <value>The type of label on the Tweet</value>
        /* <example>misleading</example> */
        [JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets Tweet
        /// </summary>
        [JsonPropertyName("tweet")]
        public TweetComplianceSchemaTweet Tweet { get; set; }

        /// <summary>
        /// Used to track the state of Details
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DetailsOption { get; private set; }

        /// <summary>
        /// Information shown on the Tweet label
        /// </summary>
        /// <value>Information shown on the Tweet label</value>
        [JsonPropertyName("details")]
        public string? Details { get { return this.DetailsOption; } set { this.DetailsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExtendedDetailsUrl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExtendedDetailsUrlOption { get; private set; }

        /// <summary>
        /// Link to more information about this kind of label
        /// </summary>
        /// <value>Link to more information about this kind of label</value>
        [JsonPropertyName("extended_details_url")]
        public string? ExtendedDetailsUrl { get { return this.ExtendedDetailsUrlOption; } set { this.ExtendedDetailsUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of LabelTitle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LabelTitleOption { get; private set; }

        /// <summary>
        /// Title/header of the Tweet label
        /// </summary>
        /// <value>Title/header of the Tweet label</value>
        [JsonPropertyName("label_title")]
        public string? LabelTitle { get { return this.LabelTitleOption; } set { this.LabelTitleOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TweetNotice {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  EventAt: ").Append(EventAt).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Tweet: ").Append(Tweet).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ExtendedDetailsUrl: ").Append(ExtendedDetailsUrl).Append("\n");
            sb.Append("  LabelTitle: ").Append(LabelTitle).Append("\n");
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
    /// A Json converter for type <see cref="TweetNotice" />
    /// </summary>
    public class TweetNoticeJsonConverter : JsonConverter<TweetNotice>
    {
        /// <summary>
        /// The format to use to serialize EventAt
        /// </summary>
        public static string EventAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="TweetNotice" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TweetNotice Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> application = default;
            Option<DateTime?> eventAt = default;
            Option<string?> eventType = default;
            Option<TweetComplianceSchemaTweet?> tweet = default;
            Option<string?> details = default;
            Option<string?> extendedDetailsUrl = default;
            Option<string?> labelTitle = default;

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
                        case "event_type":
                            eventType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tweet":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tweet = new Option<TweetComplianceSchemaTweet?>(JsonSerializer.Deserialize<TweetComplianceSchemaTweet>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "details":
                            details = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "extended_details_url":
                            extendedDetailsUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "label_title":
                            labelTitle = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!application.IsSet)
                throw new ArgumentException("Property is required for class TweetNotice.", nameof(application));

            if (!eventAt.IsSet)
                throw new ArgumentException("Property is required for class TweetNotice.", nameof(eventAt));

            if (!eventType.IsSet)
                throw new ArgumentException("Property is required for class TweetNotice.", nameof(eventType));

            if (!tweet.IsSet)
                throw new ArgumentException("Property is required for class TweetNotice.", nameof(tweet));

            if (application.IsSet && application.Value == null)
                throw new ArgumentNullException(nameof(application), "Property is not nullable for class TweetNotice.");

            if (eventAt.IsSet && eventAt.Value == null)
                throw new ArgumentNullException(nameof(eventAt), "Property is not nullable for class TweetNotice.");

            if (eventType.IsSet && eventType.Value == null)
                throw new ArgumentNullException(nameof(eventType), "Property is not nullable for class TweetNotice.");

            if (tweet.IsSet && tweet.Value == null)
                throw new ArgumentNullException(nameof(tweet), "Property is not nullable for class TweetNotice.");

            if (details.IsSet && details.Value == null)
                throw new ArgumentNullException(nameof(details), "Property is not nullable for class TweetNotice.");

            if (extendedDetailsUrl.IsSet && extendedDetailsUrl.Value == null)
                throw new ArgumentNullException(nameof(extendedDetailsUrl), "Property is not nullable for class TweetNotice.");

            if (labelTitle.IsSet && labelTitle.Value == null)
                throw new ArgumentNullException(nameof(labelTitle), "Property is not nullable for class TweetNotice.");

            return new TweetNotice(application.Value!, eventAt.Value!.Value!, eventType.Value!, tweet.Value!, details, extendedDetailsUrl, labelTitle);
        }

        /// <summary>
        /// Serializes a <see cref="TweetNotice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetNotice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TweetNotice tweetNotice, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tweetNotice, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TweetNotice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetNotice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TweetNotice tweetNotice, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tweetNotice.Application == null)
                throw new ArgumentNullException(nameof(tweetNotice.Application), "Property is required for class TweetNotice.");

            if (tweetNotice.EventType == null)
                throw new ArgumentNullException(nameof(tweetNotice.EventType), "Property is required for class TweetNotice.");

            if (tweetNotice.Tweet == null)
                throw new ArgumentNullException(nameof(tweetNotice.Tweet), "Property is required for class TweetNotice.");

            if (tweetNotice.DetailsOption.IsSet && tweetNotice.Details == null)
                throw new ArgumentNullException(nameof(tweetNotice.Details), "Property is required for class TweetNotice.");

            if (tweetNotice.ExtendedDetailsUrlOption.IsSet && tweetNotice.ExtendedDetailsUrl == null)
                throw new ArgumentNullException(nameof(tweetNotice.ExtendedDetailsUrl), "Property is required for class TweetNotice.");

            if (tweetNotice.LabelTitleOption.IsSet && tweetNotice.LabelTitle == null)
                throw new ArgumentNullException(nameof(tweetNotice.LabelTitle), "Property is required for class TweetNotice.");

            writer.WriteString("application", tweetNotice.Application);

            writer.WriteString("event_at", tweetNotice.EventAt.ToString(EventAtFormat));

            writer.WriteString("event_type", tweetNotice.EventType);

            writer.WritePropertyName("tweet");
            JsonSerializer.Serialize(writer, tweetNotice.Tweet, jsonSerializerOptions);
            if (tweetNotice.DetailsOption.IsSet)
                writer.WriteString("details", tweetNotice.Details);

            if (tweetNotice.ExtendedDetailsUrlOption.IsSet)
                writer.WriteString("extended_details_url", tweetNotice.ExtendedDetailsUrl);

            if (tweetNotice.LabelTitleOption.IsSet)
                writer.WriteString("label_title", tweetNotice.LabelTitle);
        }
    }
}

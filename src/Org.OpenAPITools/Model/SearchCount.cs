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
    /// Represent a Search Count Result.
    /// </summary>
    public partial class SearchCount : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCount" /> class.
        /// </summary>
        /// <param name="end">The end time of the bucket.</param>
        /// <param name="start">The start time of the bucket.</param>
        /// <param name="tweetCount">The count for the bucket.</param>
        [JsonConstructor]
        public SearchCount(DateTime end, DateTime start, int tweetCount)
        {
            End = end;
            Start = start;
            TweetCount = tweetCount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The end time of the bucket.
        /// </summary>
        /// <value>The end time of the bucket.</value>
        [JsonPropertyName("end")]
        public DateTime End { get; set; }

        /// <summary>
        /// The start time of the bucket.
        /// </summary>
        /// <value>The start time of the bucket.</value>
        [JsonPropertyName("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// The count for the bucket.
        /// </summary>
        /// <value>The count for the bucket.</value>
        [JsonPropertyName("tweet_count")]
        public int TweetCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchCount {\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  TweetCount: ").Append(TweetCount).Append("\n");
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
    /// A Json converter for type <see cref="SearchCount" />
    /// </summary>
    public class SearchCountJsonConverter : JsonConverter<SearchCount>
    {
        /// <summary>
        /// The format to use to serialize End
        /// </summary>
        public static string EndFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize Start
        /// </summary>
        public static string StartFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="SearchCount" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SearchCount Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> end = default;
            Option<DateTime?> start = default;
            Option<int?> tweetCount = default;

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
                        case "end":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                end = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "start":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                start = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "tweet_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tweetCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!end.IsSet)
                throw new ArgumentException("Property is required for class SearchCount.", nameof(end));

            if (!start.IsSet)
                throw new ArgumentException("Property is required for class SearchCount.", nameof(start));

            if (!tweetCount.IsSet)
                throw new ArgumentException("Property is required for class SearchCount.", nameof(tweetCount));

            if (end.IsSet && end.Value == null)
                throw new ArgumentNullException(nameof(end), "Property is not nullable for class SearchCount.");

            if (start.IsSet && start.Value == null)
                throw new ArgumentNullException(nameof(start), "Property is not nullable for class SearchCount.");

            if (tweetCount.IsSet && tweetCount.Value == null)
                throw new ArgumentNullException(nameof(tweetCount), "Property is not nullable for class SearchCount.");

            return new SearchCount(end.Value!.Value!, start.Value!.Value!, tweetCount.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="SearchCount" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="searchCount"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SearchCount searchCount, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, searchCount, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SearchCount" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="searchCount"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SearchCount searchCount, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("end", searchCount.End.ToString(EndFormat));

            writer.WriteString("start", searchCount.Start.ToString(StartFormat));

            writer.WriteNumber("tweet_count", searchCount.TweetCount);
        }
    }
}

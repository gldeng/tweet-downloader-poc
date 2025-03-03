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
    /// A trend.
    /// </summary>
    public partial class Trend : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trend" /> class.
        /// </summary>
        /// <param name="trendName">Name of the trend.</param>
        /// <param name="tweetCount">Number of Posts in this trend.</param>
        [JsonConstructor]
        public Trend(Option<string?> trendName = default, Option<int?> tweetCount = default)
        {
            TrendNameOption = trendName;
            TweetCountOption = tweetCount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TrendName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TrendNameOption { get; private set; }

        /// <summary>
        /// Name of the trend.
        /// </summary>
        /// <value>Name of the trend.</value>
        [JsonPropertyName("trend_name")]
        public string? TrendName { get { return this.TrendNameOption; } set { this.TrendNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of TweetCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TweetCountOption { get; private set; }

        /// <summary>
        /// Number of Posts in this trend.
        /// </summary>
        /// <value>Number of Posts in this trend.</value>
        [JsonPropertyName("tweet_count")]
        public int? TweetCount { get { return this.TweetCountOption; } set { this.TweetCountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Trend {\n");
            sb.Append("  TrendName: ").Append(TrendName).Append("\n");
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
    /// A Json converter for type <see cref="Trend" />
    /// </summary>
    public class TrendJsonConverter : JsonConverter<Trend>
    {
        /// <summary>
        /// Deserializes json to <see cref="Trend" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Trend Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> trendName = default;
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
                        case "trend_name":
                            trendName = new Option<string?>(utf8JsonReader.GetString()!);
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

            if (trendName.IsSet && trendName.Value == null)
                throw new ArgumentNullException(nameof(trendName), "Property is not nullable for class Trend.");

            if (tweetCount.IsSet && tweetCount.Value == null)
                throw new ArgumentNullException(nameof(tweetCount), "Property is not nullable for class Trend.");

            return new Trend(trendName, tweetCount);
        }

        /// <summary>
        /// Serializes a <see cref="Trend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Trend trend, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trend, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Trend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Trend trend, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trend.TrendNameOption.IsSet && trend.TrendName == null)
                throw new ArgumentNullException(nameof(trend.TrendName), "Property is required for class Trend.");

            if (trend.TrendNameOption.IsSet)
                writer.WriteString("trend_name", trend.TrendName);

            if (trend.TweetCountOption.IsSet)
                writer.WriteNumber("tweet_count", trend.TweetCountOption.Value!.Value);
        }
    }
}

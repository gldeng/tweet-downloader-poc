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
    /// Promoted nonpublic engagement metrics for the Media at the time of the request.
    /// </summary>
    public partial class VideoAllOfPromotedMetrics : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAllOfPromotedMetrics" /> class.
        /// </summary>
        /// <param name="playback0Count">Number of users who made it through 0% of the video.</param>
        /// <param name="playback100Count">Number of users who made it through 100% of the video.</param>
        /// <param name="playback25Count">Number of users who made it through 25% of the video.</param>
        /// <param name="playback50Count">Number of users who made it through 50% of the video.</param>
        /// <param name="playback75Count">Number of users who made it through 75% of the video.</param>
        /// <param name="viewCount">Number of times this video has been viewed.</param>
        [JsonConstructor]
        public VideoAllOfPromotedMetrics(Option<int?> playback0Count = default, Option<int?> playback100Count = default, Option<int?> playback25Count = default, Option<int?> playback50Count = default, Option<int?> playback75Count = default, Option<int?> viewCount = default)
        {
            Playback0CountOption = playback0Count;
            Playback100CountOption = playback100Count;
            Playback25CountOption = playback25Count;
            Playback50CountOption = playback50Count;
            Playback75CountOption = playback75Count;
            ViewCountOption = viewCount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Playback0Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Playback0CountOption { get; private set; }

        /// <summary>
        /// Number of users who made it through 0% of the video.
        /// </summary>
        /// <value>Number of users who made it through 0% of the video.</value>
        [JsonPropertyName("playback_0_count")]
        public int? Playback0Count { get { return this.Playback0CountOption; } set { this.Playback0CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Playback100Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Playback100CountOption { get; private set; }

        /// <summary>
        /// Number of users who made it through 100% of the video.
        /// </summary>
        /// <value>Number of users who made it through 100% of the video.</value>
        [JsonPropertyName("playback_100_count")]
        public int? Playback100Count { get { return this.Playback100CountOption; } set { this.Playback100CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Playback25Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Playback25CountOption { get; private set; }

        /// <summary>
        /// Number of users who made it through 25% of the video.
        /// </summary>
        /// <value>Number of users who made it through 25% of the video.</value>
        [JsonPropertyName("playback_25_count")]
        public int? Playback25Count { get { return this.Playback25CountOption; } set { this.Playback25CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Playback50Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Playback50CountOption { get; private set; }

        /// <summary>
        /// Number of users who made it through 50% of the video.
        /// </summary>
        /// <value>Number of users who made it through 50% of the video.</value>
        [JsonPropertyName("playback_50_count")]
        public int? Playback50Count { get { return this.Playback50CountOption; } set { this.Playback50CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Playback75Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Playback75CountOption { get; private set; }

        /// <summary>
        /// Number of users who made it through 75% of the video.
        /// </summary>
        /// <value>Number of users who made it through 75% of the video.</value>
        [JsonPropertyName("playback_75_count")]
        public int? Playback75Count { get { return this.Playback75CountOption; } set { this.Playback75CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of ViewCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ViewCountOption { get; private set; }

        /// <summary>
        /// Number of times this video has been viewed.
        /// </summary>
        /// <value>Number of times this video has been viewed.</value>
        [JsonPropertyName("view_count")]
        public int? ViewCount { get { return this.ViewCountOption; } set { this.ViewCountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoAllOfPromotedMetrics {\n");
            sb.Append("  Playback0Count: ").Append(Playback0Count).Append("\n");
            sb.Append("  Playback100Count: ").Append(Playback100Count).Append("\n");
            sb.Append("  Playback25Count: ").Append(Playback25Count).Append("\n");
            sb.Append("  Playback50Count: ").Append(Playback50Count).Append("\n");
            sb.Append("  Playback75Count: ").Append(Playback75Count).Append("\n");
            sb.Append("  ViewCount: ").Append(ViewCount).Append("\n");
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
    /// A Json converter for type <see cref="VideoAllOfPromotedMetrics" />
    /// </summary>
    public class VideoAllOfPromotedMetricsJsonConverter : JsonConverter<VideoAllOfPromotedMetrics>
    {
        /// <summary>
        /// Deserializes json to <see cref="VideoAllOfPromotedMetrics" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override VideoAllOfPromotedMetrics Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> playback0Count = default;
            Option<int?> playback100Count = default;
            Option<int?> playback25Count = default;
            Option<int?> playback50Count = default;
            Option<int?> playback75Count = default;
            Option<int?> viewCount = default;

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
                        case "playback_0_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playback0Count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playback_100_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playback100Count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playback_25_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playback25Count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playback_50_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playback50Count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "playback_75_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                playback75Count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "view_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                viewCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (playback0Count.IsSet && playback0Count.Value == null)
                throw new ArgumentNullException(nameof(playback0Count), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            if (playback100Count.IsSet && playback100Count.Value == null)
                throw new ArgumentNullException(nameof(playback100Count), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            if (playback25Count.IsSet && playback25Count.Value == null)
                throw new ArgumentNullException(nameof(playback25Count), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            if (playback50Count.IsSet && playback50Count.Value == null)
                throw new ArgumentNullException(nameof(playback50Count), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            if (playback75Count.IsSet && playback75Count.Value == null)
                throw new ArgumentNullException(nameof(playback75Count), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            if (viewCount.IsSet && viewCount.Value == null)
                throw new ArgumentNullException(nameof(viewCount), "Property is not nullable for class VideoAllOfPromotedMetrics.");

            return new VideoAllOfPromotedMetrics(playback0Count, playback100Count, playback25Count, playback50Count, playback75Count, viewCount);
        }

        /// <summary>
        /// Serializes a <see cref="VideoAllOfPromotedMetrics" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="videoAllOfPromotedMetrics"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, VideoAllOfPromotedMetrics videoAllOfPromotedMetrics, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, videoAllOfPromotedMetrics, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="VideoAllOfPromotedMetrics" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="videoAllOfPromotedMetrics"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, VideoAllOfPromotedMetrics videoAllOfPromotedMetrics, JsonSerializerOptions jsonSerializerOptions)
        {
            if (videoAllOfPromotedMetrics.Playback0CountOption.IsSet)
                writer.WriteNumber("playback_0_count", videoAllOfPromotedMetrics.Playback0CountOption.Value!.Value);

            if (videoAllOfPromotedMetrics.Playback100CountOption.IsSet)
                writer.WriteNumber("playback_100_count", videoAllOfPromotedMetrics.Playback100CountOption.Value!.Value);

            if (videoAllOfPromotedMetrics.Playback25CountOption.IsSet)
                writer.WriteNumber("playback_25_count", videoAllOfPromotedMetrics.Playback25CountOption.Value!.Value);

            if (videoAllOfPromotedMetrics.Playback50CountOption.IsSet)
                writer.WriteNumber("playback_50_count", videoAllOfPromotedMetrics.Playback50CountOption.Value!.Value);

            if (videoAllOfPromotedMetrics.Playback75CountOption.IsSet)
                writer.WriteNumber("playback_75_count", videoAllOfPromotedMetrics.Playback75CountOption.Value!.Value);

            if (videoAllOfPromotedMetrics.ViewCountOption.IsSet)
                writer.WriteNumber("view_count", videoAllOfPromotedMetrics.ViewCountOption.Value!.Value);
        }
    }
}

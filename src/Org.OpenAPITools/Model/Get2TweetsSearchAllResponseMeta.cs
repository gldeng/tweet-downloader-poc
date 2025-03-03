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
    /// Get2TweetsSearchAllResponseMeta
    /// </summary>
    public partial class Get2TweetsSearchAllResponseMeta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get2TweetsSearchAllResponseMeta" /> class.
        /// </summary>
        /// <param name="newestId">The newest id in this response.</param>
        /// <param name="nextToken">The next token.</param>
        /// <param name="oldestId">The oldest id in this response.</param>
        /// <param name="resultCount">The number of results returned in this response.</param>
        [JsonConstructor]
        public Get2TweetsSearchAllResponseMeta(Option<string?> newestId = default, Option<string?> nextToken = default, Option<string?> oldestId = default, Option<int?> resultCount = default)
        {
            NewestIdOption = newestId;
            NextTokenOption = nextToken;
            OldestIdOption = oldestId;
            ResultCountOption = resultCount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of NewestId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NewestIdOption { get; private set; }

        /// <summary>
        /// The newest id in this response.
        /// </summary>
        /// <value>The newest id in this response.</value>
        [JsonPropertyName("newest_id")]
        public string? NewestId { get { return this.NewestIdOption; } set { this.NewestIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of NextToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NextTokenOption { get; private set; }

        /// <summary>
        /// The next token.
        /// </summary>
        /// <value>The next token.</value>
        [JsonPropertyName("next_token")]
        public string? NextToken { get { return this.NextTokenOption; } set { this.NextTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of OldestId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OldestIdOption { get; private set; }

        /// <summary>
        /// The oldest id in this response.
        /// </summary>
        /// <value>The oldest id in this response.</value>
        [JsonPropertyName("oldest_id")]
        public string? OldestId { get { return this.OldestIdOption; } set { this.OldestIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ResultCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ResultCountOption { get; private set; }

        /// <summary>
        /// The number of results returned in this response.
        /// </summary>
        /// <value>The number of results returned in this response.</value>
        [JsonPropertyName("result_count")]
        public int? ResultCount { get { return this.ResultCountOption; } set { this.ResultCountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Get2TweetsSearchAllResponseMeta {\n");
            sb.Append("  NewestId: ").Append(NewestId).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  OldestId: ").Append(OldestId).Append("\n");
            sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
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
            // NextToken (string) minLength
            if (this.NextToken != null && this.NextToken.Length < 1)
            {
                yield return new ValidationResult("Invalid value for NextToken, length must be greater than 1.", new [] { "NextToken" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Get2TweetsSearchAllResponseMeta" />
    /// </summary>
    public class Get2TweetsSearchAllResponseMetaJsonConverter : JsonConverter<Get2TweetsSearchAllResponseMeta>
    {
        /// <summary>
        /// Deserializes json to <see cref="Get2TweetsSearchAllResponseMeta" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Get2TweetsSearchAllResponseMeta Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> newestId = default;
            Option<string?> nextToken = default;
            Option<string?> oldestId = default;
            Option<int?> resultCount = default;

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
                        case "newest_id":
                            newestId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "next_token":
                            nextToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "oldest_id":
                            oldestId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "result_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                resultCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (newestId.IsSet && newestId.Value == null)
                throw new ArgumentNullException(nameof(newestId), "Property is not nullable for class Get2TweetsSearchAllResponseMeta.");

            if (nextToken.IsSet && nextToken.Value == null)
                throw new ArgumentNullException(nameof(nextToken), "Property is not nullable for class Get2TweetsSearchAllResponseMeta.");

            if (oldestId.IsSet && oldestId.Value == null)
                throw new ArgumentNullException(nameof(oldestId), "Property is not nullable for class Get2TweetsSearchAllResponseMeta.");

            if (resultCount.IsSet && resultCount.Value == null)
                throw new ArgumentNullException(nameof(resultCount), "Property is not nullable for class Get2TweetsSearchAllResponseMeta.");

            return new Get2TweetsSearchAllResponseMeta(newestId, nextToken, oldestId, resultCount);
        }

        /// <summary>
        /// Serializes a <see cref="Get2TweetsSearchAllResponseMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2TweetsSearchAllResponseMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Get2TweetsSearchAllResponseMeta get2TweetsSearchAllResponseMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, get2TweetsSearchAllResponseMeta, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Get2TweetsSearchAllResponseMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2TweetsSearchAllResponseMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Get2TweetsSearchAllResponseMeta get2TweetsSearchAllResponseMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            if (get2TweetsSearchAllResponseMeta.NewestIdOption.IsSet && get2TweetsSearchAllResponseMeta.NewestId == null)
                throw new ArgumentNullException(nameof(get2TweetsSearchAllResponseMeta.NewestId), "Property is required for class Get2TweetsSearchAllResponseMeta.");

            if (get2TweetsSearchAllResponseMeta.NextTokenOption.IsSet && get2TweetsSearchAllResponseMeta.NextToken == null)
                throw new ArgumentNullException(nameof(get2TweetsSearchAllResponseMeta.NextToken), "Property is required for class Get2TweetsSearchAllResponseMeta.");

            if (get2TweetsSearchAllResponseMeta.OldestIdOption.IsSet && get2TweetsSearchAllResponseMeta.OldestId == null)
                throw new ArgumentNullException(nameof(get2TweetsSearchAllResponseMeta.OldestId), "Property is required for class Get2TweetsSearchAllResponseMeta.");

            if (get2TweetsSearchAllResponseMeta.NewestIdOption.IsSet)
                writer.WriteString("newest_id", get2TweetsSearchAllResponseMeta.NewestId);

            if (get2TweetsSearchAllResponseMeta.NextTokenOption.IsSet)
                writer.WriteString("next_token", get2TweetsSearchAllResponseMeta.NextToken);

            if (get2TweetsSearchAllResponseMeta.OldestIdOption.IsSet)
                writer.WriteString("oldest_id", get2TweetsSearchAllResponseMeta.OldestId);

            if (get2TweetsSearchAllResponseMeta.ResultCountOption.IsSet)
                writer.WriteNumber("result_count", get2TweetsSearchAllResponseMeta.ResultCountOption.Value!.Value);
        }
    }
}

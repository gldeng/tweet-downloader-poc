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
    /// Get2LikesFirehoseStreamResponse
    /// </summary>
    public partial class Get2LikesFirehoseStreamResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get2LikesFirehoseStreamResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="errors">errors</param>
        /// <param name="includes">includes</param>
        [JsonConstructor]
        public Get2LikesFirehoseStreamResponse(Option<LikeWithTweetAuthor?> data = default, Option<List<Problem>?> errors = default, Option<Expansions?> includes = default)
        {
            DataOption = data;
            ErrorsOption = errors;
            IncludesOption = includes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<LikeWithTweetAuthor?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public LikeWithTweetAuthor? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

        /// <summary>
        /// Used to track the state of Errors
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Problem>?> ErrorsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Problem>? Errors { get { return this.ErrorsOption; } set { this.ErrorsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Includes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Expansions?> IncludesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [JsonPropertyName("includes")]
        public Expansions? Includes { get { return this.IncludesOption; } set { this.IncludesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Get2LikesFirehoseStreamResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
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
    /// A Json converter for type <see cref="Get2LikesFirehoseStreamResponse" />
    /// </summary>
    public class Get2LikesFirehoseStreamResponseJsonConverter : JsonConverter<Get2LikesFirehoseStreamResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="Get2LikesFirehoseStreamResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Get2LikesFirehoseStreamResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<LikeWithTweetAuthor?> data = default;
            Option<List<Problem>?> errors = default;
            Option<Expansions?> includes = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<LikeWithTweetAuthor?>(JsonSerializer.Deserialize<LikeWithTweetAuthor>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<Problem>?>(JsonSerializer.Deserialize<List<Problem>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "includes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                includes = new Option<Expansions?>(JsonSerializer.Deserialize<Expansions>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class Get2LikesFirehoseStreamResponse.");

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class Get2LikesFirehoseStreamResponse.");

            if (includes.IsSet && includes.Value == null)
                throw new ArgumentNullException(nameof(includes), "Property is not nullable for class Get2LikesFirehoseStreamResponse.");

            return new Get2LikesFirehoseStreamResponse(data, errors, includes);
        }

        /// <summary>
        /// Serializes a <see cref="Get2LikesFirehoseStreamResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2LikesFirehoseStreamResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Get2LikesFirehoseStreamResponse get2LikesFirehoseStreamResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, get2LikesFirehoseStreamResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Get2LikesFirehoseStreamResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2LikesFirehoseStreamResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Get2LikesFirehoseStreamResponse get2LikesFirehoseStreamResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (get2LikesFirehoseStreamResponse.DataOption.IsSet && get2LikesFirehoseStreamResponse.Data == null)
                throw new ArgumentNullException(nameof(get2LikesFirehoseStreamResponse.Data), "Property is required for class Get2LikesFirehoseStreamResponse.");

            if (get2LikesFirehoseStreamResponse.ErrorsOption.IsSet && get2LikesFirehoseStreamResponse.Errors == null)
                throw new ArgumentNullException(nameof(get2LikesFirehoseStreamResponse.Errors), "Property is required for class Get2LikesFirehoseStreamResponse.");

            if (get2LikesFirehoseStreamResponse.IncludesOption.IsSet && get2LikesFirehoseStreamResponse.Includes == null)
                throw new ArgumentNullException(nameof(get2LikesFirehoseStreamResponse.Includes), "Property is required for class Get2LikesFirehoseStreamResponse.");

            if (get2LikesFirehoseStreamResponse.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, get2LikesFirehoseStreamResponse.Data, jsonSerializerOptions);
            }
            if (get2LikesFirehoseStreamResponse.ErrorsOption.IsSet)
            {
                writer.WritePropertyName("errors");
                JsonSerializer.Serialize(writer, get2LikesFirehoseStreamResponse.Errors, jsonSerializerOptions);
            }
            if (get2LikesFirehoseStreamResponse.IncludesOption.IsSet)
            {
                writer.WritePropertyName("includes");
                JsonSerializer.Serialize(writer, get2LikesFirehoseStreamResponse.Includes, jsonSerializerOptions);
            }
        }
    }
}

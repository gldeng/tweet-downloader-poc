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
    /// Get2UsersSearchResponseMeta
    /// </summary>
    public partial class Get2UsersSearchResponseMeta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get2UsersSearchResponseMeta" /> class.
        /// </summary>
        /// <param name="nextToken">The next token.</param>
        /// <param name="previousToken">The previous token.</param>
        [JsonConstructor]
        public Get2UsersSearchResponseMeta(Option<string?> nextToken = default, Option<string?> previousToken = default)
        {
            NextTokenOption = nextToken;
            PreviousTokenOption = previousToken;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of PreviousToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PreviousTokenOption { get; private set; }

        /// <summary>
        /// The previous token.
        /// </summary>
        /// <value>The previous token.</value>
        [JsonPropertyName("previous_token")]
        public string? PreviousToken { get { return this.PreviousTokenOption; } set { this.PreviousTokenOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Get2UsersSearchResponseMeta {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  PreviousToken: ").Append(PreviousToken).Append("\n");
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

            // PreviousToken (string) minLength
            if (this.PreviousToken != null && this.PreviousToken.Length < 1)
            {
                yield return new ValidationResult("Invalid value for PreviousToken, length must be greater than 1.", new [] { "PreviousToken" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Get2UsersSearchResponseMeta" />
    /// </summary>
    public class Get2UsersSearchResponseMetaJsonConverter : JsonConverter<Get2UsersSearchResponseMeta>
    {
        /// <summary>
        /// Deserializes json to <see cref="Get2UsersSearchResponseMeta" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Get2UsersSearchResponseMeta Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> nextToken = default;
            Option<string?> previousToken = default;

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
                        case "next_token":
                            nextToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "previous_token":
                            previousToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (nextToken.IsSet && nextToken.Value == null)
                throw new ArgumentNullException(nameof(nextToken), "Property is not nullable for class Get2UsersSearchResponseMeta.");

            if (previousToken.IsSet && previousToken.Value == null)
                throw new ArgumentNullException(nameof(previousToken), "Property is not nullable for class Get2UsersSearchResponseMeta.");

            return new Get2UsersSearchResponseMeta(nextToken, previousToken);
        }

        /// <summary>
        /// Serializes a <see cref="Get2UsersSearchResponseMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2UsersSearchResponseMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Get2UsersSearchResponseMeta get2UsersSearchResponseMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, get2UsersSearchResponseMeta, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Get2UsersSearchResponseMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2UsersSearchResponseMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Get2UsersSearchResponseMeta get2UsersSearchResponseMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            if (get2UsersSearchResponseMeta.NextTokenOption.IsSet && get2UsersSearchResponseMeta.NextToken == null)
                throw new ArgumentNullException(nameof(get2UsersSearchResponseMeta.NextToken), "Property is required for class Get2UsersSearchResponseMeta.");

            if (get2UsersSearchResponseMeta.PreviousTokenOption.IsSet && get2UsersSearchResponseMeta.PreviousToken == null)
                throw new ArgumentNullException(nameof(get2UsersSearchResponseMeta.PreviousToken), "Property is required for class Get2UsersSearchResponseMeta.");

            if (get2UsersSearchResponseMeta.NextTokenOption.IsSet)
                writer.WriteString("next_token", get2UsersSearchResponseMeta.NextToken);

            if (get2UsersSearchResponseMeta.PreviousTokenOption.IsSet)
                writer.WriteString("previous_token", get2UsersSearchResponseMeta.PreviousToken);
        }
    }
}

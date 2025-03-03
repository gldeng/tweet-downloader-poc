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
    /// SubtitlesDeleteResponseData
    /// </summary>
    public partial class SubtitlesDeleteResponseData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitlesDeleteResponseData" /> class.
        /// </summary>
        /// <param name="deleted">deleted</param>
        [JsonConstructor]
        public SubtitlesDeleteResponseData(bool deleted)
        {
            Deleted = deleted;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubtitlesDeleteResponseData {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
    /// A Json converter for type <see cref="SubtitlesDeleteResponseData" />
    /// </summary>
    public class SubtitlesDeleteResponseDataJsonConverter : JsonConverter<SubtitlesDeleteResponseData>
    {
        /// <summary>
        /// Deserializes json to <see cref="SubtitlesDeleteResponseData" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SubtitlesDeleteResponseData Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> deleted = default;

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
                        case "deleted":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                deleted = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!deleted.IsSet)
                throw new ArgumentException("Property is required for class SubtitlesDeleteResponseData.", nameof(deleted));

            if (deleted.IsSet && deleted.Value == null)
                throw new ArgumentNullException(nameof(deleted), "Property is not nullable for class SubtitlesDeleteResponseData.");

            return new SubtitlesDeleteResponseData(deleted.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="SubtitlesDeleteResponseData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="subtitlesDeleteResponseData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SubtitlesDeleteResponseData subtitlesDeleteResponseData, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, subtitlesDeleteResponseData, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SubtitlesDeleteResponseData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="subtitlesDeleteResponseData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SubtitlesDeleteResponseData subtitlesDeleteResponseData, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteBoolean("deleted", subtitlesDeleteResponseData.Deleted);
        }
    }
}

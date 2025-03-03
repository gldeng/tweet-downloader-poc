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
    /// TweetUndropComplianceSchema
    /// </summary>
    public partial class TweetUndropComplianceSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetUndropComplianceSchema" /> class.
        /// </summary>
        /// <param name="undrop">undrop</param>
        [JsonConstructor]
        public TweetUndropComplianceSchema(TweetComplianceSchema undrop)
        {
            Undrop = undrop;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Undrop
        /// </summary>
        [JsonPropertyName("undrop")]
        public TweetComplianceSchema Undrop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TweetUndropComplianceSchema {\n");
            sb.Append("  Undrop: ").Append(Undrop).Append("\n");
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
    /// A Json converter for type <see cref="TweetUndropComplianceSchema" />
    /// </summary>
    public class TweetUndropComplianceSchemaJsonConverter : JsonConverter<TweetUndropComplianceSchema>
    {
        /// <summary>
        /// Deserializes json to <see cref="TweetUndropComplianceSchema" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TweetUndropComplianceSchema Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<TweetComplianceSchema?> undrop = default;

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
                        case "undrop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                undrop = new Option<TweetComplianceSchema?>(JsonSerializer.Deserialize<TweetComplianceSchema>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!undrop.IsSet)
                throw new ArgumentException("Property is required for class TweetUndropComplianceSchema.", nameof(undrop));

            if (undrop.IsSet && undrop.Value == null)
                throw new ArgumentNullException(nameof(undrop), "Property is not nullable for class TweetUndropComplianceSchema.");

            return new TweetUndropComplianceSchema(undrop.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TweetUndropComplianceSchema" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetUndropComplianceSchema"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TweetUndropComplianceSchema tweetUndropComplianceSchema, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tweetUndropComplianceSchema, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TweetUndropComplianceSchema" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetUndropComplianceSchema"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TweetUndropComplianceSchema tweetUndropComplianceSchema, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tweetUndropComplianceSchema.Undrop == null)
                throw new ArgumentNullException(nameof(tweetUndropComplianceSchema.Undrop), "Property is required for class TweetUndropComplianceSchema.");

            writer.WritePropertyName("undrop");
            JsonSerializer.Serialize(writer, tweetUndropComplianceSchema.Undrop, jsonSerializerOptions);
        }
    }
}

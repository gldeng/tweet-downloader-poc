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
    /// Represent the portion of text recognized as a Hashtag, and its start and end position within the text.
    /// </summary>
    public partial class HashtagFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HashtagFields" /> class.
        /// </summary>
        /// <param name="tag">The text of the Hashtag.</param>
        [JsonConstructor]
        public HashtagFields(string tag)
        {
            Tag = tag;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The text of the Hashtag.
        /// </summary>
        /// <value>The text of the Hashtag.</value>
        /* <example>MondayMotivation</example> */
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HashtagFields {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
    /// A Json converter for type <see cref="HashtagFields" />
    /// </summary>
    public class HashtagFieldsJsonConverter : JsonConverter<HashtagFields>
    {
        /// <summary>
        /// Deserializes json to <see cref="HashtagFields" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HashtagFields Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> tag = default;

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
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!tag.IsSet)
                throw new ArgumentException("Property is required for class HashtagFields.", nameof(tag));

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class HashtagFields.");

            return new HashtagFields(tag.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="HashtagFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hashtagFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HashtagFields hashtagFields, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, hashtagFields, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="HashtagFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hashtagFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, HashtagFields hashtagFields, JsonSerializerOptions jsonSerializerOptions)
        {
            if (hashtagFields.Tag == null)
                throw new ArgumentNullException(nameof(hashtagFields.Tag), "Property is required for class HashtagFields.");

            writer.WriteString("tag", hashtagFields.Tag);
        }
    }
}

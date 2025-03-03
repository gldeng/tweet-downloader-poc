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
    /// A list of metadata found in the User&#39;s profile description.
    /// </summary>
    public partial class UserEntities : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntities" /> class.
        /// </summary>
        /// <param name="description">description</param>
        /// <param name="url">url</param>
        [JsonConstructor]
        public UserEntities(Option<FullTextEntities?> description = default, Option<UserEntitiesUrl?> url = default)
        {
            DescriptionOption = description;
            UrlOption = url;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FullTextEntities?> DescriptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public FullTextEntities? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Url
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserEntitiesUrl?> UrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public UserEntitiesUrl? Url { get { return this.UrlOption; } set { this.UrlOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEntities {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
    /// A Json converter for type <see cref="UserEntities" />
    /// </summary>
    public class UserEntitiesJsonConverter : JsonConverter<UserEntities>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserEntities" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserEntities Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<FullTextEntities?> description = default;
            Option<UserEntitiesUrl?> url = default;

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
                        case "description":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                description = new Option<FullTextEntities?>(JsonSerializer.Deserialize<FullTextEntities>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "url":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                url = new Option<UserEntitiesUrl?>(JsonSerializer.Deserialize<UserEntitiesUrl>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class UserEntities.");

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class UserEntities.");

            return new UserEntities(description, url);
        }

        /// <summary>
        /// Serializes a <see cref="UserEntities" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userEntities"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserEntities userEntities, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userEntities, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserEntities" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userEntities"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserEntities userEntities, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userEntities.DescriptionOption.IsSet && userEntities.Description == null)
                throw new ArgumentNullException(nameof(userEntities.Description), "Property is required for class UserEntities.");

            if (userEntities.UrlOption.IsSet && userEntities.Url == null)
                throw new ArgumentNullException(nameof(userEntities.Url), "Property is required for class UserEntities.");

            if (userEntities.DescriptionOption.IsSet)
            {
                writer.WritePropertyName("description");
                JsonSerializer.Serialize(writer, userEntities.Description, jsonSerializerOptions);
            }
            if (userEntities.UrlOption.IsSet)
            {
                writer.WritePropertyName("url");
                JsonSerializer.Serialize(writer, userEntities.Url, jsonSerializerOptions);
            }
        }
    }
}

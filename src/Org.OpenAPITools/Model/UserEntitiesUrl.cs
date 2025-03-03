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
    /// Expanded details for the URL specified in the User&#39;s profile, with start and end indices.
    /// </summary>
    public partial class UserEntitiesUrl : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntitiesUrl" /> class.
        /// </summary>
        /// <param name="urls">urls</param>
        [JsonConstructor]
        public UserEntitiesUrl(Option<List<UrlEntity>?> urls = default)
        {
            UrlsOption = urls;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Urls
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UrlEntity>?> UrlsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [JsonPropertyName("urls")]
        public List<UrlEntity>? Urls { get { return this.UrlsOption; } set { this.UrlsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEntitiesUrl {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
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
    /// A Json converter for type <see cref="UserEntitiesUrl" />
    /// </summary>
    public class UserEntitiesUrlJsonConverter : JsonConverter<UserEntitiesUrl>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserEntitiesUrl" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserEntitiesUrl Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<UrlEntity>?> urls = default;

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
                        case "urls":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                urls = new Option<List<UrlEntity>?>(JsonSerializer.Deserialize<List<UrlEntity>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (urls.IsSet && urls.Value == null)
                throw new ArgumentNullException(nameof(urls), "Property is not nullable for class UserEntitiesUrl.");

            return new UserEntitiesUrl(urls);
        }

        /// <summary>
        /// Serializes a <see cref="UserEntitiesUrl" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userEntitiesUrl"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserEntitiesUrl userEntitiesUrl, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userEntitiesUrl, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserEntitiesUrl" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userEntitiesUrl"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserEntitiesUrl userEntitiesUrl, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userEntitiesUrl.UrlsOption.IsSet && userEntitiesUrl.Urls == null)
                throw new ArgumentNullException(nameof(userEntitiesUrl.Urls), "Property is required for class UserEntitiesUrl.");

            if (userEntitiesUrl.UrlsOption.IsSet)
            {
                writer.WritePropertyName("urls");
                JsonSerializer.Serialize(writer, userEntitiesUrl.Urls, jsonSerializerOptions);
            }
        }
    }
}

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
    /// Get2SpacesIdBuyersResponse
    /// </summary>
    public partial class Get2SpacesIdBuyersResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get2SpacesIdBuyersResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="errors">errors</param>
        /// <param name="includes">includes</param>
        /// <param name="meta">meta</param>
        [JsonConstructor]
        public Get2SpacesIdBuyersResponse(Option<List<User>?> data = default, Option<List<Problem>?> errors = default, Option<Expansions?> includes = default, Option<Get2DmConversationsIdDmEventsResponseMeta?> meta = default)
        {
            DataOption = data;
            ErrorsOption = errors;
            IncludesOption = includes;
            MetaOption = meta;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<User>?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<User>? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

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
        /// Used to track the state of Meta
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Get2DmConversationsIdDmEventsResponseMeta?> MetaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public Get2DmConversationsIdDmEventsResponseMeta? Meta { get { return this.MetaOption; } set { this.MetaOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Get2SpacesIdBuyersResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
    /// A Json converter for type <see cref="Get2SpacesIdBuyersResponse" />
    /// </summary>
    public class Get2SpacesIdBuyersResponseJsonConverter : JsonConverter<Get2SpacesIdBuyersResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="Get2SpacesIdBuyersResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Get2SpacesIdBuyersResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<User>?> data = default;
            Option<List<Problem>?> errors = default;
            Option<Expansions?> includes = default;
            Option<Get2DmConversationsIdDmEventsResponseMeta?> meta = default;

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
                                data = new Option<List<User>?>(JsonSerializer.Deserialize<List<User>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<Problem>?>(JsonSerializer.Deserialize<List<Problem>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "includes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                includes = new Option<Expansions?>(JsonSerializer.Deserialize<Expansions>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "meta":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                meta = new Option<Get2DmConversationsIdDmEventsResponseMeta?>(JsonSerializer.Deserialize<Get2DmConversationsIdDmEventsResponseMeta>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class Get2SpacesIdBuyersResponse.");

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class Get2SpacesIdBuyersResponse.");

            if (includes.IsSet && includes.Value == null)
                throw new ArgumentNullException(nameof(includes), "Property is not nullable for class Get2SpacesIdBuyersResponse.");

            if (meta.IsSet && meta.Value == null)
                throw new ArgumentNullException(nameof(meta), "Property is not nullable for class Get2SpacesIdBuyersResponse.");

            return new Get2SpacesIdBuyersResponse(data, errors, includes, meta);
        }

        /// <summary>
        /// Serializes a <see cref="Get2SpacesIdBuyersResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2SpacesIdBuyersResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Get2SpacesIdBuyersResponse get2SpacesIdBuyersResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, get2SpacesIdBuyersResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Get2SpacesIdBuyersResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2SpacesIdBuyersResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Get2SpacesIdBuyersResponse get2SpacesIdBuyersResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (get2SpacesIdBuyersResponse.DataOption.IsSet && get2SpacesIdBuyersResponse.Data == null)
                throw new ArgumentNullException(nameof(get2SpacesIdBuyersResponse.Data), "Property is required for class Get2SpacesIdBuyersResponse.");

            if (get2SpacesIdBuyersResponse.ErrorsOption.IsSet && get2SpacesIdBuyersResponse.Errors == null)
                throw new ArgumentNullException(nameof(get2SpacesIdBuyersResponse.Errors), "Property is required for class Get2SpacesIdBuyersResponse.");

            if (get2SpacesIdBuyersResponse.IncludesOption.IsSet && get2SpacesIdBuyersResponse.Includes == null)
                throw new ArgumentNullException(nameof(get2SpacesIdBuyersResponse.Includes), "Property is required for class Get2SpacesIdBuyersResponse.");

            if (get2SpacesIdBuyersResponse.MetaOption.IsSet && get2SpacesIdBuyersResponse.Meta == null)
                throw new ArgumentNullException(nameof(get2SpacesIdBuyersResponse.Meta), "Property is required for class Get2SpacesIdBuyersResponse.");

            if (get2SpacesIdBuyersResponse.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, get2SpacesIdBuyersResponse.Data, jsonSerializerOptions);
            }
            if (get2SpacesIdBuyersResponse.ErrorsOption.IsSet)
            {
                writer.WritePropertyName("errors");
                JsonSerializer.Serialize(writer, get2SpacesIdBuyersResponse.Errors, jsonSerializerOptions);
            }
            if (get2SpacesIdBuyersResponse.IncludesOption.IsSet)
            {
                writer.WritePropertyName("includes");
                JsonSerializer.Serialize(writer, get2SpacesIdBuyersResponse.Includes, jsonSerializerOptions);
            }
            if (get2SpacesIdBuyersResponse.MetaOption.IsSet)
            {
                writer.WritePropertyName("meta");
                JsonSerializer.Serialize(writer, get2SpacesIdBuyersResponse.Meta, jsonSerializerOptions);
            }
        }
    }
}

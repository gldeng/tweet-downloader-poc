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
    /// Get2CommunitiesSearchResponse
    /// </summary>
    public partial class Get2CommunitiesSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get2CommunitiesSearchResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="errors">errors</param>
        /// <param name="meta">meta</param>
        [JsonConstructor]
        public Get2CommunitiesSearchResponse(Option<List<Community>?> data = default, Option<List<Problem>?> errors = default, Option<Get2CommunitiesSearchResponseMeta?> meta = default)
        {
            DataOption = data;
            ErrorsOption = errors;
            MetaOption = meta;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Community>?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<Community>? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

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
        /// Used to track the state of Meta
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Get2CommunitiesSearchResponseMeta?> MetaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public Get2CommunitiesSearchResponseMeta? Meta { get { return this.MetaOption; } set { this.MetaOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Get2CommunitiesSearchResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
    /// A Json converter for type <see cref="Get2CommunitiesSearchResponse" />
    /// </summary>
    public class Get2CommunitiesSearchResponseJsonConverter : JsonConverter<Get2CommunitiesSearchResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="Get2CommunitiesSearchResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Get2CommunitiesSearchResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Community>?> data = default;
            Option<List<Problem>?> errors = default;
            Option<Get2CommunitiesSearchResponseMeta?> meta = default;

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
                                data = new Option<List<Community>?>(JsonSerializer.Deserialize<List<Community>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<Problem>?>(JsonSerializer.Deserialize<List<Problem>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "meta":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                meta = new Option<Get2CommunitiesSearchResponseMeta?>(JsonSerializer.Deserialize<Get2CommunitiesSearchResponseMeta>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class Get2CommunitiesSearchResponse.");

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class Get2CommunitiesSearchResponse.");

            if (meta.IsSet && meta.Value == null)
                throw new ArgumentNullException(nameof(meta), "Property is not nullable for class Get2CommunitiesSearchResponse.");

            return new Get2CommunitiesSearchResponse(data, errors, meta);
        }

        /// <summary>
        /// Serializes a <see cref="Get2CommunitiesSearchResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2CommunitiesSearchResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Get2CommunitiesSearchResponse get2CommunitiesSearchResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, get2CommunitiesSearchResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Get2CommunitiesSearchResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="get2CommunitiesSearchResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Get2CommunitiesSearchResponse get2CommunitiesSearchResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (get2CommunitiesSearchResponse.DataOption.IsSet && get2CommunitiesSearchResponse.Data == null)
                throw new ArgumentNullException(nameof(get2CommunitiesSearchResponse.Data), "Property is required for class Get2CommunitiesSearchResponse.");

            if (get2CommunitiesSearchResponse.ErrorsOption.IsSet && get2CommunitiesSearchResponse.Errors == null)
                throw new ArgumentNullException(nameof(get2CommunitiesSearchResponse.Errors), "Property is required for class Get2CommunitiesSearchResponse.");

            if (get2CommunitiesSearchResponse.MetaOption.IsSet && get2CommunitiesSearchResponse.Meta == null)
                throw new ArgumentNullException(nameof(get2CommunitiesSearchResponse.Meta), "Property is required for class Get2CommunitiesSearchResponse.");

            if (get2CommunitiesSearchResponse.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, get2CommunitiesSearchResponse.Data, jsonSerializerOptions);
            }
            if (get2CommunitiesSearchResponse.ErrorsOption.IsSet)
            {
                writer.WritePropertyName("errors");
                JsonSerializer.Serialize(writer, get2CommunitiesSearchResponse.Errors, jsonSerializerOptions);
            }
            if (get2CommunitiesSearchResponse.MetaOption.IsSet)
            {
                writer.WritePropertyName("meta");
                JsonSerializer.Serialize(writer, get2CommunitiesSearchResponse.Meta, jsonSerializerOptions);
            }
        }
    }
}

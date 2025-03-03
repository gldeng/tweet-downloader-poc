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
    /// Annotation inferred from the Tweet text.
    /// </summary>
    public partial class ContextAnnotation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAnnotation" /> class.
        /// </summary>
        /// <param name="domain">domain</param>
        /// <param name="entity">entity</param>
        [JsonConstructor]
        public ContextAnnotation(ContextAnnotationDomainFields domain, ContextAnnotationEntityFields entity)
        {
            Domain = domain;
            Entity = entity;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [JsonPropertyName("domain")]
        public ContextAnnotationDomainFields Domain { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [JsonPropertyName("entity")]
        public ContextAnnotationEntityFields Entity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContextAnnotation {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
    /// A Json converter for type <see cref="ContextAnnotation" />
    /// </summary>
    public class ContextAnnotationJsonConverter : JsonConverter<ContextAnnotation>
    {
        /// <summary>
        /// Deserializes json to <see cref="ContextAnnotation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ContextAnnotation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ContextAnnotationDomainFields?> domain = default;
            Option<ContextAnnotationEntityFields?> entity = default;

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
                        case "domain":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                domain = new Option<ContextAnnotationDomainFields?>(JsonSerializer.Deserialize<ContextAnnotationDomainFields>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "entity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                entity = new Option<ContextAnnotationEntityFields?>(JsonSerializer.Deserialize<ContextAnnotationEntityFields>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!domain.IsSet)
                throw new ArgumentException("Property is required for class ContextAnnotation.", nameof(domain));

            if (!entity.IsSet)
                throw new ArgumentException("Property is required for class ContextAnnotation.", nameof(entity));

            if (domain.IsSet && domain.Value == null)
                throw new ArgumentNullException(nameof(domain), "Property is not nullable for class ContextAnnotation.");

            if (entity.IsSet && entity.Value == null)
                throw new ArgumentNullException(nameof(entity), "Property is not nullable for class ContextAnnotation.");

            return new ContextAnnotation(domain.Value!, entity.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ContextAnnotation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contextAnnotation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ContextAnnotation contextAnnotation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, contextAnnotation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ContextAnnotation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contextAnnotation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ContextAnnotation contextAnnotation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (contextAnnotation.Domain == null)
                throw new ArgumentNullException(nameof(contextAnnotation.Domain), "Property is required for class ContextAnnotation.");

            if (contextAnnotation.Entity == null)
                throw new ArgumentNullException(nameof(contextAnnotation.Entity), "Property is required for class ContextAnnotation.");

            writer.WritePropertyName("domain");
            JsonSerializer.Serialize(writer, contextAnnotation.Domain, jsonSerializerOptions);
            writer.WritePropertyName("entity");
            JsonSerializer.Serialize(writer, contextAnnotation.Entity, jsonSerializerOptions);
        }
    }
}

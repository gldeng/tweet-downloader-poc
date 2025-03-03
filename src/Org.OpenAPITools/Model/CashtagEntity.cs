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
    /// CashtagEntity
    /// </summary>
    public partial class CashtagEntity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashtagEntity" /> class.
        /// </summary>
        /// <param name="end">Index (zero-based) at which position this entity ends.  The index is exclusive.</param>
        /// <param name="start">Index (zero-based) at which position this entity starts.  The index is inclusive.</param>
        /// <param name="tag">tag</param>
        [JsonConstructor]
        public CashtagEntity(int end, int start, string tag)
        {
            End = end;
            Start = start;
            Tag = tag;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Index (zero-based) at which position this entity ends.  The index is exclusive.
        /// </summary>
        /// <value>Index (zero-based) at which position this entity ends.  The index is exclusive.</value>
        /* <example>61</example> */
        [JsonPropertyName("end")]
        public int End { get; set; }

        /// <summary>
        /// Index (zero-based) at which position this entity starts.  The index is inclusive.
        /// </summary>
        /// <value>Index (zero-based) at which position this entity starts.  The index is inclusive.</value>
        /* <example>50</example> */
        [JsonPropertyName("start")]
        public int Start { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        /* <example>TWTR</example> */
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashtagEntity {\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
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
            // End (int) minimum
            if (this.End < (int)0)
            {
                yield return new ValidationResult("Invalid value for End, must be a value greater than or equal to 0.", new [] { "End" });
            }

            // Start (int) minimum
            if (this.Start < (int)0)
            {
                yield return new ValidationResult("Invalid value for Start, must be a value greater than or equal to 0.", new [] { "Start" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CashtagEntity" />
    /// </summary>
    public class CashtagEntityJsonConverter : JsonConverter<CashtagEntity>
    {
        /// <summary>
        /// Deserializes json to <see cref="CashtagEntity" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CashtagEntity Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> end = default;
            Option<int?> start = default;
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
                        case "end":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                end = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "start":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                start = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!end.IsSet)
                throw new ArgumentException("Property is required for class CashtagEntity.", nameof(end));

            if (!start.IsSet)
                throw new ArgumentException("Property is required for class CashtagEntity.", nameof(start));

            if (!tag.IsSet)
                throw new ArgumentException("Property is required for class CashtagEntity.", nameof(tag));

            if (end.IsSet && end.Value == null)
                throw new ArgumentNullException(nameof(end), "Property is not nullable for class CashtagEntity.");

            if (start.IsSet && start.Value == null)
                throw new ArgumentNullException(nameof(start), "Property is not nullable for class CashtagEntity.");

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class CashtagEntity.");

            return new CashtagEntity(end.Value!.Value!, start.Value!.Value!, tag.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CashtagEntity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cashtagEntity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CashtagEntity cashtagEntity, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, cashtagEntity, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CashtagEntity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cashtagEntity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CashtagEntity cashtagEntity, JsonSerializerOptions jsonSerializerOptions)
        {
            if (cashtagEntity.Tag == null)
                throw new ArgumentNullException(nameof(cashtagEntity.Tag), "Property is required for class CashtagEntity.");

            writer.WriteNumber("end", cashtagEntity.End);

            writer.WriteNumber("start", cashtagEntity.Start);

            writer.WriteString("tag", cashtagEntity.Tag);
        }
    }
}

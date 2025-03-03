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
    /// The rule you have submitted is invalid.
    /// </summary>
    public partial class InvalidRuleProblem : Problem, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRuleProblem" /> class.
        /// </summary>
        /// <param name="title">title</param>
        /// <param name="detail">detail</param>
        /// <param name="status">status</param>
        [JsonConstructor]
        public InvalidRuleProblem(string title, Option<string?> detail = default, Option<int?> status = default) : base(title, detail, status)
        {
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvalidRuleProblem {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="InvalidRuleProblem" />
    /// </summary>
    public class InvalidRuleProblemJsonConverter : JsonConverter<InvalidRuleProblem>
    {
        /// <summary>
        /// Deserializes json to <see cref="InvalidRuleProblem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InvalidRuleProblem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> title = default;
            Option<string?> type = default;
            Option<string?> detail = default;
            Option<int?> status = default;

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
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "detail":
                            detail = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!title.IsSet)
                throw new ArgumentException("Property is required for class InvalidRuleProblem.", nameof(title));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class InvalidRuleProblem.", nameof(type));

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class InvalidRuleProblem.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class InvalidRuleProblem.");

            if (detail.IsSet && detail.Value == null)
                throw new ArgumentNullException(nameof(detail), "Property is not nullable for class InvalidRuleProblem.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class InvalidRuleProblem.");

            return new InvalidRuleProblem(title.Value!, detail, status);
        }

        /// <summary>
        /// Serializes a <see cref="InvalidRuleProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="invalidRuleProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InvalidRuleProblem invalidRuleProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, invalidRuleProblem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InvalidRuleProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="invalidRuleProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InvalidRuleProblem invalidRuleProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (invalidRuleProblem.Title == null)
                throw new ArgumentNullException(nameof(invalidRuleProblem.Title), "Property is required for class InvalidRuleProblem.");

            if (invalidRuleProblem.DetailOption.IsSet && invalidRuleProblem.Detail == null)
                throw new ArgumentNullException(nameof(invalidRuleProblem.Detail), "Property is required for class InvalidRuleProblem.");

            writer.WriteString("title", invalidRuleProblem.Title);

            writer.WriteString("type", invalidRuleProblem.Type);

            if (invalidRuleProblem.DetailOption.IsSet)
                writer.WriteString("detail", invalidRuleProblem.Detail);

            if (invalidRuleProblem.StatusOption.IsSet)
                writer.WriteNumber("status", invalidRuleProblem.StatusOption.Value!.Value);
        }
    }
}

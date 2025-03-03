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
    /// IDs and values of all deleted user-specified stream filtering rules.
    /// </summary>
    public partial class DeleteRulesRequestDelete : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRulesRequestDelete" /> class.
        /// </summary>
        /// <param name="ids">IDs of all deleted user-specified stream filtering rules.</param>
        /// <param name="values">Values of all deleted user-specified stream filtering rules.</param>
        [JsonConstructor]
        public DeleteRulesRequestDelete(Option<List<string>?> ids = default, Option<List<string>?> values = default)
        {
            IdsOption = ids;
            ValuesOption = values;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Ids
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> IdsOption { get; private set; }

        /// <summary>
        /// IDs of all deleted user-specified stream filtering rules.
        /// </summary>
        /// <value>IDs of all deleted user-specified stream filtering rules.</value>
        [JsonPropertyName("ids")]
        public List<string>? Ids { get { return this.IdsOption; } set { this.IdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Values
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> ValuesOption { get; private set; }

        /// <summary>
        /// Values of all deleted user-specified stream filtering rules.
        /// </summary>
        /// <value>Values of all deleted user-specified stream filtering rules.</value>
        [JsonPropertyName("values")]
        public List<string>? Values { get { return this.ValuesOption; } set { this.ValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteRulesRequestDelete {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
    /// A Json converter for type <see cref="DeleteRulesRequestDelete" />
    /// </summary>
    public class DeleteRulesRequestDeleteJsonConverter : JsonConverter<DeleteRulesRequestDelete>
    {
        /// <summary>
        /// Deserializes json to <see cref="DeleteRulesRequestDelete" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DeleteRulesRequestDelete Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> ids = default;
            Option<List<string>?> values = default;

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
                        case "ids":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ids = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "values":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                values = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ids.IsSet && ids.Value == null)
                throw new ArgumentNullException(nameof(ids), "Property is not nullable for class DeleteRulesRequestDelete.");

            if (values.IsSet && values.Value == null)
                throw new ArgumentNullException(nameof(values), "Property is not nullable for class DeleteRulesRequestDelete.");

            return new DeleteRulesRequestDelete(ids, values);
        }

        /// <summary>
        /// Serializes a <see cref="DeleteRulesRequestDelete" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deleteRulesRequestDelete"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DeleteRulesRequestDelete deleteRulesRequestDelete, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, deleteRulesRequestDelete, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DeleteRulesRequestDelete" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deleteRulesRequestDelete"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DeleteRulesRequestDelete deleteRulesRequestDelete, JsonSerializerOptions jsonSerializerOptions)
        {
            if (deleteRulesRequestDelete.IdsOption.IsSet && deleteRulesRequestDelete.Ids == null)
                throw new ArgumentNullException(nameof(deleteRulesRequestDelete.Ids), "Property is required for class DeleteRulesRequestDelete.");

            if (deleteRulesRequestDelete.ValuesOption.IsSet && deleteRulesRequestDelete.Values == null)
                throw new ArgumentNullException(nameof(deleteRulesRequestDelete.Values), "Property is required for class DeleteRulesRequestDelete.");

            if (deleteRulesRequestDelete.IdsOption.IsSet)
            {
                writer.WritePropertyName("ids");
                JsonSerializer.Serialize(writer, deleteRulesRequestDelete.Ids, jsonSerializerOptions);
            }
            if (deleteRulesRequestDelete.ValuesOption.IsSet)
            {
                writer.WritePropertyName("values");
                JsonSerializer.Serialize(writer, deleteRulesRequestDelete.Values, jsonSerializerOptions);
            }
        }
    }
}

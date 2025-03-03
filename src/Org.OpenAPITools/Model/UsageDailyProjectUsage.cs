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
    /// The daily usage breakdown for a project
    /// </summary>
    public partial class UsageDailyProjectUsage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDailyProjectUsage" /> class.
        /// </summary>
        /// <param name="projectId">The unique identifier for this project</param>
        /// <param name="usage">The usage value</param>
        [JsonConstructor]
        public UsageDailyProjectUsage(Option<int?> projectId = default, Option<List<UsageFields>?> usage = default)
        {
            ProjectIdOption = projectId;
            UsageOption = usage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ProjectId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ProjectIdOption { get; private set; }

        /// <summary>
        /// The unique identifier for this project
        /// </summary>
        /// <value>The unique identifier for this project</value>
        [JsonPropertyName("project_id")]
        public int? ProjectId { get { return this.ProjectIdOption; } set { this.ProjectIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Usage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UsageFields>?> UsageOption { get; private set; }

        /// <summary>
        /// The usage value
        /// </summary>
        /// <value>The usage value</value>
        [JsonPropertyName("usage")]
        public List<UsageFields>? Usage { get { return this.UsageOption; } set { this.UsageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsageDailyProjectUsage {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
    /// A Json converter for type <see cref="UsageDailyProjectUsage" />
    /// </summary>
    public class UsageDailyProjectUsageJsonConverter : JsonConverter<UsageDailyProjectUsage>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsageDailyProjectUsage" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsageDailyProjectUsage Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> projectId = default;
            Option<List<UsageFields>?> usage = default;

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
                        case "project_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                projectId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "usage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                usage = new Option<List<UsageFields>?>(JsonSerializer.Deserialize<List<UsageFields>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (projectId.IsSet && projectId.Value == null)
                throw new ArgumentNullException(nameof(projectId), "Property is not nullable for class UsageDailyProjectUsage.");

            if (usage.IsSet && usage.Value == null)
                throw new ArgumentNullException(nameof(usage), "Property is not nullable for class UsageDailyProjectUsage.");

            return new UsageDailyProjectUsage(projectId, usage);
        }

        /// <summary>
        /// Serializes a <see cref="UsageDailyProjectUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usageDailyProjectUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsageDailyProjectUsage usageDailyProjectUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usageDailyProjectUsage, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsageDailyProjectUsage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usageDailyProjectUsage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsageDailyProjectUsage usageDailyProjectUsage, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usageDailyProjectUsage.UsageOption.IsSet && usageDailyProjectUsage.Usage == null)
                throw new ArgumentNullException(nameof(usageDailyProjectUsage.Usage), "Property is required for class UsageDailyProjectUsage.");

            if (usageDailyProjectUsage.ProjectIdOption.IsSet)
                writer.WriteNumber("project_id", usageDailyProjectUsage.ProjectIdOption.Value!.Value);

            if (usageDailyProjectUsage.UsageOption.IsSet)
            {
                writer.WritePropertyName("usage");
                JsonSerializer.Serialize(writer, usageDailyProjectUsage.Usage, jsonSerializerOptions);
            }
        }
    }
}

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
    /// FilteredStreamingTweetResponseMatchingRulesInner
    /// </summary>
    public partial class FilteredStreamingTweetResponseMatchingRulesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilteredStreamingTweetResponseMatchingRulesInner" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of this rule.</param>
        /// <param name="tag">A tag meant for the labeling of user provided rules.</param>
        [JsonConstructor]
        public FilteredStreamingTweetResponseMatchingRulesInner(string id, Option<string?> tag = default)
        {
            Id = id;
            TagOption = tag;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Unique identifier of this rule.
        /// </summary>
        /// <value>Unique identifier of this rule.</value>
        /* <example>120897978112909812</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Used to track the state of Tag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TagOption { get; private set; }

        /// <summary>
        /// A tag meant for the labeling of user provided rules.
        /// </summary>
        /// <value>A tag meant for the labeling of user provided rules.</value>
        /* <example>Non-retweeted coffee Posts</example> */
        [JsonPropertyName("tag")]
        public string? Tag { get { return this.TagOption; } set { this.TagOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilteredStreamingTweetResponseMatchingRulesInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            if (this.Id != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[0-9]{1,19}$", RegexOptions.CultureInvariant);

                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FilteredStreamingTweetResponseMatchingRulesInner" />
    /// </summary>
    public class FilteredStreamingTweetResponseMatchingRulesInnerJsonConverter : JsonConverter<FilteredStreamingTweetResponseMatchingRulesInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="FilteredStreamingTweetResponseMatchingRulesInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FilteredStreamingTweetResponseMatchingRulesInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class FilteredStreamingTweetResponseMatchingRulesInner.", nameof(id));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class FilteredStreamingTweetResponseMatchingRulesInner.");

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class FilteredStreamingTweetResponseMatchingRulesInner.");

            return new FilteredStreamingTweetResponseMatchingRulesInner(id.Value!, tag);
        }

        /// <summary>
        /// Serializes a <see cref="FilteredStreamingTweetResponseMatchingRulesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="filteredStreamingTweetResponseMatchingRulesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FilteredStreamingTweetResponseMatchingRulesInner filteredStreamingTweetResponseMatchingRulesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, filteredStreamingTweetResponseMatchingRulesInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FilteredStreamingTweetResponseMatchingRulesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="filteredStreamingTweetResponseMatchingRulesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FilteredStreamingTweetResponseMatchingRulesInner filteredStreamingTweetResponseMatchingRulesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (filteredStreamingTweetResponseMatchingRulesInner.Id == null)
                throw new ArgumentNullException(nameof(filteredStreamingTweetResponseMatchingRulesInner.Id), "Property is required for class FilteredStreamingTweetResponseMatchingRulesInner.");

            if (filteredStreamingTweetResponseMatchingRulesInner.TagOption.IsSet && filteredStreamingTweetResponseMatchingRulesInner.Tag == null)
                throw new ArgumentNullException(nameof(filteredStreamingTweetResponseMatchingRulesInner.Tag), "Property is required for class FilteredStreamingTweetResponseMatchingRulesInner.");

            writer.WriteString("id", filteredStreamingTweetResponseMatchingRulesInner.Id);

            if (filteredStreamingTweetResponseMatchingRulesInner.TagOption.IsSet)
                writer.WriteString("tag", filteredStreamingTweetResponseMatchingRulesInner.Tag);
        }
    }
}

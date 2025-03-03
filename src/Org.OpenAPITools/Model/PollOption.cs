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
    /// Describes a choice in a Poll object.
    /// </summary>
    public partial class PollOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollOption" /> class.
        /// </summary>
        /// <param name="label">The text of a poll choice.</param>
        /// <param name="position">Position of this choice in the poll.</param>
        /// <param name="votes">Number of users who voted for this choice.</param>
        [JsonConstructor]
        public PollOption(string label, int position, int votes)
        {
            Label = label;
            Position = position;
            Votes = votes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The text of a poll choice.
        /// </summary>
        /// <value>The text of a poll choice.</value>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Position of this choice in the poll.
        /// </summary>
        /// <value>Position of this choice in the poll.</value>
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Number of users who voted for this choice.
        /// </summary>
        /// <value>Number of users who voted for this choice.</value>
        [JsonPropertyName("votes")]
        public int Votes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollOption {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Votes: ").Append(Votes).Append("\n");
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
            // Label (string) maxLength
            if (this.Label != null && this.Label.Length > 25)
            {
                yield return new ValidationResult("Invalid value for Label, length must be less than 25.", new [] { "Label" });
            }

            // Label (string) minLength
            if (this.Label != null && this.Label.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Label, length must be greater than 1.", new [] { "Label" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PollOption" />
    /// </summary>
    public class PollOptionJsonConverter : JsonConverter<PollOption>
    {
        /// <summary>
        /// Deserializes json to <see cref="PollOption" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PollOption Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> label = default;
            Option<int?> position = default;
            Option<int?> votes = default;

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
                        case "label":
                            label = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "position":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                position = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "votes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                votes = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!label.IsSet)
                throw new ArgumentException("Property is required for class PollOption.", nameof(label));

            if (!position.IsSet)
                throw new ArgumentException("Property is required for class PollOption.", nameof(position));

            if (!votes.IsSet)
                throw new ArgumentException("Property is required for class PollOption.", nameof(votes));

            if (label.IsSet && label.Value == null)
                throw new ArgumentNullException(nameof(label), "Property is not nullable for class PollOption.");

            if (position.IsSet && position.Value == null)
                throw new ArgumentNullException(nameof(position), "Property is not nullable for class PollOption.");

            if (votes.IsSet && votes.Value == null)
                throw new ArgumentNullException(nameof(votes), "Property is not nullable for class PollOption.");

            return new PollOption(label.Value!, position.Value!.Value!, votes.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PollOption" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollOption"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PollOption pollOption, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, pollOption, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PollOption" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pollOption"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PollOption pollOption, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pollOption.Label == null)
                throw new ArgumentNullException(nameof(pollOption.Label), "Property is required for class PollOption.");

            writer.WriteString("label", pollOption.Label);

            writer.WriteNumber("position", pollOption.Position);

            writer.WriteNumber("votes", pollOption.Votes);
        }
    }
}

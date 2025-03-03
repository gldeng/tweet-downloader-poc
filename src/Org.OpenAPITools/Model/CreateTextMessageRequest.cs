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
    /// CreateTextMessageRequest
    /// </summary>
    public partial class CreateTextMessageRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextMessageRequest" /> class.
        /// </summary>
        /// <param name="text">Text of the message.</param>
        /// <param name="attachments">Attachments to a DM Event.</param>
        [JsonConstructor]
        public CreateTextMessageRequest(string text, Option<List<DmMediaAttachment>?> attachments = default)
        {
            Text = text;
            AttachmentsOption = attachments;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Text of the message.
        /// </summary>
        /// <value>Text of the message.</value>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Used to track the state of Attachments
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DmMediaAttachment>?> AttachmentsOption { get; private set; }

        /// <summary>
        /// Attachments to a DM Event.
        /// </summary>
        /// <value>Attachments to a DM Event.</value>
        [JsonPropertyName("attachments")]
        public List<DmMediaAttachment>? Attachments { get { return this.AttachmentsOption; } set { this.AttachmentsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTextMessageRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CreateTextMessageRequest" />
    /// </summary>
    public class CreateTextMessageRequestJsonConverter : JsonConverter<CreateTextMessageRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateTextMessageRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateTextMessageRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> text = default;
            Option<List<DmMediaAttachment>?> attachments = default;

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
                        case "text":
                            text = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "attachments":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attachments = new Option<List<DmMediaAttachment>?>(JsonSerializer.Deserialize<List<DmMediaAttachment>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!text.IsSet)
                throw new ArgumentException("Property is required for class CreateTextMessageRequest.", nameof(text));

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class CreateTextMessageRequest.");

            if (attachments.IsSet && attachments.Value == null)
                throw new ArgumentNullException(nameof(attachments), "Property is not nullable for class CreateTextMessageRequest.");

            return new CreateTextMessageRequest(text.Value!, attachments);
        }

        /// <summary>
        /// Serializes a <see cref="CreateTextMessageRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createTextMessageRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateTextMessageRequest createTextMessageRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createTextMessageRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateTextMessageRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createTextMessageRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateTextMessageRequest createTextMessageRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createTextMessageRequest.Text == null)
                throw new ArgumentNullException(nameof(createTextMessageRequest.Text), "Property is required for class CreateTextMessageRequest.");

            if (createTextMessageRequest.AttachmentsOption.IsSet && createTextMessageRequest.Attachments == null)
                throw new ArgumentNullException(nameof(createTextMessageRequest.Attachments), "Property is required for class CreateTextMessageRequest.");

            writer.WriteString("text", createTextMessageRequest.Text);

            if (createTextMessageRequest.AttachmentsOption.IsSet)
            {
                writer.WritePropertyName("attachments");
                JsonSerializer.Serialize(writer, createTextMessageRequest.Attachments, jsonSerializerOptions);
            }
        }
    }
}

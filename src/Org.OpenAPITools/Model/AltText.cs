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
    /// AltText
    /// </summary>
    public partial class AltText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AltText" /> class.
        /// </summary>
        /// <param name="text">Description of media ( &lt;&#x3D; 1000 characters )</param>
        [JsonConstructor]
        public AltText(Option<string?> text = default)
        {
            TextOption = text;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Text
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TextOption { get; private set; }

        /// <summary>
        /// Description of media ( &lt;&#x3D; 1000 characters )
        /// </summary>
        /// <value>Description of media ( &lt;&#x3D; 1000 characters )</value>
        /* <example>A dancing cat</example> */
        [JsonPropertyName("text")]
        public string? Text { get { return this.TextOption; } set { this.TextOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AltText {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            if (this.TextOption.Value != null) {
                // Text (string) pattern
                Regex regexText = new Regex(@"^.{0,1000}$", RegexOptions.CultureInvariant);

                if (this.TextOption.Value != null &&!regexText.Match(this.TextOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, must match a pattern of " + regexText, new [] { "Text" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AltText" />
    /// </summary>
    public class AltTextJsonConverter : JsonConverter<AltText>
    {
        /// <summary>
        /// Deserializes json to <see cref="AltText" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AltText Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> text = default;

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
                        default:
                            break;
                    }
                }
            }

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class AltText.");

            return new AltText(text);
        }

        /// <summary>
        /// Serializes a <see cref="AltText" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="altText"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AltText altText, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, altText, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AltText" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="altText"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AltText altText, JsonSerializerOptions jsonSerializerOptions)
        {
            if (altText.TextOption.IsSet && altText.Text == null)
                throw new ArgumentNullException(nameof(altText.Text), "Property is required for class AltText.");

            if (altText.TextOption.IsSet)
                writer.WriteString("text", altText.Text);
        }
    }
}

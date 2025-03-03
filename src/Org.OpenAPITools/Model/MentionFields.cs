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
    /// Represent the portion of text recognized as a User mention, and its start and end position within the text.
    /// </summary>
    public partial class MentionFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MentionFields" /> class.
        /// </summary>
        /// <param name="username">The X handle (screen name) of this user.</param>
        /// <param name="id">Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</param>
        [JsonConstructor]
        public MentionFields(string username, Option<string?> id = default)
        {
            Username = username;
            IdOption = id;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The X handle (screen name) of this user.
        /// </summary>
        /// <value>The X handle (screen name) of this user.</value>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.
        /// </summary>
        /// <value>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</value>
        /* <example>2244994945</example> */
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MentionFields {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            if (this.Username != null) {
                // Username (string) pattern
                Regex regexUsername = new Regex(@"^[A-Za-z0-9_]{1,15}$", RegexOptions.CultureInvariant);

                if (!regexUsername.Match(this.Username).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, must match a pattern of " + regexUsername, new [] { "Username" });
                }
            }

            if (this.IdOption.Value != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[0-9]{1,19}$", RegexOptions.CultureInvariant);

                if (this.IdOption.Value != null &&!regexId.Match(this.IdOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MentionFields" />
    /// </summary>
    public class MentionFieldsJsonConverter : JsonConverter<MentionFields>
    {
        /// <summary>
        /// Deserializes json to <see cref="MentionFields" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MentionFields Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> username = default;
            Option<string?> id = default;

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
                        case "username":
                            username = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!username.IsSet)
                throw new ArgumentException("Property is required for class MentionFields.", nameof(username));

            if (username.IsSet && username.Value == null)
                throw new ArgumentNullException(nameof(username), "Property is not nullable for class MentionFields.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class MentionFields.");

            return new MentionFields(username.Value!, id);
        }

        /// <summary>
        /// Serializes a <see cref="MentionFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mentionFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MentionFields mentionFields, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, mentionFields, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MentionFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mentionFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MentionFields mentionFields, JsonSerializerOptions jsonSerializerOptions)
        {
            if (mentionFields.Username == null)
                throw new ArgumentNullException(nameof(mentionFields.Username), "Property is required for class MentionFields.");

            if (mentionFields.IdOption.IsSet && mentionFields.Id == null)
                throw new ArgumentNullException(nameof(mentionFields.Id), "Property is required for class MentionFields.");

            writer.WriteString("username", mentionFields.Username);

            if (mentionFields.IdOption.IsSet)
                writer.WriteString("id", mentionFields.Id);
        }
    }
}

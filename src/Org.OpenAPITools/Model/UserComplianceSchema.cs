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
    /// UserComplianceSchema
    /// </summary>
    public partial class UserComplianceSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserComplianceSchema" /> class.
        /// </summary>
        /// <param name="eventAt">Event time.</param>
        /// <param name="user">user</param>
        [JsonConstructor]
        public UserComplianceSchema(DateTime eventAt, UserComplianceSchemaUser user)
        {
            EventAt = eventAt;
            User = user;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Event time.
        /// </summary>
        /// <value>Event time.</value>
        /* <example>2021-07-06T18:40:40Z</example> */
        [JsonPropertyName("event_at")]
        public DateTime EventAt { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [JsonPropertyName("user")]
        public UserComplianceSchemaUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserComplianceSchema {\n");
            sb.Append("  EventAt: ").Append(EventAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
    /// A Json converter for type <see cref="UserComplianceSchema" />
    /// </summary>
    public class UserComplianceSchemaJsonConverter : JsonConverter<UserComplianceSchema>
    {
        /// <summary>
        /// The format to use to serialize EventAt
        /// </summary>
        public static string EventAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="UserComplianceSchema" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserComplianceSchema Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> eventAt = default;
            Option<UserComplianceSchemaUser?> user = default;

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
                        case "event_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                eventAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "user":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                user = new Option<UserComplianceSchemaUser?>(JsonSerializer.Deserialize<UserComplianceSchemaUser>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!eventAt.IsSet)
                throw new ArgumentException("Property is required for class UserComplianceSchema.", nameof(eventAt));

            if (!user.IsSet)
                throw new ArgumentException("Property is required for class UserComplianceSchema.", nameof(user));

            if (eventAt.IsSet && eventAt.Value == null)
                throw new ArgumentNullException(nameof(eventAt), "Property is not nullable for class UserComplianceSchema.");

            if (user.IsSet && user.Value == null)
                throw new ArgumentNullException(nameof(user), "Property is not nullable for class UserComplianceSchema.");

            return new UserComplianceSchema(eventAt.Value!.Value!, user.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="UserComplianceSchema" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userComplianceSchema"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserComplianceSchema userComplianceSchema, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userComplianceSchema, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserComplianceSchema" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userComplianceSchema"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserComplianceSchema userComplianceSchema, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userComplianceSchema.User == null)
                throw new ArgumentNullException(nameof(userComplianceSchema.User), "Property is required for class UserComplianceSchema.");

            writer.WriteString("event_at", userComplianceSchema.EventAt.ToString(EventAtFormat));

            writer.WritePropertyName("user");
            JsonSerializer.Serialize(writer, userComplianceSchema.User, jsonSerializerOptions);
        }
    }
}

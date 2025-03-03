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
    /// UnlikeComplianceSchemaFavorite
    /// </summary>
    public partial class UnlikeComplianceSchemaFavorite : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnlikeComplianceSchemaFavorite" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of this Tweet. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</param>
        /// <param name="userId">Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</param>
        [JsonConstructor]
        public UnlikeComplianceSchemaFavorite(string id, string userId)
        {
            Id = id;
            UserId = userId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Unique identifier of this Tweet. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.
        /// </summary>
        /// <value>Unique identifier of this Tweet. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</value>
        /* <example>1346889436626259968</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.
        /// </summary>
        /// <value>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</value>
        /* <example>2244994945</example> */
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnlikeComplianceSchemaFavorite {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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

            if (this.UserId != null) {
                // UserId (string) pattern
                Regex regexUserId = new Regex(@"^[0-9]{1,19}$", RegexOptions.CultureInvariant);

                if (!regexUserId.Match(this.UserId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserId, must match a pattern of " + regexUserId, new [] { "UserId" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UnlikeComplianceSchemaFavorite" />
    /// </summary>
    public class UnlikeComplianceSchemaFavoriteJsonConverter : JsonConverter<UnlikeComplianceSchemaFavorite>
    {
        /// <summary>
        /// Deserializes json to <see cref="UnlikeComplianceSchemaFavorite" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UnlikeComplianceSchemaFavorite Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> userId = default;

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
                        case "user_id":
                            userId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class UnlikeComplianceSchemaFavorite.", nameof(id));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class UnlikeComplianceSchemaFavorite.", nameof(userId));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class UnlikeComplianceSchemaFavorite.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class UnlikeComplianceSchemaFavorite.");

            return new UnlikeComplianceSchemaFavorite(id.Value!, userId.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="UnlikeComplianceSchemaFavorite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="unlikeComplianceSchemaFavorite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UnlikeComplianceSchemaFavorite unlikeComplianceSchemaFavorite, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, unlikeComplianceSchemaFavorite, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UnlikeComplianceSchemaFavorite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="unlikeComplianceSchemaFavorite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UnlikeComplianceSchemaFavorite unlikeComplianceSchemaFavorite, JsonSerializerOptions jsonSerializerOptions)
        {
            if (unlikeComplianceSchemaFavorite.Id == null)
                throw new ArgumentNullException(nameof(unlikeComplianceSchemaFavorite.Id), "Property is required for class UnlikeComplianceSchemaFavorite.");

            if (unlikeComplianceSchemaFavorite.UserId == null)
                throw new ArgumentNullException(nameof(unlikeComplianceSchemaFavorite.UserId), "Property is required for class UnlikeComplianceSchemaFavorite.");

            writer.WriteString("id", unlikeComplianceSchemaFavorite.Id);

            writer.WriteString("user_id", unlikeComplianceSchemaFavorite.UserId);
        }
    }
}

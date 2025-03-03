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
    /// UsersFollowingDeleteResponse
    /// </summary>
    public partial class UsersFollowingDeleteResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersFollowingDeleteResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="errors">errors</param>
        [JsonConstructor]
        public UsersFollowingDeleteResponse(Option<ListFollowedResponseData?> data = default, Option<List<Problem>?> errors = default)
        {
            DataOption = data;
            ErrorsOption = errors;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ListFollowedResponseData?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public ListFollowedResponseData? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

        /// <summary>
        /// Used to track the state of Errors
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Problem>?> ErrorsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Problem>? Errors { get { return this.ErrorsOption; } set { this.ErrorsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersFollowingDeleteResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
    /// A Json converter for type <see cref="UsersFollowingDeleteResponse" />
    /// </summary>
    public class UsersFollowingDeleteResponseJsonConverter : JsonConverter<UsersFollowingDeleteResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersFollowingDeleteResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersFollowingDeleteResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ListFollowedResponseData?> data = default;
            Option<List<Problem>?> errors = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<ListFollowedResponseData?>(JsonSerializer.Deserialize<ListFollowedResponseData>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<Problem>?>(JsonSerializer.Deserialize<List<Problem>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class UsersFollowingDeleteResponse.");

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class UsersFollowingDeleteResponse.");

            return new UsersFollowingDeleteResponse(data, errors);
        }

        /// <summary>
        /// Serializes a <see cref="UsersFollowingDeleteResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersFollowingDeleteResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersFollowingDeleteResponse usersFollowingDeleteResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersFollowingDeleteResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersFollowingDeleteResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersFollowingDeleteResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersFollowingDeleteResponse usersFollowingDeleteResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersFollowingDeleteResponse.DataOption.IsSet && usersFollowingDeleteResponse.Data == null)
                throw new ArgumentNullException(nameof(usersFollowingDeleteResponse.Data), "Property is required for class UsersFollowingDeleteResponse.");

            if (usersFollowingDeleteResponse.ErrorsOption.IsSet && usersFollowingDeleteResponse.Errors == null)
                throw new ArgumentNullException(nameof(usersFollowingDeleteResponse.Errors), "Property is required for class UsersFollowingDeleteResponse.");

            if (usersFollowingDeleteResponse.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, usersFollowingDeleteResponse.Data, jsonSerializerOptions);
            }
            if (usersFollowingDeleteResponse.ErrorsOption.IsSet)
            {
                writer.WritePropertyName("errors");
                JsonSerializer.Serialize(writer, usersFollowingDeleteResponse.Errors, jsonSerializerOptions);
            }
        }
    }
}

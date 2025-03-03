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
    /// UsersRetweetsDeleteResponseData
    /// </summary>
    public partial class UsersRetweetsDeleteResponseData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRetweetsDeleteResponseData" /> class.
        /// </summary>
        /// <param name="retweeted">retweeted</param>
        [JsonConstructor]
        public UsersRetweetsDeleteResponseData(Option<bool?> retweeted = default)
        {
            RetweetedOption = retweeted;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Retweeted
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> RetweetedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Retweeted
        /// </summary>
        [JsonPropertyName("retweeted")]
        public bool? Retweeted { get { return this.RetweetedOption; } set { this.RetweetedOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersRetweetsDeleteResponseData {\n");
            sb.Append("  Retweeted: ").Append(Retweeted).Append("\n");
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
    /// A Json converter for type <see cref="UsersRetweetsDeleteResponseData" />
    /// </summary>
    public class UsersRetweetsDeleteResponseDataJsonConverter : JsonConverter<UsersRetweetsDeleteResponseData>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersRetweetsDeleteResponseData" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersRetweetsDeleteResponseData Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> retweeted = default;

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
                        case "retweeted":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                retweeted = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (retweeted.IsSet && retweeted.Value == null)
                throw new ArgumentNullException(nameof(retweeted), "Property is not nullable for class UsersRetweetsDeleteResponseData.");

            return new UsersRetweetsDeleteResponseData(retweeted);
        }

        /// <summary>
        /// Serializes a <see cref="UsersRetweetsDeleteResponseData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersRetweetsDeleteResponseData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersRetweetsDeleteResponseData usersRetweetsDeleteResponseData, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersRetweetsDeleteResponseData, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersRetweetsDeleteResponseData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersRetweetsDeleteResponseData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersRetweetsDeleteResponseData usersRetweetsDeleteResponseData, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersRetweetsDeleteResponseData.RetweetedOption.IsSet)
                writer.WriteBoolean("retweeted", usersRetweetsDeleteResponseData.RetweetedOption.Value!.Value);
        }
    }
}

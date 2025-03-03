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
    /// Your client has gone away.
    /// </summary>
    public partial class ClientDisconnectedProblem : Problem, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedProblem" /> class.
        /// </summary>
        /// <param name="title">title</param>
        /// <param name="detail">detail</param>
        /// <param name="status">status</param>
        [JsonConstructor]
        public ClientDisconnectedProblem(string title, Option<string?> detail = default, Option<int?> status = default) : base(title, detail, status)
        {
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientDisconnectedProblem {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClientDisconnectedProblem" />
    /// </summary>
    public class ClientDisconnectedProblemJsonConverter : JsonConverter<ClientDisconnectedProblem>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClientDisconnectedProblem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientDisconnectedProblem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> title = default;
            Option<string?> type = default;
            Option<string?> detail = default;
            Option<int?> status = default;

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
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "detail":
                            detail = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!title.IsSet)
                throw new ArgumentException("Property is required for class ClientDisconnectedProblem.", nameof(title));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class ClientDisconnectedProblem.", nameof(type));

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class ClientDisconnectedProblem.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class ClientDisconnectedProblem.");

            if (detail.IsSet && detail.Value == null)
                throw new ArgumentNullException(nameof(detail), "Property is not nullable for class ClientDisconnectedProblem.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class ClientDisconnectedProblem.");

            return new ClientDisconnectedProblem(title.Value!, detail, status);
        }

        /// <summary>
        /// Serializes a <see cref="ClientDisconnectedProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientDisconnectedProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientDisconnectedProblem clientDisconnectedProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, clientDisconnectedProblem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClientDisconnectedProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientDisconnectedProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ClientDisconnectedProblem clientDisconnectedProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (clientDisconnectedProblem.Title == null)
                throw new ArgumentNullException(nameof(clientDisconnectedProblem.Title), "Property is required for class ClientDisconnectedProblem.");

            if (clientDisconnectedProblem.DetailOption.IsSet && clientDisconnectedProblem.Detail == null)
                throw new ArgumentNullException(nameof(clientDisconnectedProblem.Detail), "Property is required for class ClientDisconnectedProblem.");

            writer.WriteString("title", clientDisconnectedProblem.Title);

            writer.WriteString("type", clientDisconnectedProblem.Type);

            if (clientDisconnectedProblem.DetailOption.IsSet)
                writer.WriteString("detail", clientDisconnectedProblem.Detail);

            if (clientDisconnectedProblem.StatusOption.IsSet)
                writer.WriteNumber("status", clientDisconnectedProblem.StatusOption.Value!.Value);
        }
    }
}

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
    /// You have been disconnected for operational reasons.
    /// </summary>
    public partial class OperationalDisconnectProblem : Problem, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalDisconnectProblem" /> class.
        /// </summary>
        /// <param name="title">title</param>
        /// <param name="detail">detail</param>
        /// <param name="status">status</param>
        /// <param name="disconnectType">disconnectType</param>
        [JsonConstructor]
        public OperationalDisconnectProblem(string title, Option<string?> detail = default, Option<int?> status = default, Option<DisconnectTypeEnum?> disconnectType = default) : base(title, detail, status)
        {
            DisconnectTypeOption = disconnectType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines DisconnectType
        /// </summary>
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Enum OperationalDisconnect for value: OperationalDisconnect
            /// </summary>
            OperationalDisconnect = 1,

            /// <summary>
            /// Enum UpstreamOperationalDisconnect for value: UpstreamOperationalDisconnect
            /// </summary>
            UpstreamOperationalDisconnect = 2,

            /// <summary>
            /// Enum ForceDisconnect for value: ForceDisconnect
            /// </summary>
            ForceDisconnect = 3,

            /// <summary>
            /// Enum UpstreamUncleanDisconnect for value: UpstreamUncleanDisconnect
            /// </summary>
            UpstreamUncleanDisconnect = 4,

            /// <summary>
            /// Enum SlowReader for value: SlowReader
            /// </summary>
            SlowReader = 5,

            /// <summary>
            /// Enum InternalError for value: InternalError
            /// </summary>
            InternalError = 6,

            /// <summary>
            /// Enum ClientApplicationStateDegraded for value: ClientApplicationStateDegraded
            /// </summary>
            ClientApplicationStateDegraded = 7,

            /// <summary>
            /// Enum InvalidRules for value: InvalidRules
            /// </summary>
            InvalidRules = 8
        }

        /// <summary>
        /// Returns a <see cref="DisconnectTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static DisconnectTypeEnum DisconnectTypeEnumFromString(string value)
        {
            if (value.Equals("OperationalDisconnect"))
                return DisconnectTypeEnum.OperationalDisconnect;

            if (value.Equals("UpstreamOperationalDisconnect"))
                return DisconnectTypeEnum.UpstreamOperationalDisconnect;

            if (value.Equals("ForceDisconnect"))
                return DisconnectTypeEnum.ForceDisconnect;

            if (value.Equals("UpstreamUncleanDisconnect"))
                return DisconnectTypeEnum.UpstreamUncleanDisconnect;

            if (value.Equals("SlowReader"))
                return DisconnectTypeEnum.SlowReader;

            if (value.Equals("InternalError"))
                return DisconnectTypeEnum.InternalError;

            if (value.Equals("ClientApplicationStateDegraded"))
                return DisconnectTypeEnum.ClientApplicationStateDegraded;

            if (value.Equals("InvalidRules"))
                return DisconnectTypeEnum.InvalidRules;

            throw new NotImplementedException($"Could not convert value to type DisconnectTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="DisconnectTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DisconnectTypeEnum? DisconnectTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("OperationalDisconnect"))
                return DisconnectTypeEnum.OperationalDisconnect;

            if (value.Equals("UpstreamOperationalDisconnect"))
                return DisconnectTypeEnum.UpstreamOperationalDisconnect;

            if (value.Equals("ForceDisconnect"))
                return DisconnectTypeEnum.ForceDisconnect;

            if (value.Equals("UpstreamUncleanDisconnect"))
                return DisconnectTypeEnum.UpstreamUncleanDisconnect;

            if (value.Equals("SlowReader"))
                return DisconnectTypeEnum.SlowReader;

            if (value.Equals("InternalError"))
                return DisconnectTypeEnum.InternalError;

            if (value.Equals("ClientApplicationStateDegraded"))
                return DisconnectTypeEnum.ClientApplicationStateDegraded;

            if (value.Equals("InvalidRules"))
                return DisconnectTypeEnum.InvalidRules;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="DisconnectTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string DisconnectTypeEnumToJsonValue(DisconnectTypeEnum? value)
        {
            if (value == DisconnectTypeEnum.OperationalDisconnect)
                return "OperationalDisconnect";

            if (value == DisconnectTypeEnum.UpstreamOperationalDisconnect)
                return "UpstreamOperationalDisconnect";

            if (value == DisconnectTypeEnum.ForceDisconnect)
                return "ForceDisconnect";

            if (value == DisconnectTypeEnum.UpstreamUncleanDisconnect)
                return "UpstreamUncleanDisconnect";

            if (value == DisconnectTypeEnum.SlowReader)
                return "SlowReader";

            if (value == DisconnectTypeEnum.InternalError)
                return "InternalError";

            if (value == DisconnectTypeEnum.ClientApplicationStateDegraded)
                return "ClientApplicationStateDegraded";

            if (value == DisconnectTypeEnum.InvalidRules)
                return "InvalidRules";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of DisconnectType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DisconnectTypeEnum?> DisconnectTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [JsonPropertyName("disconnect_type")]
        public DisconnectTypeEnum? DisconnectType { get { return this.DisconnectTypeOption; } set { this.DisconnectTypeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationalDisconnectProblem {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="OperationalDisconnectProblem" />
    /// </summary>
    public class OperationalDisconnectProblemJsonConverter : JsonConverter<OperationalDisconnectProblem>
    {
        /// <summary>
        /// Deserializes json to <see cref="OperationalDisconnectProblem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OperationalDisconnectProblem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> title = default;
            Option<string?> type = default;
            Option<string?> detail = default;
            Option<int?> status = default;
            Option<OperationalDisconnectProblem.DisconnectTypeEnum?> disconnectType = default;

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
                        case "disconnect_type":
                            string? disconnectTypeRawValue = utf8JsonReader.GetString();
                            if (disconnectTypeRawValue != null)
                                disconnectType = new Option<OperationalDisconnectProblem.DisconnectTypeEnum?>(OperationalDisconnectProblem.DisconnectTypeEnumFromStringOrDefault(disconnectTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!title.IsSet)
                throw new ArgumentException("Property is required for class OperationalDisconnectProblem.", nameof(title));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class OperationalDisconnectProblem.", nameof(type));

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class OperationalDisconnectProblem.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class OperationalDisconnectProblem.");

            if (detail.IsSet && detail.Value == null)
                throw new ArgumentNullException(nameof(detail), "Property is not nullable for class OperationalDisconnectProblem.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class OperationalDisconnectProblem.");

            if (disconnectType.IsSet && disconnectType.Value == null)
                throw new ArgumentNullException(nameof(disconnectType), "Property is not nullable for class OperationalDisconnectProblem.");

            return new OperationalDisconnectProblem(title.Value!, detail, status, disconnectType);
        }

        /// <summary>
        /// Serializes a <see cref="OperationalDisconnectProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationalDisconnectProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OperationalDisconnectProblem operationalDisconnectProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, operationalDisconnectProblem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OperationalDisconnectProblem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="operationalDisconnectProblem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, OperationalDisconnectProblem operationalDisconnectProblem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (operationalDisconnectProblem.Title == null)
                throw new ArgumentNullException(nameof(operationalDisconnectProblem.Title), "Property is required for class OperationalDisconnectProblem.");

            if (operationalDisconnectProblem.DetailOption.IsSet && operationalDisconnectProblem.Detail == null)
                throw new ArgumentNullException(nameof(operationalDisconnectProblem.Detail), "Property is required for class OperationalDisconnectProblem.");

            writer.WriteString("title", operationalDisconnectProblem.Title);

            writer.WriteString("type", operationalDisconnectProblem.Type);

            if (operationalDisconnectProblem.DetailOption.IsSet)
                writer.WriteString("detail", operationalDisconnectProblem.Detail);

            if (operationalDisconnectProblem.StatusOption.IsSet)
                writer.WriteNumber("status", operationalDisconnectProblem.StatusOption.Value!.Value);

            var disconnectTypeRawValue = OperationalDisconnectProblem.DisconnectTypeEnumToJsonValue(operationalDisconnectProblem.DisconnectTypeOption.Value!.Value);
            writer.WriteString("disconnect_type", disconnectTypeRawValue);
        }
    }
}

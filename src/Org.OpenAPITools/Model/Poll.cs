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
    /// Represent a Poll attached to a Tweet.
    /// </summary>
    public partial class Poll : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of this poll.</param>
        /// <param name="options">options</param>
        /// <param name="durationMinutes">durationMinutes</param>
        /// <param name="endDatetime">endDatetime</param>
        /// <param name="votingStatus">votingStatus</param>
        [JsonConstructor]
        public Poll(string id, List<PollOption> options, Option<int?> durationMinutes = default, Option<DateTime?> endDatetime = default, Option<VotingStatusEnum?> votingStatus = default)
        {
            Id = id;
            Options = options;
            DurationMinutesOption = durationMinutes;
            EndDatetimeOption = endDatetime;
            VotingStatusOption = votingStatus;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines VotingStatus
        /// </summary>
        public enum VotingStatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            Closed = 2
        }

        /// <summary>
        /// Returns a <see cref="VotingStatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static VotingStatusEnum VotingStatusEnumFromString(string value)
        {
            if (value.Equals("open"))
                return VotingStatusEnum.Open;

            if (value.Equals("closed"))
                return VotingStatusEnum.Closed;

            throw new NotImplementedException($"Could not convert value to type VotingStatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="VotingStatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VotingStatusEnum? VotingStatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("open"))
                return VotingStatusEnum.Open;

            if (value.Equals("closed"))
                return VotingStatusEnum.Closed;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="VotingStatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string VotingStatusEnumToJsonValue(VotingStatusEnum? value)
        {
            if (value == VotingStatusEnum.Open)
                return "open";

            if (value == VotingStatusEnum.Closed)
                return "closed";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of VotingStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<VotingStatusEnum?> VotingStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets VotingStatus
        /// </summary>
        [JsonPropertyName("voting_status")]
        public VotingStatusEnum? VotingStatus { get { return this.VotingStatusOption; } set { this.VotingStatusOption = new(value); } }

        /// <summary>
        /// Unique identifier of this poll.
        /// </summary>
        /// <value>Unique identifier of this poll.</value>
        /* <example>1365059861688410112</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [JsonPropertyName("options")]
        public List<PollOption> Options { get; set; }

        /// <summary>
        /// Used to track the state of DurationMinutes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DurationMinutesOption { get; private set; }

        /// <summary>
        /// Gets or Sets DurationMinutes
        /// </summary>
        [JsonPropertyName("duration_minutes")]
        public int? DurationMinutes { get { return this.DurationMinutesOption; } set { this.DurationMinutesOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndDatetime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> EndDatetimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndDatetime
        /// </summary>
        [JsonPropertyName("end_datetime")]
        public DateTime? EndDatetime { get { return this.EndDatetimeOption; } set { this.EndDatetimeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Poll {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
            sb.Append("  EndDatetime: ").Append(EndDatetime).Append("\n");
            sb.Append("  VotingStatus: ").Append(VotingStatus).Append("\n");
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

            // DurationMinutes (int) maximum
            if (this.DurationMinutesOption.IsSet && this.DurationMinutesOption.Value > (int)10080)
            {
                yield return new ValidationResult("Invalid value for DurationMinutes, must be a value less than or equal to 10080.", new [] { "DurationMinutes" });
            }

            // DurationMinutes (int) minimum
            if (this.DurationMinutesOption.IsSet && this.DurationMinutesOption.Value < (int)5)
            {
                yield return new ValidationResult("Invalid value for DurationMinutes, must be a value greater than or equal to 5.", new [] { "DurationMinutes" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Poll" />
    /// </summary>
    public class PollJsonConverter : JsonConverter<Poll>
    {
        /// <summary>
        /// The format to use to serialize EndDatetime
        /// </summary>
        public static string EndDatetimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Poll" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Poll Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<List<PollOption>?> options = default;
            Option<int?> durationMinutes = default;
            Option<DateTime?> endDatetime = default;
            Option<Poll.VotingStatusEnum?> votingStatus = default;

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
                        case "options":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                options = new Option<List<PollOption>?>(JsonSerializer.Deserialize<List<PollOption>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "duration_minutes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                durationMinutes = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "end_datetime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDatetime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "voting_status":
                            string? votingStatusRawValue = utf8JsonReader.GetString();
                            if (votingStatusRawValue != null)
                                votingStatus = new Option<Poll.VotingStatusEnum?>(Poll.VotingStatusEnumFromStringOrDefault(votingStatusRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Poll.", nameof(id));

            if (!options.IsSet)
                throw new ArgumentException("Property is required for class Poll.", nameof(options));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Poll.");

            if (options.IsSet && options.Value == null)
                throw new ArgumentNullException(nameof(options), "Property is not nullable for class Poll.");

            if (durationMinutes.IsSet && durationMinutes.Value == null)
                throw new ArgumentNullException(nameof(durationMinutes), "Property is not nullable for class Poll.");

            if (endDatetime.IsSet && endDatetime.Value == null)
                throw new ArgumentNullException(nameof(endDatetime), "Property is not nullable for class Poll.");

            if (votingStatus.IsSet && votingStatus.Value == null)
                throw new ArgumentNullException(nameof(votingStatus), "Property is not nullable for class Poll.");

            return new Poll(id.Value!, options.Value!, durationMinutes, endDatetime, votingStatus);
        }

        /// <summary>
        /// Serializes a <see cref="Poll" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="poll"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Poll poll, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, poll, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Poll" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="poll"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Poll poll, JsonSerializerOptions jsonSerializerOptions)
        {
            if (poll.Id == null)
                throw new ArgumentNullException(nameof(poll.Id), "Property is required for class Poll.");

            if (poll.Options == null)
                throw new ArgumentNullException(nameof(poll.Options), "Property is required for class Poll.");

            writer.WriteString("id", poll.Id);

            writer.WritePropertyName("options");
            JsonSerializer.Serialize(writer, poll.Options, jsonSerializerOptions);
            if (poll.DurationMinutesOption.IsSet)
                writer.WriteNumber("duration_minutes", poll.DurationMinutesOption.Value!.Value);

            if (poll.EndDatetimeOption.IsSet)
                writer.WriteString("end_datetime", poll.EndDatetimeOption.Value!.Value.ToString(EndDatetimeFormat));

            var votingStatusRawValue = Poll.VotingStatusEnumToJsonValue(poll.VotingStatusOption.Value!.Value);
            writer.WriteString("voting_status", votingStatusRawValue);
        }
    }
}

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
    /// Space
    /// </summary>
    public partial class Space : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of this Space.</param>
        /// <param name="state">The current state of the Space.</param>
        /// <param name="createdAt">Creation time of the Space.</param>
        /// <param name="creatorId">Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</param>
        /// <param name="endedAt">End time of the Space.</param>
        /// <param name="hostIds">The user ids for the hosts of the Space.</param>
        /// <param name="invitedUserIds">An array of user ids for people who were invited to a Space.</param>
        /// <param name="isTicketed">Denotes if the Space is a ticketed Space.</param>
        /// <param name="lang">The language of the Space.</param>
        /// <param name="participantCount">The number of participants in a Space.</param>
        /// <param name="scheduledStart">A date time stamp for when a Space is scheduled to begin.</param>
        /// <param name="speakerIds">An array of user ids for people who were speakers in a Space.</param>
        /// <param name="startedAt">When the Space was started as a date string.</param>
        /// <param name="subscriberCount">The number of people who have either purchased a ticket or set a reminder for this Space.</param>
        /// <param name="title">The title of the Space.</param>
        /// <param name="topics">The topics of a Space, as selected by its creator.</param>
        /// <param name="updatedAt">When the Space was last updated.</param>
        [JsonConstructor]
        public Space(string id, StateEnum state, Option<DateTime?> createdAt = default, Option<string?> creatorId = default, Option<DateTime?> endedAt = default, Option<List<string>?> hostIds = default, Option<List<string>?> invitedUserIds = default, Option<bool?> isTicketed = default, Option<string?> lang = default, Option<int?> participantCount = default, Option<DateTime?> scheduledStart = default, Option<List<string>?> speakerIds = default, Option<DateTime?> startedAt = default, Option<int?> subscriberCount = default, Option<string?> title = default, Option<List<SpaceTopicsInner>?> topics = default, Option<DateTime?> updatedAt = default)
        {
            Id = id;
            State = state;
            CreatedAtOption = createdAt;
            CreatorIdOption = creatorId;
            EndedAtOption = endedAt;
            HostIdsOption = hostIds;
            InvitedUserIdsOption = invitedUserIds;
            IsTicketedOption = isTicketed;
            LangOption = lang;
            ParticipantCountOption = participantCount;
            ScheduledStartOption = scheduledStart;
            SpeakerIdsOption = speakerIds;
            StartedAtOption = startedAt;
            SubscriberCountOption = subscriberCount;
            TitleOption = title;
            TopicsOption = topics;
            UpdatedAtOption = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The current state of the Space.
        /// </summary>
        /// <value>The current state of the Space.</value>
        public enum StateEnum
        {
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            Live = 1,

            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            Scheduled = 2,

            /// <summary>
            /// Enum Ended for value: ended
            /// </summary>
            Ended = 3
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StateEnum StateEnumFromString(string value)
        {
            if (value.Equals("live"))
                return StateEnum.Live;

            if (value.Equals("scheduled"))
                return StateEnum.Scheduled;

            if (value.Equals("ended"))
                return StateEnum.Ended;

            throw new NotImplementedException($"Could not convert value to type StateEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StateEnum? StateEnumFromStringOrDefault(string value)
        {
            if (value.Equals("live"))
                return StateEnum.Live;

            if (value.Equals("scheduled"))
                return StateEnum.Scheduled;

            if (value.Equals("ended"))
                return StateEnum.Ended;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StateEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StateEnumToJsonValue(StateEnum value)
        {
            if (value == StateEnum.Live)
                return "live";

            if (value == StateEnum.Scheduled)
                return "scheduled";

            if (value == StateEnum.Ended)
                return "ended";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The current state of the Space.
        /// </summary>
        /// <value>The current state of the Space.</value>
        /* <example>live</example> */
        [JsonPropertyName("state")]
        public StateEnum State { get; set; }

        /// <summary>
        /// The unique identifier of this Space.
        /// </summary>
        /// <value>The unique identifier of this Space.</value>
        /* <example>1SLjjRYNejbKM</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedAtOption { get; private set; }

        /// <summary>
        /// Creation time of the Space.
        /// </summary>
        /// <value>Creation time of the Space.</value>
        /* <example>2021-07-06T18:40:40Z</example> */
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatorId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CreatorIdOption { get; private set; }

        /// <summary>
        /// Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.
        /// </summary>
        /// <value>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</value>
        /* <example>2244994945</example> */
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get { return this.CreatorIdOption; } set { this.CreatorIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> EndedAtOption { get; private set; }

        /// <summary>
        /// End time of the Space.
        /// </summary>
        /// <value>End time of the Space.</value>
        /* <example>2021-07-06T18:40:40Z</example> */
        [JsonPropertyName("ended_at")]
        public DateTime? EndedAt { get { return this.EndedAtOption; } set { this.EndedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of HostIds
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> HostIdsOption { get; private set; }

        /// <summary>
        /// The user ids for the hosts of the Space.
        /// </summary>
        /// <value>The user ids for the hosts of the Space.</value>
        [JsonPropertyName("host_ids")]
        public List<string>? HostIds { get { return this.HostIdsOption; } set { this.HostIdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of InvitedUserIds
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> InvitedUserIdsOption { get; private set; }

        /// <summary>
        /// An array of user ids for people who were invited to a Space.
        /// </summary>
        /// <value>An array of user ids for people who were invited to a Space.</value>
        [JsonPropertyName("invited_user_ids")]
        public List<string>? InvitedUserIds { get { return this.InvitedUserIdsOption; } set { this.InvitedUserIdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsTicketed
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsTicketedOption { get; private set; }

        /// <summary>
        /// Denotes if the Space is a ticketed Space.
        /// </summary>
        /// <value>Denotes if the Space is a ticketed Space.</value>
        /* <example>false</example> */
        [JsonPropertyName("is_ticketed")]
        public bool? IsTicketed { get { return this.IsTicketedOption; } set { this.IsTicketedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Lang
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LangOption { get; private set; }

        /// <summary>
        /// The language of the Space.
        /// </summary>
        /// <value>The language of the Space.</value>
        /* <example>en</example> */
        [JsonPropertyName("lang")]
        public string? Lang { get { return this.LangOption; } set { this.LangOption = new(value); } }

        /// <summary>
        /// Used to track the state of ParticipantCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ParticipantCountOption { get; private set; }

        /// <summary>
        /// The number of participants in a Space.
        /// </summary>
        /// <value>The number of participants in a Space.</value>
        /* <example>10</example> */
        [JsonPropertyName("participant_count")]
        public int? ParticipantCount { get { return this.ParticipantCountOption; } set { this.ParticipantCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of ScheduledStart
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ScheduledStartOption { get; private set; }

        /// <summary>
        /// A date time stamp for when a Space is scheduled to begin.
        /// </summary>
        /// <value>A date time stamp for when a Space is scheduled to begin.</value>
        /* <example>2021-07-06T18:40:40Z</example> */
        [JsonPropertyName("scheduled_start")]
        public DateTime? ScheduledStart { get { return this.ScheduledStartOption; } set { this.ScheduledStartOption = new(value); } }

        /// <summary>
        /// Used to track the state of SpeakerIds
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> SpeakerIdsOption { get; private set; }

        /// <summary>
        /// An array of user ids for people who were speakers in a Space.
        /// </summary>
        /// <value>An array of user ids for people who were speakers in a Space.</value>
        [JsonPropertyName("speaker_ids")]
        public List<string>? SpeakerIds { get { return this.SpeakerIdsOption; } set { this.SpeakerIdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of StartedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> StartedAtOption { get; private set; }

        /// <summary>
        /// When the Space was started as a date string.
        /// </summary>
        /// <value>When the Space was started as a date string.</value>
        [JsonPropertyName("started_at")]
        public DateTime? StartedAt { get { return this.StartedAtOption; } set { this.StartedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of SubscriberCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SubscriberCountOption { get; private set; }

        /// <summary>
        /// The number of people who have either purchased a ticket or set a reminder for this Space.
        /// </summary>
        /// <value>The number of people who have either purchased a ticket or set a reminder for this Space.</value>
        /* <example>10</example> */
        [JsonPropertyName("subscriber_count")]
        public int? SubscriberCount { get { return this.SubscriberCountOption; } set { this.SubscriberCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TitleOption { get; private set; }

        /// <summary>
        /// The title of the Space.
        /// </summary>
        /// <value>The title of the Space.</value>
        /* <example>Spaces are Awesome</example> */
        [JsonPropertyName("title")]
        public string? Title { get { return this.TitleOption; } set { this.TitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Topics
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<SpaceTopicsInner>?> TopicsOption { get; private set; }

        /// <summary>
        /// The topics of a Space, as selected by its creator.
        /// </summary>
        /// <value>The topics of a Space, as selected by its creator.</value>
        [JsonPropertyName("topics")]
        public List<SpaceTopicsInner>? Topics { get { return this.TopicsOption; } set { this.TopicsOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UpdatedAtOption { get; private set; }

        /// <summary>
        /// When the Space was last updated.
        /// </summary>
        /// <value>When the Space was last updated.</value>
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get { return this.UpdatedAtOption; } set { this.UpdatedAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Space {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  EndedAt: ").Append(EndedAt).Append("\n");
            sb.Append("  HostIds: ").Append(HostIds).Append("\n");
            sb.Append("  InvitedUserIds: ").Append(InvitedUserIds).Append("\n");
            sb.Append("  IsTicketed: ").Append(IsTicketed).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
            sb.Append("  ScheduledStart: ").Append(ScheduledStart).Append("\n");
            sb.Append("  SpeakerIds: ").Append(SpeakerIds).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  SubscriberCount: ").Append(SubscriberCount).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
                Regex regexId = new Regex(@"^[a-zA-Z0-9]{1,13}$", RegexOptions.CultureInvariant);

                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            if (this.CreatorIdOption.Value != null) {
                // CreatorId (string) pattern
                Regex regexCreatorId = new Regex(@"^[0-9]{1,19}$", RegexOptions.CultureInvariant);

                if (this.CreatorIdOption.Value != null &&!regexCreatorId.Match(this.CreatorIdOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatorId, must match a pattern of " + regexCreatorId, new [] { "CreatorId" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Space" />
    /// </summary>
    public class SpaceJsonConverter : JsonConverter<Space>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize EndedAt
        /// </summary>
        public static string EndedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize ScheduledStart
        /// </summary>
        public static string ScheduledStartFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartedAt
        /// </summary>
        public static string StartedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Space" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Space Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<Space.StateEnum?> state = default;
            Option<DateTime?> createdAt = default;
            Option<string?> creatorId = default;
            Option<DateTime?> endedAt = default;
            Option<List<string>?> hostIds = default;
            Option<List<string>?> invitedUserIds = default;
            Option<bool?> isTicketed = default;
            Option<string?> lang = default;
            Option<int?> participantCount = default;
            Option<DateTime?> scheduledStart = default;
            Option<List<string>?> speakerIds = default;
            Option<DateTime?> startedAt = default;
            Option<int?> subscriberCount = default;
            Option<string?> title = default;
            Option<List<SpaceTopicsInner>?> topics = default;
            Option<DateTime?> updatedAt = default;

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
                        case "state":
                            string? stateRawValue = utf8JsonReader.GetString();
                            if (stateRawValue != null)
                                state = new Option<Space.StateEnum?>(Space.StateEnumFromStringOrDefault(stateRawValue));
                            break;
                        case "created_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "creator_id":
                            creatorId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "ended_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "host_ids":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hostIds = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "invited_user_ids":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                invitedUserIds = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "is_ticketed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isTicketed = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "lang":
                            lang = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "participant_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                participantCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "scheduled_start":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                scheduledStart = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "speaker_ids":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                speakerIds = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "started_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "subscriber_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                subscriberCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "topics":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                topics = new Option<List<SpaceTopicsInner>?>(JsonSerializer.Deserialize<List<SpaceTopicsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updated_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Space.", nameof(id));

            if (!state.IsSet)
                throw new ArgumentException("Property is required for class Space.", nameof(state));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Space.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class Space.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class Space.");

            if (creatorId.IsSet && creatorId.Value == null)
                throw new ArgumentNullException(nameof(creatorId), "Property is not nullable for class Space.");

            if (endedAt.IsSet && endedAt.Value == null)
                throw new ArgumentNullException(nameof(endedAt), "Property is not nullable for class Space.");

            if (hostIds.IsSet && hostIds.Value == null)
                throw new ArgumentNullException(nameof(hostIds), "Property is not nullable for class Space.");

            if (invitedUserIds.IsSet && invitedUserIds.Value == null)
                throw new ArgumentNullException(nameof(invitedUserIds), "Property is not nullable for class Space.");

            if (isTicketed.IsSet && isTicketed.Value == null)
                throw new ArgumentNullException(nameof(isTicketed), "Property is not nullable for class Space.");

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang), "Property is not nullable for class Space.");

            if (participantCount.IsSet && participantCount.Value == null)
                throw new ArgumentNullException(nameof(participantCount), "Property is not nullable for class Space.");

            if (scheduledStart.IsSet && scheduledStart.Value == null)
                throw new ArgumentNullException(nameof(scheduledStart), "Property is not nullable for class Space.");

            if (speakerIds.IsSet && speakerIds.Value == null)
                throw new ArgumentNullException(nameof(speakerIds), "Property is not nullable for class Space.");

            if (startedAt.IsSet && startedAt.Value == null)
                throw new ArgumentNullException(nameof(startedAt), "Property is not nullable for class Space.");

            if (subscriberCount.IsSet && subscriberCount.Value == null)
                throw new ArgumentNullException(nameof(subscriberCount), "Property is not nullable for class Space.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class Space.");

            if (topics.IsSet && topics.Value == null)
                throw new ArgumentNullException(nameof(topics), "Property is not nullable for class Space.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class Space.");

            return new Space(id.Value!, state.Value!.Value!, createdAt, creatorId, endedAt, hostIds, invitedUserIds, isTicketed, lang, participantCount, scheduledStart, speakerIds, startedAt, subscriberCount, title, topics, updatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="Space" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="space"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Space space, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, space, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Space" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="space"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Space space, JsonSerializerOptions jsonSerializerOptions)
        {
            if (space.Id == null)
                throw new ArgumentNullException(nameof(space.Id), "Property is required for class Space.");

            if (space.CreatorIdOption.IsSet && space.CreatorId == null)
                throw new ArgumentNullException(nameof(space.CreatorId), "Property is required for class Space.");

            if (space.HostIdsOption.IsSet && space.HostIds == null)
                throw new ArgumentNullException(nameof(space.HostIds), "Property is required for class Space.");

            if (space.InvitedUserIdsOption.IsSet && space.InvitedUserIds == null)
                throw new ArgumentNullException(nameof(space.InvitedUserIds), "Property is required for class Space.");

            if (space.LangOption.IsSet && space.Lang == null)
                throw new ArgumentNullException(nameof(space.Lang), "Property is required for class Space.");

            if (space.SpeakerIdsOption.IsSet && space.SpeakerIds == null)
                throw new ArgumentNullException(nameof(space.SpeakerIds), "Property is required for class Space.");

            if (space.TitleOption.IsSet && space.Title == null)
                throw new ArgumentNullException(nameof(space.Title), "Property is required for class Space.");

            if (space.TopicsOption.IsSet && space.Topics == null)
                throw new ArgumentNullException(nameof(space.Topics), "Property is required for class Space.");

            writer.WriteString("id", space.Id);

            var stateRawValue = Space.StateEnumToJsonValue(space.State);
            writer.WriteString("state", stateRawValue);
            if (space.CreatedAtOption.IsSet)
                writer.WriteString("created_at", space.CreatedAtOption.Value!.Value.ToString(CreatedAtFormat));

            if (space.CreatorIdOption.IsSet)
                writer.WriteString("creator_id", space.CreatorId);

            if (space.EndedAtOption.IsSet)
                writer.WriteString("ended_at", space.EndedAtOption.Value!.Value.ToString(EndedAtFormat));

            if (space.HostIdsOption.IsSet)
            {
                writer.WritePropertyName("host_ids");
                JsonSerializer.Serialize(writer, space.HostIds, jsonSerializerOptions);
            }
            if (space.InvitedUserIdsOption.IsSet)
            {
                writer.WritePropertyName("invited_user_ids");
                JsonSerializer.Serialize(writer, space.InvitedUserIds, jsonSerializerOptions);
            }
            if (space.IsTicketedOption.IsSet)
                writer.WriteBoolean("is_ticketed", space.IsTicketedOption.Value!.Value);

            if (space.LangOption.IsSet)
                writer.WriteString("lang", space.Lang);

            if (space.ParticipantCountOption.IsSet)
                writer.WriteNumber("participant_count", space.ParticipantCountOption.Value!.Value);

            if (space.ScheduledStartOption.IsSet)
                writer.WriteString("scheduled_start", space.ScheduledStartOption.Value!.Value.ToString(ScheduledStartFormat));

            if (space.SpeakerIdsOption.IsSet)
            {
                writer.WritePropertyName("speaker_ids");
                JsonSerializer.Serialize(writer, space.SpeakerIds, jsonSerializerOptions);
            }
            if (space.StartedAtOption.IsSet)
                writer.WriteString("started_at", space.StartedAtOption.Value!.Value.ToString(StartedAtFormat));

            if (space.SubscriberCountOption.IsSet)
                writer.WriteNumber("subscriber_count", space.SubscriberCountOption.Value!.Value);

            if (space.TitleOption.IsSet)
                writer.WriteString("title", space.Title);

            if (space.TopicsOption.IsSet)
            {
                writer.WritePropertyName("topics");
                JsonSerializer.Serialize(writer, space.Topics, jsonSerializerOptions);
            }
            if (space.UpdatedAtOption.IsSet)
                writer.WriteString("updated_at", space.UpdatedAtOption.Value!.Value.ToString(UpdatedAtFormat));
        }
    }
}

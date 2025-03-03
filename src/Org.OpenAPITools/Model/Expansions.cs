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
    /// Expansions
    /// </summary>
    public partial class Expansions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expansions" /> class.
        /// </summary>
        /// <param name="media">media</param>
        /// <param name="places">places</param>
        /// <param name="polls">polls</param>
        /// <param name="topics">topics</param>
        /// <param name="tweets">tweets</param>
        /// <param name="users">users</param>
        [JsonConstructor]
        public Expansions(Option<List<Media>?> media = default, Option<List<Place>?> places = default, Option<List<Poll>?> polls = default, Option<List<Topic>?> topics = default, Option<List<Tweet>?> tweets = default, Option<List<User>?> users = default)
        {
            MediaOption = media;
            PlacesOption = places;
            PollsOption = polls;
            TopicsOption = topics;
            TweetsOption = tweets;
            UsersOption = users;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Media
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Media>?> MediaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media>? Media { get { return this.MediaOption; } set { this.MediaOption = new(value); } }

        /// <summary>
        /// Used to track the state of Places
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Place>?> PlacesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Places
        /// </summary>
        [JsonPropertyName("places")]
        public List<Place>? Places { get { return this.PlacesOption; } set { this.PlacesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Polls
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Poll>?> PollsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Polls
        /// </summary>
        [JsonPropertyName("polls")]
        public List<Poll>? Polls { get { return this.PollsOption; } set { this.PollsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Topics
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Topic>?> TopicsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [JsonPropertyName("topics")]
        public List<Topic>? Topics { get { return this.TopicsOption; } set { this.TopicsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tweets
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Tweet>?> TweetsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tweets
        /// </summary>
        [JsonPropertyName("tweets")]
        public List<Tweet>? Tweets { get { return this.TweetsOption; } set { this.TweetsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Users
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<User>?> UsersOption { get; private set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [JsonPropertyName("users")]
        public List<User>? Users { get { return this.UsersOption; } set { this.UsersOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Expansions {\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Places: ").Append(Places).Append("\n");
            sb.Append("  Polls: ").Append(Polls).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Tweets: ").Append(Tweets).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
    /// A Json converter for type <see cref="Expansions" />
    /// </summary>
    public class ExpansionsJsonConverter : JsonConverter<Expansions>
    {
        /// <summary>
        /// Deserializes json to <see cref="Expansions" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Expansions Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Media>?> media = default;
            Option<List<Place>?> places = default;
            Option<List<Poll>?> polls = default;
            Option<List<Topic>?> topics = default;
            Option<List<Tweet>?> tweets = default;
            Option<List<User>?> users = default;

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
                        case "media":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                media = new Option<List<Media>?>(JsonSerializer.Deserialize<List<Media>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "places":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                places = new Option<List<Place>?>(JsonSerializer.Deserialize<List<Place>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "polls":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                polls = new Option<List<Poll>?>(JsonSerializer.Deserialize<List<Poll>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "topics":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                topics = new Option<List<Topic>?>(JsonSerializer.Deserialize<List<Topic>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "tweets":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tweets = new Option<List<Tweet>?>(JsonSerializer.Deserialize<List<Tweet>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "users":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                users = new Option<List<User>?>(JsonSerializer.Deserialize<List<User>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (media.IsSet && media.Value == null)
                throw new ArgumentNullException(nameof(media), "Property is not nullable for class Expansions.");

            if (places.IsSet && places.Value == null)
                throw new ArgumentNullException(nameof(places), "Property is not nullable for class Expansions.");

            if (polls.IsSet && polls.Value == null)
                throw new ArgumentNullException(nameof(polls), "Property is not nullable for class Expansions.");

            if (topics.IsSet && topics.Value == null)
                throw new ArgumentNullException(nameof(topics), "Property is not nullable for class Expansions.");

            if (tweets.IsSet && tweets.Value == null)
                throw new ArgumentNullException(nameof(tweets), "Property is not nullable for class Expansions.");

            if (users.IsSet && users.Value == null)
                throw new ArgumentNullException(nameof(users), "Property is not nullable for class Expansions.");

            return new Expansions(media, places, polls, topics, tweets, users);
        }

        /// <summary>
        /// Serializes a <see cref="Expansions" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="expansions"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Expansions expansions, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, expansions, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Expansions" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="expansions"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Expansions expansions, JsonSerializerOptions jsonSerializerOptions)
        {
            if (expansions.MediaOption.IsSet && expansions.Media == null)
                throw new ArgumentNullException(nameof(expansions.Media), "Property is required for class Expansions.");

            if (expansions.PlacesOption.IsSet && expansions.Places == null)
                throw new ArgumentNullException(nameof(expansions.Places), "Property is required for class Expansions.");

            if (expansions.PollsOption.IsSet && expansions.Polls == null)
                throw new ArgumentNullException(nameof(expansions.Polls), "Property is required for class Expansions.");

            if (expansions.TopicsOption.IsSet && expansions.Topics == null)
                throw new ArgumentNullException(nameof(expansions.Topics), "Property is required for class Expansions.");

            if (expansions.TweetsOption.IsSet && expansions.Tweets == null)
                throw new ArgumentNullException(nameof(expansions.Tweets), "Property is required for class Expansions.");

            if (expansions.UsersOption.IsSet && expansions.Users == null)
                throw new ArgumentNullException(nameof(expansions.Users), "Property is required for class Expansions.");

            if (expansions.MediaOption.IsSet)
            {
                writer.WritePropertyName("media");
                JsonSerializer.Serialize(writer, expansions.Media, jsonSerializerOptions);
            }
            if (expansions.PlacesOption.IsSet)
            {
                writer.WritePropertyName("places");
                JsonSerializer.Serialize(writer, expansions.Places, jsonSerializerOptions);
            }
            if (expansions.PollsOption.IsSet)
            {
                writer.WritePropertyName("polls");
                JsonSerializer.Serialize(writer, expansions.Polls, jsonSerializerOptions);
            }
            if (expansions.TopicsOption.IsSet)
            {
                writer.WritePropertyName("topics");
                JsonSerializer.Serialize(writer, expansions.Topics, jsonSerializerOptions);
            }
            if (expansions.TweetsOption.IsSet)
            {
                writer.WritePropertyName("tweets");
                JsonSerializer.Serialize(writer, expansions.Tweets, jsonSerializerOptions);
            }
            if (expansions.UsersOption.IsSet)
            {
                writer.WritePropertyName("users");
                JsonSerializer.Serialize(writer, expansions.Users, jsonSerializerOptions);
            }
        }
    }
}

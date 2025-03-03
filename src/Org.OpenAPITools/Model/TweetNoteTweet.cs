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
    /// The full-content of the Tweet, including text beyond 280 characters.
    /// </summary>
    public partial class TweetNoteTweet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetNoteTweet" /> class.
        /// </summary>
        /// <param name="entities">entities</param>
        /// <param name="text">The note content of the Tweet.</param>
        [JsonConstructor]
        public TweetNoteTweet(Option<TweetNoteTweetEntities?> entities = default, Option<string?> text = default)
        {
            EntitiesOption = entities;
            TextOption = text;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Entities
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TweetNoteTweetEntities?> EntitiesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [JsonPropertyName("entities")]
        public TweetNoteTweetEntities? Entities { get { return this.EntitiesOption; } set { this.EntitiesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Text
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TextOption { get; private set; }

        /// <summary>
        /// The note content of the Tweet.
        /// </summary>
        /// <value>The note content of the Tweet.</value>
        /* <example>Learn how to use the user Tweet timeline and user mention timeline endpoints in the X API v2 to explore Tweet\u2026 https:\/\/t.co\/56a0vZUx7i</example> */
        [JsonPropertyName("text")]
        public string? Text { get { return this.TextOption; } set { this.TextOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TweetNoteTweet {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
    /// A Json converter for type <see cref="TweetNoteTweet" />
    /// </summary>
    public class TweetNoteTweetJsonConverter : JsonConverter<TweetNoteTweet>
    {
        /// <summary>
        /// Deserializes json to <see cref="TweetNoteTweet" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TweetNoteTweet Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<TweetNoteTweetEntities?> entities = default;
            Option<string?> text = default;

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
                        case "entities":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                entities = new Option<TweetNoteTweetEntities?>(JsonSerializer.Deserialize<TweetNoteTweetEntities>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "text":
                            text = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (entities.IsSet && entities.Value == null)
                throw new ArgumentNullException(nameof(entities), "Property is not nullable for class TweetNoteTweet.");

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class TweetNoteTweet.");

            return new TweetNoteTweet(entities, text);
        }

        /// <summary>
        /// Serializes a <see cref="TweetNoteTweet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetNoteTweet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TweetNoteTweet tweetNoteTweet, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tweetNoteTweet, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TweetNoteTweet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetNoteTweet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TweetNoteTweet tweetNoteTweet, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tweetNoteTweet.EntitiesOption.IsSet && tweetNoteTweet.Entities == null)
                throw new ArgumentNullException(nameof(tweetNoteTweet.Entities), "Property is required for class TweetNoteTweet.");

            if (tweetNoteTweet.TextOption.IsSet && tweetNoteTweet.Text == null)
                throw new ArgumentNullException(nameof(tweetNoteTweet.Text), "Property is required for class TweetNoteTweet.");

            if (tweetNoteTweet.EntitiesOption.IsSet)
            {
                writer.WritePropertyName("entities");
                JsonSerializer.Serialize(writer, tweetNoteTweet.Entities, jsonSerializerOptions);
            }
            if (tweetNoteTweet.TextOption.IsSet)
                writer.WriteString("text", tweetNoteTweet.Text);
        }
    }
}

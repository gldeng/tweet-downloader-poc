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
    /// Tweet compliance stream events.
    /// </summary>
    public partial class TweetComplianceStreamResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetComplianceStreamResponse" /> class.
        /// </summary>
        /// <param name="tweetComplianceStreamResponseOneOf"></param>
        public TweetComplianceStreamResponse(TweetComplianceStreamResponseOneOf tweetComplianceStreamResponseOneOf)
        {
            TweetComplianceStreamResponseOneOf = tweetComplianceStreamResponseOneOf;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TweetComplianceStreamResponse" /> class.
        /// </summary>
        /// <param name="likesComplianceStreamResponseOneOf1"></param>
        public TweetComplianceStreamResponse(LikesComplianceStreamResponseOneOf1 likesComplianceStreamResponseOneOf1)
        {
            LikesComplianceStreamResponseOneOf1 = likesComplianceStreamResponseOneOf1;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets TweetComplianceStreamResponseOneOf
        /// </summary>
        public TweetComplianceStreamResponseOneOf? TweetComplianceStreamResponseOneOf { get; set; }

        /// <summary>
        /// Gets or Sets LikesComplianceStreamResponseOneOf1
        /// </summary>
        public LikesComplianceStreamResponseOneOf1? LikesComplianceStreamResponseOneOf1 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TweetComplianceStreamResponse {\n");
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
    /// A Json converter for type <see cref="TweetComplianceStreamResponse" />
    /// </summary>
    public class TweetComplianceStreamResponseJsonConverter : JsonConverter<TweetComplianceStreamResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="TweetComplianceStreamResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TweetComplianceStreamResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            TweetComplianceStreamResponseOneOf? tweetComplianceStreamResponseOneOf = default;
            LikesComplianceStreamResponseOneOf1? likesComplianceStreamResponseOneOf1 = default;

            Utf8JsonReader utf8JsonReaderOneOf = utf8JsonReader;
            while (utf8JsonReaderOneOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (utf8JsonReaderOneOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderOneOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderTweetComplianceStreamResponseOneOf = utf8JsonReader;
                    ClientUtils.TryDeserialize<TweetComplianceStreamResponseOneOf?>(ref utf8JsonReaderTweetComplianceStreamResponseOneOf, jsonSerializerOptions, out tweetComplianceStreamResponseOneOf);

                    Utf8JsonReader utf8JsonReaderLikesComplianceStreamResponseOneOf1 = utf8JsonReader;
                    ClientUtils.TryDeserialize<LikesComplianceStreamResponseOneOf1?>(ref utf8JsonReaderLikesComplianceStreamResponseOneOf1, jsonSerializerOptions, out likesComplianceStreamResponseOneOf1);
                }
            }

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
                        default:
                            break;
                    }
                }
            }

            if (tweetComplianceStreamResponseOneOf != null)
                return new TweetComplianceStreamResponse(tweetComplianceStreamResponseOneOf);

            if (likesComplianceStreamResponseOneOf1 != null)
                return new TweetComplianceStreamResponse(likesComplianceStreamResponseOneOf1);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="TweetComplianceStreamResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetComplianceStreamResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TweetComplianceStreamResponse tweetComplianceStreamResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tweetComplianceStreamResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TweetComplianceStreamResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tweetComplianceStreamResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TweetComplianceStreamResponse tweetComplianceStreamResponse, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}

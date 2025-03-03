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
    /// A trend.
    /// </summary>
    public partial class PersonalizedTrend : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedTrend" /> class.
        /// </summary>
        /// <param name="category">Category of this trend.</param>
        /// <param name="postCount">Number of posts pertaining to this trend.</param>
        /// <param name="trendName">Name of the trend.</param>
        /// <param name="trendingSince">Time since this is trending.</param>
        [JsonConstructor]
        public PersonalizedTrend(Option<string?> category = default, Option<int?> postCount = default, Option<string?> trendName = default, Option<string?> trendingSince = default)
        {
            CategoryOption = category;
            PostCountOption = postCount;
            TrendNameOption = trendName;
            TrendingSinceOption = trendingSince;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Category
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CategoryOption { get; private set; }

        /// <summary>
        /// Category of this trend.
        /// </summary>
        /// <value>Category of this trend.</value>
        [JsonPropertyName("category")]
        public string? Category { get { return this.CategoryOption; } set { this.CategoryOption = new(value); } }

        /// <summary>
        /// Used to track the state of PostCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> PostCountOption { get; private set; }

        /// <summary>
        /// Number of posts pertaining to this trend.
        /// </summary>
        /// <value>Number of posts pertaining to this trend.</value>
        [JsonPropertyName("post_count")]
        public int? PostCount { get { return this.PostCountOption; } set { this.PostCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of TrendName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TrendNameOption { get; private set; }

        /// <summary>
        /// Name of the trend.
        /// </summary>
        /// <value>Name of the trend.</value>
        [JsonPropertyName("trend_name")]
        public string? TrendName { get { return this.TrendNameOption; } set { this.TrendNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of TrendingSince
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TrendingSinceOption { get; private set; }

        /// <summary>
        /// Time since this is trending.
        /// </summary>
        /// <value>Time since this is trending.</value>
        [JsonPropertyName("trending_since")]
        public string? TrendingSince { get { return this.TrendingSinceOption; } set { this.TrendingSinceOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonalizedTrend {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  PostCount: ").Append(PostCount).Append("\n");
            sb.Append("  TrendName: ").Append(TrendName).Append("\n");
            sb.Append("  TrendingSince: ").Append(TrendingSince).Append("\n");
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
    /// A Json converter for type <see cref="PersonalizedTrend" />
    /// </summary>
    public class PersonalizedTrendJsonConverter : JsonConverter<PersonalizedTrend>
    {
        /// <summary>
        /// Deserializes json to <see cref="PersonalizedTrend" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PersonalizedTrend Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> category = default;
            Option<int?> postCount = default;
            Option<string?> trendName = default;
            Option<string?> trendingSince = default;

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
                        case "category":
                            category = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "post_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                postCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "trend_name":
                            trendName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "trending_since":
                            trendingSince = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (category.IsSet && category.Value == null)
                throw new ArgumentNullException(nameof(category), "Property is not nullable for class PersonalizedTrend.");

            if (postCount.IsSet && postCount.Value == null)
                throw new ArgumentNullException(nameof(postCount), "Property is not nullable for class PersonalizedTrend.");

            if (trendName.IsSet && trendName.Value == null)
                throw new ArgumentNullException(nameof(trendName), "Property is not nullable for class PersonalizedTrend.");

            if (trendingSince.IsSet && trendingSince.Value == null)
                throw new ArgumentNullException(nameof(trendingSince), "Property is not nullable for class PersonalizedTrend.");

            return new PersonalizedTrend(category, postCount, trendName, trendingSince);
        }

        /// <summary>
        /// Serializes a <see cref="PersonalizedTrend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="personalizedTrend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PersonalizedTrend personalizedTrend, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, personalizedTrend, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PersonalizedTrend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="personalizedTrend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PersonalizedTrend personalizedTrend, JsonSerializerOptions jsonSerializerOptions)
        {
            if (personalizedTrend.CategoryOption.IsSet && personalizedTrend.Category == null)
                throw new ArgumentNullException(nameof(personalizedTrend.Category), "Property is required for class PersonalizedTrend.");

            if (personalizedTrend.TrendNameOption.IsSet && personalizedTrend.TrendName == null)
                throw new ArgumentNullException(nameof(personalizedTrend.TrendName), "Property is required for class PersonalizedTrend.");

            if (personalizedTrend.TrendingSinceOption.IsSet && personalizedTrend.TrendingSince == null)
                throw new ArgumentNullException(nameof(personalizedTrend.TrendingSince), "Property is required for class PersonalizedTrend.");

            if (personalizedTrend.CategoryOption.IsSet)
                writer.WriteString("category", personalizedTrend.Category);

            if (personalizedTrend.PostCountOption.IsSet)
                writer.WriteNumber("post_count", personalizedTrend.PostCountOption.Value!.Value);

            if (personalizedTrend.TrendNameOption.IsSet)
                writer.WriteString("trend_name", personalizedTrend.TrendName);

            if (personalizedTrend.TrendingSinceOption.IsSet)
                writer.WriteString("trending_since", personalizedTrend.TrendingSince);
        }
    }
}

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
    /// Represent the portion of text recognized as a URL.
    /// </summary>
    public partial class UrlFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlFields" /> class.
        /// </summary>
        /// <param name="url">A validly formatted URL.</param>
        /// <param name="description">Description of the URL landing page.</param>
        /// <param name="displayUrl">The URL as displayed in the X client.</param>
        /// <param name="expandedUrl">A validly formatted URL.</param>
        /// <param name="images">images</param>
        /// <param name="mediaKey">The Media Key identifier for this attachment.</param>
        /// <param name="status">HTTP Status Code.</param>
        /// <param name="title">Title of the page the URL points to.</param>
        /// <param name="unwoundUrl">Fully resolved url.</param>
        [JsonConstructor]
        public UrlFields(string url, Option<string?> description = default, Option<string?> displayUrl = default, Option<string?> expandedUrl = default, Option<List<UrlImage>?> images = default, Option<string?> mediaKey = default, Option<int?> status = default, Option<string?> title = default, Option<string?> unwoundUrl = default)
        {
            Url = url;
            DescriptionOption = description;
            DisplayUrlOption = displayUrl;
            ExpandedUrlOption = expandedUrl;
            ImagesOption = images;
            MediaKeyOption = mediaKey;
            StatusOption = status;
            TitleOption = title;
            UnwoundUrlOption = unwoundUrl;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A validly formatted URL.
        /// </summary>
        /// <value>A validly formatted URL.</value>
        /* <example>https://developer.twitter.com/en/docs/twitter-api</example> */
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// Description of the URL landing page.
        /// </summary>
        /// <value>Description of the URL landing page.</value>
        /* <example>This is a description of the website.</example> */
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of DisplayUrl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DisplayUrlOption { get; private set; }

        /// <summary>
        /// The URL as displayed in the X client.
        /// </summary>
        /// <value>The URL as displayed in the X client.</value>
        /* <example>twittercommunity.com/t/introducing-…</example> */
        [JsonPropertyName("display_url")]
        public string? DisplayUrl { get { return this.DisplayUrlOption; } set { this.DisplayUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExpandedUrl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExpandedUrlOption { get; private set; }

        /// <summary>
        /// A validly formatted URL.
        /// </summary>
        /// <value>A validly formatted URL.</value>
        /* <example>https://developer.twitter.com/en/docs/twitter-api</example> */
        [JsonPropertyName("expanded_url")]
        public string? ExpandedUrl { get { return this.ExpandedUrlOption; } set { this.ExpandedUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of Images
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UrlImage>?> ImagesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [JsonPropertyName("images")]
        public List<UrlImage>? Images { get { return this.ImagesOption; } set { this.ImagesOption = new(value); } }

        /// <summary>
        /// Used to track the state of MediaKey
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MediaKeyOption { get; private set; }

        /// <summary>
        /// The Media Key identifier for this attachment.
        /// </summary>
        /// <value>The Media Key identifier for this attachment.</value>
        [JsonPropertyName("media_key")]
        public string? MediaKey { get { return this.MediaKeyOption; } set { this.MediaKeyOption = new(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> StatusOption { get; private set; }

        /// <summary>
        /// HTTP Status Code.
        /// </summary>
        /// <value>HTTP Status Code.</value>
        [JsonPropertyName("status")]
        public int? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TitleOption { get; private set; }

        /// <summary>
        /// Title of the page the URL points to.
        /// </summary>
        /// <value>Title of the page the URL points to.</value>
        /* <example>Introducing the v2 follow lookup endpoints</example> */
        [JsonPropertyName("title")]
        public string? Title { get { return this.TitleOption; } set { this.TitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of UnwoundUrl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UnwoundUrlOption { get; private set; }

        /// <summary>
        /// Fully resolved url.
        /// </summary>
        /// <value>Fully resolved url.</value>
        /* <example>https://twittercommunity.com/t/introducing-the-v2-follow-lookup-endpoints/147118</example> */
        [JsonPropertyName("unwound_url")]
        public string? UnwoundUrl { get { return this.UnwoundUrlOption; } set { this.UnwoundUrlOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UrlFields {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayUrl: ").Append(DisplayUrl).Append("\n");
            sb.Append("  ExpandedUrl: ").Append(ExpandedUrl).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  MediaKey: ").Append(MediaKey).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UnwoundUrl: ").Append(UnwoundUrl).Append("\n");
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
            if (this.MediaKeyOption.Value != null) {
                // MediaKey (string) pattern
                Regex regexMediaKey = new Regex(@"^([0-9]+)_([0-9]+)$", RegexOptions.CultureInvariant);

                if (this.MediaKeyOption.Value != null &&!regexMediaKey.Match(this.MediaKeyOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaKey, must match a pattern of " + regexMediaKey, new [] { "MediaKey" });
                }
            }

            // Status (int) maximum
            if (this.StatusOption.IsSet && this.StatusOption.Value > (int)599)
            {
                yield return new ValidationResult("Invalid value for Status, must be a value less than or equal to 599.", new [] { "Status" });
            }

            // Status (int) minimum
            if (this.StatusOption.IsSet && this.StatusOption.Value < (int)100)
            {
                yield return new ValidationResult("Invalid value for Status, must be a value greater than or equal to 100.", new [] { "Status" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UrlFields" />
    /// </summary>
    public class UrlFieldsJsonConverter : JsonConverter<UrlFields>
    {
        /// <summary>
        /// Deserializes json to <see cref="UrlFields" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UrlFields Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> url = default;
            Option<string?> description = default;
            Option<string?> displayUrl = default;
            Option<string?> expandedUrl = default;
            Option<List<UrlImage>?> images = default;
            Option<string?> mediaKey = default;
            Option<int?> status = default;
            Option<string?> title = default;
            Option<string?> unwoundUrl = default;

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
                        case "url":
                            url = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "display_url":
                            displayUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "expanded_url":
                            expandedUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "images":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                images = new Option<List<UrlImage>?>(JsonSerializer.Deserialize<List<UrlImage>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "media_key":
                            mediaKey = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "unwound_url":
                            unwoundUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!url.IsSet)
                throw new ArgumentException("Property is required for class UrlFields.", nameof(url));

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class UrlFields.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class UrlFields.");

            if (displayUrl.IsSet && displayUrl.Value == null)
                throw new ArgumentNullException(nameof(displayUrl), "Property is not nullable for class UrlFields.");

            if (expandedUrl.IsSet && expandedUrl.Value == null)
                throw new ArgumentNullException(nameof(expandedUrl), "Property is not nullable for class UrlFields.");

            if (images.IsSet && images.Value == null)
                throw new ArgumentNullException(nameof(images), "Property is not nullable for class UrlFields.");

            if (mediaKey.IsSet && mediaKey.Value == null)
                throw new ArgumentNullException(nameof(mediaKey), "Property is not nullable for class UrlFields.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class UrlFields.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class UrlFields.");

            if (unwoundUrl.IsSet && unwoundUrl.Value == null)
                throw new ArgumentNullException(nameof(unwoundUrl), "Property is not nullable for class UrlFields.");

            return new UrlFields(url.Value!, description, displayUrl, expandedUrl, images, mediaKey, status, title, unwoundUrl);
        }

        /// <summary>
        /// Serializes a <see cref="UrlFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="urlFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UrlFields urlFields, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, urlFields, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UrlFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="urlFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UrlFields urlFields, JsonSerializerOptions jsonSerializerOptions)
        {
            if (urlFields.Url == null)
                throw new ArgumentNullException(nameof(urlFields.Url), "Property is required for class UrlFields.");

            if (urlFields.DescriptionOption.IsSet && urlFields.Description == null)
                throw new ArgumentNullException(nameof(urlFields.Description), "Property is required for class UrlFields.");

            if (urlFields.DisplayUrlOption.IsSet && urlFields.DisplayUrl == null)
                throw new ArgumentNullException(nameof(urlFields.DisplayUrl), "Property is required for class UrlFields.");

            if (urlFields.ExpandedUrlOption.IsSet && urlFields.ExpandedUrl == null)
                throw new ArgumentNullException(nameof(urlFields.ExpandedUrl), "Property is required for class UrlFields.");

            if (urlFields.ImagesOption.IsSet && urlFields.Images == null)
                throw new ArgumentNullException(nameof(urlFields.Images), "Property is required for class UrlFields.");

            if (urlFields.MediaKeyOption.IsSet && urlFields.MediaKey == null)
                throw new ArgumentNullException(nameof(urlFields.MediaKey), "Property is required for class UrlFields.");

            if (urlFields.TitleOption.IsSet && urlFields.Title == null)
                throw new ArgumentNullException(nameof(urlFields.Title), "Property is required for class UrlFields.");

            if (urlFields.UnwoundUrlOption.IsSet && urlFields.UnwoundUrl == null)
                throw new ArgumentNullException(nameof(urlFields.UnwoundUrl), "Property is required for class UrlFields.");

            writer.WriteString("url", urlFields.Url);

            if (urlFields.DescriptionOption.IsSet)
                writer.WriteString("description", urlFields.Description);

            if (urlFields.DisplayUrlOption.IsSet)
                writer.WriteString("display_url", urlFields.DisplayUrl);

            if (urlFields.ExpandedUrlOption.IsSet)
                writer.WriteString("expanded_url", urlFields.ExpandedUrl);

            if (urlFields.ImagesOption.IsSet)
            {
                writer.WritePropertyName("images");
                JsonSerializer.Serialize(writer, urlFields.Images, jsonSerializerOptions);
            }
            if (urlFields.MediaKeyOption.IsSet)
                writer.WriteString("media_key", urlFields.MediaKey);

            if (urlFields.StatusOption.IsSet)
                writer.WriteNumber("status", urlFields.StatusOption.Value!.Value);

            if (urlFields.TitleOption.IsSet)
                writer.WriteString("title", urlFields.Title);

            if (urlFields.UnwoundUrlOption.IsSet)
                writer.WriteString("unwound_url", urlFields.UnwoundUrl);
        }
    }
}

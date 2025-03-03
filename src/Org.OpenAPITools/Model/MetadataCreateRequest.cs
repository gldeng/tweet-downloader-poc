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
    /// MetadataCreateRequest
    /// </summary>
    public partial class MetadataCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataCreateRequest" /> class.
        /// </summary>
        /// <param name="mediaId">The unique identifier of this Media.</param>
        /// <param name="allowDownloadStatus">allowDownloadStatus</param>
        /// <param name="altText">altText</param>
        /// <param name="foundMediaOrigin">foundMediaOrigin</param>
        /// <param name="stickerInfo">stickerInfo</param>
        /// <param name="uploadSource">uploadSource</param>
        [JsonConstructor]
        public MetadataCreateRequest(string mediaId, Option<AllowDownloadStatus?> allowDownloadStatus = default, Option<AltText?> altText = default, Option<FoundMediaOrigin?> foundMediaOrigin = default, Option<StickerInfo?> stickerInfo = default, Option<UploadSource?> uploadSource = default)
        {
            MediaId = mediaId;
            AllowDownloadStatusOption = allowDownloadStatus;
            AltTextOption = altText;
            FoundMediaOriginOption = foundMediaOrigin;
            StickerInfoOption = stickerInfo;
            UploadSourceOption = uploadSource;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The unique identifier of this Media.
        /// </summary>
        /// <value>The unique identifier of this Media.</value>
        /* <example>1146654567674912769</example> */
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// Used to track the state of AllowDownloadStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AllowDownloadStatus?> AllowDownloadStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets AllowDownloadStatus
        /// </summary>
        [JsonPropertyName("allow_download_status")]
        public AllowDownloadStatus? AllowDownloadStatus { get { return this.AllowDownloadStatusOption; } set { this.AllowDownloadStatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of AltText
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AltText?> AltTextOption { get; private set; }

        /// <summary>
        /// Gets or Sets AltText
        /// </summary>
        [JsonPropertyName("alt_text")]
        public AltText? AltText { get { return this.AltTextOption; } set { this.AltTextOption = new(value); } }

        /// <summary>
        /// Used to track the state of FoundMediaOrigin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FoundMediaOrigin?> FoundMediaOriginOption { get; private set; }

        /// <summary>
        /// Gets or Sets FoundMediaOrigin
        /// </summary>
        [JsonPropertyName("found_media_origin")]
        public FoundMediaOrigin? FoundMediaOrigin { get { return this.FoundMediaOriginOption; } set { this.FoundMediaOriginOption = new(value); } }

        /// <summary>
        /// Used to track the state of StickerInfo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<StickerInfo?> StickerInfoOption { get; private set; }

        /// <summary>
        /// Gets or Sets StickerInfo
        /// </summary>
        [JsonPropertyName("sticker_info")]
        public StickerInfo? StickerInfo { get { return this.StickerInfoOption; } set { this.StickerInfoOption = new(value); } }

        /// <summary>
        /// Used to track the state of UploadSource
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UploadSource?> UploadSourceOption { get; private set; }

        /// <summary>
        /// Gets or Sets UploadSource
        /// </summary>
        [JsonPropertyName("upload_source")]
        public UploadSource? UploadSource { get { return this.UploadSourceOption; } set { this.UploadSourceOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetadataCreateRequest {\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  AllowDownloadStatus: ").Append(AllowDownloadStatus).Append("\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  FoundMediaOrigin: ").Append(FoundMediaOrigin).Append("\n");
            sb.Append("  StickerInfo: ").Append(StickerInfo).Append("\n");
            sb.Append("  UploadSource: ").Append(UploadSource).Append("\n");
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
            if (this.MediaId != null) {
                // MediaId (string) pattern
                Regex regexMediaId = new Regex(@"^[0-9]{1,19}$", RegexOptions.CultureInvariant);

                if (!regexMediaId.Match(this.MediaId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MetadataCreateRequest" />
    /// </summary>
    public class MetadataCreateRequestJsonConverter : JsonConverter<MetadataCreateRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="MetadataCreateRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MetadataCreateRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> mediaId = default;
            Option<AllowDownloadStatus?> allowDownloadStatus = default;
            Option<AltText?> altText = default;
            Option<FoundMediaOrigin?> foundMediaOrigin = default;
            Option<StickerInfo?> stickerInfo = default;
            Option<UploadSource?> uploadSource = default;

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
                        case "media_id":
                            mediaId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "allow_download_status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                allowDownloadStatus = new Option<AllowDownloadStatus?>(JsonSerializer.Deserialize<AllowDownloadStatus>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "alt_text":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                altText = new Option<AltText?>(JsonSerializer.Deserialize<AltText>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "found_media_origin":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                foundMediaOrigin = new Option<FoundMediaOrigin?>(JsonSerializer.Deserialize<FoundMediaOrigin>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "sticker_info":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stickerInfo = new Option<StickerInfo?>(JsonSerializer.Deserialize<StickerInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "upload_source":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uploadSource = new Option<UploadSource?>(JsonSerializer.Deserialize<UploadSource>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!mediaId.IsSet)
                throw new ArgumentException("Property is required for class MetadataCreateRequest.", nameof(mediaId));

            if (mediaId.IsSet && mediaId.Value == null)
                throw new ArgumentNullException(nameof(mediaId), "Property is not nullable for class MetadataCreateRequest.");

            if (allowDownloadStatus.IsSet && allowDownloadStatus.Value == null)
                throw new ArgumentNullException(nameof(allowDownloadStatus), "Property is not nullable for class MetadataCreateRequest.");

            if (altText.IsSet && altText.Value == null)
                throw new ArgumentNullException(nameof(altText), "Property is not nullable for class MetadataCreateRequest.");

            if (foundMediaOrigin.IsSet && foundMediaOrigin.Value == null)
                throw new ArgumentNullException(nameof(foundMediaOrigin), "Property is not nullable for class MetadataCreateRequest.");

            if (stickerInfo.IsSet && stickerInfo.Value == null)
                throw new ArgumentNullException(nameof(stickerInfo), "Property is not nullable for class MetadataCreateRequest.");

            if (uploadSource.IsSet && uploadSource.Value == null)
                throw new ArgumentNullException(nameof(uploadSource), "Property is not nullable for class MetadataCreateRequest.");

            return new MetadataCreateRequest(mediaId.Value!, allowDownloadStatus, altText, foundMediaOrigin, stickerInfo, uploadSource);
        }

        /// <summary>
        /// Serializes a <see cref="MetadataCreateRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="metadataCreateRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MetadataCreateRequest metadataCreateRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, metadataCreateRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MetadataCreateRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="metadataCreateRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MetadataCreateRequest metadataCreateRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (metadataCreateRequest.MediaId == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.MediaId), "Property is required for class MetadataCreateRequest.");

            if (metadataCreateRequest.AllowDownloadStatusOption.IsSet && metadataCreateRequest.AllowDownloadStatus == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.AllowDownloadStatus), "Property is required for class MetadataCreateRequest.");

            if (metadataCreateRequest.AltTextOption.IsSet && metadataCreateRequest.AltText == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.AltText), "Property is required for class MetadataCreateRequest.");

            if (metadataCreateRequest.FoundMediaOriginOption.IsSet && metadataCreateRequest.FoundMediaOrigin == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.FoundMediaOrigin), "Property is required for class MetadataCreateRequest.");

            if (metadataCreateRequest.StickerInfoOption.IsSet && metadataCreateRequest.StickerInfo == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.StickerInfo), "Property is required for class MetadataCreateRequest.");

            if (metadataCreateRequest.UploadSourceOption.IsSet && metadataCreateRequest.UploadSource == null)
                throw new ArgumentNullException(nameof(metadataCreateRequest.UploadSource), "Property is required for class MetadataCreateRequest.");

            writer.WriteString("media_id", metadataCreateRequest.MediaId);

            if (metadataCreateRequest.AllowDownloadStatusOption.IsSet)
            {
                writer.WritePropertyName("allow_download_status");
                JsonSerializer.Serialize(writer, metadataCreateRequest.AllowDownloadStatus, jsonSerializerOptions);
            }
            if (metadataCreateRequest.AltTextOption.IsSet)
            {
                writer.WritePropertyName("alt_text");
                JsonSerializer.Serialize(writer, metadataCreateRequest.AltText, jsonSerializerOptions);
            }
            if (metadataCreateRequest.FoundMediaOriginOption.IsSet)
            {
                writer.WritePropertyName("found_media_origin");
                JsonSerializer.Serialize(writer, metadataCreateRequest.FoundMediaOrigin, jsonSerializerOptions);
            }
            if (metadataCreateRequest.StickerInfoOption.IsSet)
            {
                writer.WritePropertyName("sticker_info");
                JsonSerializer.Serialize(writer, metadataCreateRequest.StickerInfo, jsonSerializerOptions);
            }
            if (metadataCreateRequest.UploadSourceOption.IsSet)
            {
                writer.WritePropertyName("upload_source");
                JsonSerializer.Serialize(writer, metadataCreateRequest.UploadSource, jsonSerializerOptions);
            }
        }
    }
}

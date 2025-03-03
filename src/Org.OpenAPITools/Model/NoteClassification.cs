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
    /// Community Note classification type.
    /// </summary>
    /// <value>Community Note classification type.</value>
    public enum NoteClassification
    {
        /// <summary>
        /// Enum HarmfullyMisleading for value: HarmfullyMisleading
        /// </summary>
        HarmfullyMisleading = 1,

        /// <summary>
        /// Enum MisinformedOrPotentiallyMisleading for value: MisinformedOrPotentiallyMisleading
        /// </summary>
        MisinformedOrPotentiallyMisleading = 2,

        /// <summary>
        /// Enum NotMisleading for value: NotMisleading
        /// </summary>
        NotMisleading = 3,

        /// <summary>
        /// Enum PotentiallyMisleading for value: PotentiallyMisleading
        /// </summary>
        PotentiallyMisleading = 4
    }

    /// <summary>
    /// Converts <see cref="NoteClassification"/> to and from the JSON value
    /// </summary>
    public static class NoteClassificationValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="NoteClassification"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static NoteClassification FromString(string value)
        {
            if (value.Equals("HarmfullyMisleading"))
                return NoteClassification.HarmfullyMisleading;

            if (value.Equals("MisinformedOrPotentiallyMisleading"))
                return NoteClassification.MisinformedOrPotentiallyMisleading;

            if (value.Equals("NotMisleading"))
                return NoteClassification.NotMisleading;

            if (value.Equals("PotentiallyMisleading"))
                return NoteClassification.PotentiallyMisleading;

            throw new NotImplementedException($"Could not convert value to type NoteClassification: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="NoteClassification"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static NoteClassification? FromStringOrDefault(string value)
        {
            if (value.Equals("HarmfullyMisleading"))
                return NoteClassification.HarmfullyMisleading;

            if (value.Equals("MisinformedOrPotentiallyMisleading"))
                return NoteClassification.MisinformedOrPotentiallyMisleading;

            if (value.Equals("NotMisleading"))
                return NoteClassification.NotMisleading;

            if (value.Equals("PotentiallyMisleading"))
                return NoteClassification.PotentiallyMisleading;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="NoteClassification"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(NoteClassification value)
        {
            if (value == NoteClassification.HarmfullyMisleading)
                return "HarmfullyMisleading";

            if (value == NoteClassification.MisinformedOrPotentiallyMisleading)
                return "MisinformedOrPotentiallyMisleading";

            if (value == NoteClassification.NotMisleading)
                return "NotMisleading";

            if (value == NoteClassification.PotentiallyMisleading)
                return "PotentiallyMisleading";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NoteClassification"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class NoteClassificationJsonConverter : JsonConverter<NoteClassification>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override NoteClassification Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            NoteClassification? result = rawValue == null
                ? null
                : NoteClassificationValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the NoteClassification to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="noteClassification"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, NoteClassification noteClassification, JsonSerializerOptions options)
        {
            writer.WriteStringValue(noteClassification.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NoteClassification"/>
    /// </summary>
    public class NoteClassificationNullableJsonConverter : JsonConverter<NoteClassification?>
    {
        /// <summary>
        /// Returns a NoteClassification from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override NoteClassification? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            NoteClassification? result = rawValue == null
                ? null
                : NoteClassificationValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="noteClassification"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, NoteClassification? noteClassification, JsonSerializerOptions options)
        {
            writer.WriteStringValue(noteClassification?.ToString() ?? "null");
        }
    }
}

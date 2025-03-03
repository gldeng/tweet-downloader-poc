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
    /// EngagementMeasurement
    /// </summary>
    public partial class EngagementMeasurement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngagementMeasurement" /> class.
        /// </summary>
        /// <param name="metricsTimeSeries">metricsTimeSeries</param>
        /// <param name="metricsTotal">metricsTotal</param>
        [JsonConstructor]
        public EngagementMeasurement(Option<List<EngagementMeasurementMetricsTimeSeriesInner>?> metricsTimeSeries = default, Option<List<EngagementMeasurementMetricsTotalInner>?> metricsTotal = default)
        {
            MetricsTimeSeriesOption = metricsTimeSeries;
            MetricsTotalOption = metricsTotal;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of MetricsTimeSeries
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EngagementMeasurementMetricsTimeSeriesInner>?> MetricsTimeSeriesOption { get; private set; }

        /// <summary>
        /// Gets or Sets MetricsTimeSeries
        /// </summary>
        [JsonPropertyName("metrics_time_series")]
        public List<EngagementMeasurementMetricsTimeSeriesInner>? MetricsTimeSeries { get { return this.MetricsTimeSeriesOption; } set { this.MetricsTimeSeriesOption = new(value); } }

        /// <summary>
        /// Used to track the state of MetricsTotal
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EngagementMeasurementMetricsTotalInner>?> MetricsTotalOption { get; private set; }

        /// <summary>
        /// Gets or Sets MetricsTotal
        /// </summary>
        [JsonPropertyName("metrics_total")]
        public List<EngagementMeasurementMetricsTotalInner>? MetricsTotal { get { return this.MetricsTotalOption; } set { this.MetricsTotalOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EngagementMeasurement {\n");
            sb.Append("  MetricsTimeSeries: ").Append(MetricsTimeSeries).Append("\n");
            sb.Append("  MetricsTotal: ").Append(MetricsTotal).Append("\n");
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
    /// A Json converter for type <see cref="EngagementMeasurement" />
    /// </summary>
    public class EngagementMeasurementJsonConverter : JsonConverter<EngagementMeasurement>
    {
        /// <summary>
        /// Deserializes json to <see cref="EngagementMeasurement" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EngagementMeasurement Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<EngagementMeasurementMetricsTimeSeriesInner>?> metricsTimeSeries = default;
            Option<List<EngagementMeasurementMetricsTotalInner>?> metricsTotal = default;

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
                        case "metrics_time_series":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metricsTimeSeries = new Option<List<EngagementMeasurementMetricsTimeSeriesInner>?>(JsonSerializer.Deserialize<List<EngagementMeasurementMetricsTimeSeriesInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "metrics_total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metricsTotal = new Option<List<EngagementMeasurementMetricsTotalInner>?>(JsonSerializer.Deserialize<List<EngagementMeasurementMetricsTotalInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (metricsTimeSeries.IsSet && metricsTimeSeries.Value == null)
                throw new ArgumentNullException(nameof(metricsTimeSeries), "Property is not nullable for class EngagementMeasurement.");

            if (metricsTotal.IsSet && metricsTotal.Value == null)
                throw new ArgumentNullException(nameof(metricsTotal), "Property is not nullable for class EngagementMeasurement.");

            return new EngagementMeasurement(metricsTimeSeries, metricsTotal);
        }

        /// <summary>
        /// Serializes a <see cref="EngagementMeasurement" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="engagementMeasurement"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EngagementMeasurement engagementMeasurement, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, engagementMeasurement, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EngagementMeasurement" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="engagementMeasurement"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EngagementMeasurement engagementMeasurement, JsonSerializerOptions jsonSerializerOptions)
        {
            if (engagementMeasurement.MetricsTimeSeriesOption.IsSet && engagementMeasurement.MetricsTimeSeries == null)
                throw new ArgumentNullException(nameof(engagementMeasurement.MetricsTimeSeries), "Property is required for class EngagementMeasurement.");

            if (engagementMeasurement.MetricsTotalOption.IsSet && engagementMeasurement.MetricsTotal == null)
                throw new ArgumentNullException(nameof(engagementMeasurement.MetricsTotal), "Property is required for class EngagementMeasurement.");

            if (engagementMeasurement.MetricsTimeSeriesOption.IsSet)
            {
                writer.WritePropertyName("metrics_time_series");
                JsonSerializer.Serialize(writer, engagementMeasurement.MetricsTimeSeries, jsonSerializerOptions);
            }
            if (engagementMeasurement.MetricsTotalOption.IsSet)
            {
                writer.WritePropertyName("metrics_total");
                JsonSerializer.Serialize(writer, engagementMeasurement.MetricsTotal, jsonSerializerOptions);
            }
        }
    }
}

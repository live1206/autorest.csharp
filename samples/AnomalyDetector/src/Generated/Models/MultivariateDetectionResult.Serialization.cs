// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using AnomalyDetector;
using Azure;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class MultivariateDetectionResult : IUtf8JsonSerializable, IJsonModel<MultivariateDetectionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MultivariateDetectionResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MultivariateDetectionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultivariateDetectionResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("resultId"u8);
                writer.WriteStringValue(ResultId);
            }
            writer.WritePropertyName("summary"u8);
            writer.WriteObjectValue(Summary);
            writer.WritePropertyName("results"u8);
            writer.WriteStartArray();
            foreach (var item in Results)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MultivariateDetectionResult IJsonModel<MultivariateDetectionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultivariateDetectionResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMultivariateDetectionResult(document.RootElement, options);
        }

        internal static MultivariateDetectionResult DeserializeMultivariateDetectionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid resultId = default;
            MultivariateBatchDetectionResultSummary summary = default;
            IReadOnlyList<AnomalyState> results = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resultId"u8))
                {
                    resultId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = MultivariateBatchDetectionResultSummary.DeserializeMultivariateBatchDetectionResultSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    List<AnomalyState> array = new List<AnomalyState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyState.DeserializeAnomalyState(item, options));
                    }
                    results = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MultivariateDetectionResult(resultId, summary, results, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MultivariateDetectionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MultivariateDetectionResult)} does not support '{options.Format}' format.");
            }
        }

        MultivariateDetectionResult IPersistableModel<MultivariateDetectionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMultivariateDetectionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MultivariateDetectionResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MultivariateDetectionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MultivariateDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMultivariateDetectionResult(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    public partial class RoundTripRecursiveModel : IUtf8JsonSerializable, IJsonModel<RoundTripRecursiveModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoundTripRecursiveModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoundTripRecursiveModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripRecursiveModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoundTripRecursiveModel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(Inner))
            {
                writer.WritePropertyName("inner"u8);
                writer.WriteObjectValue<RoundTripRecursiveModel>(Inner, options);
            }
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

        RoundTripRecursiveModel IJsonModel<RoundTripRecursiveModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripRecursiveModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoundTripRecursiveModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoundTripRecursiveModel(document.RootElement, options);
        }

        internal static RoundTripRecursiveModel DeserializeRoundTripRecursiveModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            RoundTripRecursiveModel inner = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inner = DeserializeRoundTripRecursiveModel(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoundTripRecursiveModel(message, inner, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoundTripRecursiveModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripRecursiveModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoundTripRecursiveModel)} does not support writing '{options.Format}' format.");
            }
        }

        RoundTripRecursiveModel IPersistableModel<RoundTripRecursiveModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripRecursiveModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoundTripRecursiveModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoundTripRecursiveModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoundTripRecursiveModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RoundTripRecursiveModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRoundTripRecursiveModel(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<RoundTripRecursiveModel>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}

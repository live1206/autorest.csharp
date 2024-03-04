// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using ModelShapes;

namespace ModelShapes.Models
{
    public partial class MixedModelWithReadonlyProperty : IUtf8JsonSerializable, IJsonModel<MixedModelWithReadonlyProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MixedModelWithReadonlyProperty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MixedModelWithReadonlyProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedModelWithReadonlyProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedModelWithReadonlyProperty)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ReadonlyProperty))
            {
                writer.WritePropertyName("ReadonlyProperty"u8);
                writer.WriteObjectValue(ReadonlyProperty);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReadonlyListProperty))
            {
                writer.WritePropertyName("ReadonlyListProperty"u8);
                writer.WriteStartArray();
                foreach (var item in ReadonlyListProperty)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MixedModelWithReadonlyProperty IJsonModel<MixedModelWithReadonlyProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedModelWithReadonlyProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedModelWithReadonlyProperty)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMixedModelWithReadonlyProperty(document.RootElement, options);
        }

        internal static MixedModelWithReadonlyProperty DeserializeMixedModelWithReadonlyProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReadonlyModel readonlyProperty = default;
            IReadOnlyList<ReadonlyModel> readonlyListProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ReadonlyProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readonlyProperty = ReadonlyModel.DeserializeReadonlyModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ReadonlyListProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReadonlyModel> array = new List<ReadonlyModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReadonlyModel.DeserializeReadonlyModel(item, options));
                    }
                    readonlyListProperty = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MixedModelWithReadonlyProperty(readonlyProperty, readonlyListProperty ?? new ChangeTrackingList<ReadonlyModel>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MixedModelWithReadonlyProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedModelWithReadonlyProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MixedModelWithReadonlyProperty)} does not support '{options.Format}' format.");
            }
        }

        MixedModelWithReadonlyProperty IPersistableModel<MixedModelWithReadonlyProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedModelWithReadonlyProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMixedModelWithReadonlyProperty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MixedModelWithReadonlyProperty)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MixedModelWithReadonlyProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

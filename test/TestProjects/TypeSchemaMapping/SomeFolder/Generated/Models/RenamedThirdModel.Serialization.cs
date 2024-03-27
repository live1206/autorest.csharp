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

namespace CustomNamespace
{
    internal partial class RenamedThirdModel : IUtf8JsonSerializable, IJsonModel<RenamedThirdModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RenamedThirdModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RenamedThirdModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RenamedThirdModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RenamedThirdModel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ETag"u8);
            writer.WriteStringValue(CustomizedETagProperty.ToString());
            writer.WritePropertyName("CreatedAt"u8);
            writer.WriteStringValue(CustomizedCreatedAtProperty);
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

        RenamedThirdModel IJsonModel<RenamedThirdModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RenamedThirdModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RenamedThirdModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRenamedThirdModel(document.RootElement, options);
        }

        internal static RenamedThirdModel DeserializeRenamedThirdModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag eTag = default;
            DateTime createdAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ETag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("CreatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTime();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RenamedThirdModel(eTag, createdAt, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RenamedThirdModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RenamedThirdModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RenamedThirdModel)} does not support writing '{options.Format}' format.");
            }
        }

        RenamedThirdModel IPersistableModel<RenamedThirdModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RenamedThirdModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRenamedThirdModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RenamedThirdModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RenamedThirdModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

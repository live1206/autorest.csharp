// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    [PersistableModelProxy(typeof(UnknownBird))]
    public partial class Bird : IUtf8JsonSerializable, IJsonModel<Bird>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Bird>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Bird>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Bird>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Bird)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("wingspan"u8);
            writer.WriteNumberValue(Wingspan);
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

        Bird IJsonModel<Bird>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Bird>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Bird)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBird(document.RootElement, options);
        }

        internal static Bird DeserializeBird(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "eagle": return Eagle.DeserializeEagle(element, options);
                    case "goose": return Goose.DeserializeGoose(element, options);
                    case "seagull": return SeaGull.DeserializeSeaGull(element, options);
                    case "sparrow": return Sparrow.DeserializeSparrow(element, options);
                }
            }
            return UnknownBird.DeserializeUnknownBird(element, options);
        }

        BinaryData IPersistableModel<Bird>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Bird>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Bird)} does not support writing '{options.Format}' format.");
            }
        }

        Bird IPersistableModel<Bird>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Bird>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBird(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Bird)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Bird>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Bird FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBird(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<Bird>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}

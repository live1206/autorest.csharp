// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEditRequest : IUtf8JsonWriteable, IJsonModel<CreateEditRequest>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateEditRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateEditRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
            if (Input != null)
            {
                if (Input != null)
                {
                    writer.WritePropertyName("input"u8);
                    writer.WriteStringValue(Input);
                }
                else
                {
                    writer.WriteNull("input");
                }
            }
            writer.WritePropertyName("instruction"u8);
            writer.WriteStringValue(Instruction);
            if (N.HasValue)
            {
                if (N != null)
                {
                    writer.WritePropertyName("n"u8);
                    writer.WriteNumberValue(N.Value);
                }
                else
                {
                    writer.WriteNull("n");
                }
            }
            if (Temperature.HasValue)
            {
                if (Temperature != null)
                {
                    writer.WritePropertyName("temperature"u8);
                    writer.WriteNumberValue(Temperature.Value);
                }
                else
                {
                    writer.WriteNull("temperature");
                }
            }
            if (TopP.HasValue)
            {
                if (TopP != null)
                {
                    writer.WritePropertyName("top_p"u8);
                    writer.WriteNumberValue(TopP.Value);
                }
                else
                {
                    writer.WriteNull("top_p");
                }
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

        CreateEditRequest IJsonModel<CreateEditRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateEditRequest(document.RootElement, options);
        }

        internal static CreateEditRequest DeserializeCreateEditRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CreateEditRequestModel model = default;
            OptionalProperty<string> input = default;
            string instruction = default;
            OptionalProperty<long?> n = default;
            OptionalProperty<double?> temperature = default;
            OptionalProperty<double?> topP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model"u8))
                {
                    model = new CreateEditRequestModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        input = null;
                        continue;
                    }
                    input = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instruction"u8))
                {
                    instruction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        n = null;
                        continue;
                    }
                    n = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        temperature = null;
                        continue;
                    }
                    temperature = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        topP = null;
                        continue;
                    }
                    topP = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateEditRequest(
                model,
                input.Value,
                instruction,
                OptionalProperty.ToNullable(n),
                OptionalProperty.ToNullable(temperature),
                OptionalProperty.ToNullable(topP),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateEditRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateEditRequest)} does not support '{options.Format}' format.");
            }
        }

        CreateEditRequest IPersistableModel<CreateEditRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateEditRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateEditRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateEditRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateEditRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateEditRequest(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

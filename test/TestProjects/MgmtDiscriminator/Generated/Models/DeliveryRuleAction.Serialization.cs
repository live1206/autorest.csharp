// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;
using MgmtDiscriminator;

namespace MgmtDiscriminator.Models
{
    public partial class DeliveryRuleAction : IUtf8JsonSerializable, IJsonModel<DeliveryRuleAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeliveryRuleAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeliveryRuleAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            if (options.Format != "W" && Optional.IsDefined(Foo))
            {
                writer.WritePropertyName("foo"u8);
                writer.WriteStringValue(Foo);
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

        DeliveryRuleAction IJsonModel<DeliveryRuleAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleAction(document.RootElement, options);
        }

        internal static DeliveryRuleAction DeserializeDeliveryRuleAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("name", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "UrlRedirect": return UrlRedirectAction.DeserializeUrlRedirectAction(element, options);
                    case "UrlSigning": return UrlSigningAction.DeserializeUrlSigningAction(element, options);
                    case "OriginGroupOverride": return OriginGroupOverrideAction.DeserializeOriginGroupOverrideAction(element, options);
                    case "UrlRewrite": return UrlRewriteAction.DeserializeUrlRewriteAction(element, options);
                    case "ModifyRequestHeader": return DeliveryRuleRequestHeaderAction.DeserializeDeliveryRuleRequestHeaderAction(element, options);
                    case "ModifyResponseHeader": return DeliveryRuleResponseHeaderAction.DeserializeDeliveryRuleResponseHeaderAction(element, options);
                    case "CacheExpiration": return DeliveryRuleCacheExpirationAction.DeserializeDeliveryRuleCacheExpirationAction(element, options);
                    case "CacheKeyQueryString": return DeliveryRuleCacheKeyQueryStringAction.DeserializeDeliveryRuleCacheKeyQueryStringAction(element, options);
                    case "RouteConfigurationOverride": return DeliveryRuleRouteConfigurationOverrideAction.DeserializeDeliveryRuleRouteConfigurationOverrideAction(element, options);
                }
            }
            return UnknownDeliveryRuleAction.DeserializeUnknownDeliveryRuleAction(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            builder.Append("  name:");
            builder.AppendLine($" '{Name.ToString()}'");

            if (Optional.IsDefined(Foo))
            {
                builder.Append("  foo:");
                if (Foo.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Foo}'''");
                }
                else
                {
                    builder.AppendLine($" '{Foo}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<DeliveryRuleAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleAction)} does not support '{options.Format}' format.");
            }
        }

        DeliveryRuleAction IPersistableModel<DeliveryRuleAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeliveryRuleAction(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeliveryRuleAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    public partial class VirtualMachineScaleSetData : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Plan != null)
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteObjectValue(Plan);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (!(Zones is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (UpgradePolicy != null)
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy);
            }
            if (AutomaticRepairsPolicy != null)
            {
                writer.WritePropertyName("automaticRepairsPolicy"u8);
                writer.WriteObjectValue(AutomaticRepairsPolicy);
            }
            if (VirtualMachineProfile != null)
            {
                writer.WritePropertyName("virtualMachineProfile"u8);
                writer.WriteObjectValue(VirtualMachineProfile);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Overprovision.HasValue)
            {
                writer.WritePropertyName("overprovision"u8);
                writer.WriteBooleanValue(Overprovision.Value);
            }
            if (DoNotRunExtensionsOnOverprovisionedVms.HasValue)
            {
                writer.WritePropertyName("doNotRunExtensionsOnOverprovisionedVMs"u8);
                writer.WriteBooleanValue(DoNotRunExtensionsOnOverprovisionedVms.Value);
            }
            if (options.Format != "W" && UniqueId != null)
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
            }
            if (SinglePlacementGroup.HasValue)
            {
                writer.WritePropertyName("singlePlacementGroup"u8);
                writer.WriteBooleanValue(SinglePlacementGroup.Value);
            }
            if (ZoneBalance.HasValue)
            {
                writer.WritePropertyName("zoneBalance"u8);
                writer.WriteBooleanValue(ZoneBalance.Value);
            }
            if (PlatformFaultDomainCount.HasValue)
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (ProximityPlacementGroup != null)
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                JsonSerializer.Serialize(writer, ProximityPlacementGroup);
            }
            if (HostGroup != null)
            {
                writer.WritePropertyName("hostGroup"u8);
                JsonSerializer.Serialize(writer, HostGroup);
            }
            if (AdditionalCapabilities != null)
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            if (ScaleInPolicy != null)
            {
                writer.WritePropertyName("scaleInPolicy"u8);
                writer.WriteObjectValue(ScaleInPolicy);
            }
            writer.WriteEndObject();
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

        VirtualMachineScaleSetData IJsonModel<VirtualMachineScaleSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetData(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetData DeserializeVirtualMachineScaleSetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SampleSku> sku = default;
            Optional<SamplePlan> plan = default;
            Optional<ManagedServiceIdentity> identity = default;
            IList<string> zones = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<UpgradePolicy> upgradePolicy = default;
            Optional<AutomaticRepairsPolicy> automaticRepairsPolicy = default;
            Optional<VirtualMachineScaleSetVmProfile> virtualMachineProfile = default;
            Optional<string> provisioningState = default;
            Optional<bool> overprovision = default;
            Optional<bool> doNotRunExtensionsOnOverprovisionedVms = default;
            Optional<string> uniqueId = default;
            Optional<bool> singlePlacementGroup = default;
            Optional<bool> zoneBalance = default;
            Optional<int> platformFaultDomainCount = default;
            Optional<WritableSubResource> proximityPlacementGroup = default;
            Optional<WritableSubResource> hostGroup = default;
            Optional<AdditionalCapabilities> additionalCapabilities = default;
            Optional<ScaleInPolicy> scaleInPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SampleSku.DeserializeSampleSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = SamplePlan.DeserializeSamplePlan(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = UpgradePolicy.DeserializeUpgradePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("automaticRepairsPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticRepairsPolicy = AutomaticRepairsPolicy.DeserializeAutomaticRepairsPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineProfile = VirtualMachineScaleSetVmProfile.DeserializeVirtualMachineScaleSetVmProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overprovision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overprovision = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("doNotRunExtensionsOnOverprovisionedVMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            doNotRunExtensionsOnOverprovisionedVms = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("singlePlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            singlePlacementGroup = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("zoneBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneBalance = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scaleInPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleInPolicy = ScaleInPolicy.DeserializeScaleInPolicy(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetData(
                id,
                name,
                type,
                systemData.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku.Value,
                plan.Value,
                identity,
                zones ?? new ChangeTrackingList<string>(),
                upgradePolicy.Value,
                automaticRepairsPolicy.Value,
                virtualMachineProfile.Value,
                provisioningState.Value,
                Optional.ToNullable(overprovision),
                Optional.ToNullable(doNotRunExtensionsOnOverprovisionedVms),
                uniqueId.Value,
                Optional.ToNullable(singlePlacementGroup),
                Optional.ToNullable(zoneBalance),
                Optional.ToNullable(platformFaultDomainCount),
                proximityPlacementGroup,
                hostGroup,
                additionalCapabilities.Value,
                scaleInPolicy.Value,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Name != null)
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            builder.Append("  location:");
            builder.AppendLine($" '{Location.ToString()}'");

            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}:");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Value.Contains(Environment.NewLine))
                        {
                            builder.AppendLine(" '''");
                            builder.AppendLine($"{item.Value}'''");
                        }
                        else
                        {
                            builder.AppendLine($" '{item.Value}'");
                        }
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Sku != null)
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            if (Plan != null)
            {
                builder.Append("  plan:");
                AppendChildObject(builder, Plan, options, 2, false);
            }

            if (Identity != null)
            {
                builder.Append("  identity:");
                AppendChildObject(builder, Identity, options, 2, false);
            }

            if (!(Zones is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                if (Zones.Any())
                {
                    builder.Append("  zones:");
                    builder.AppendLine(" [");
                    foreach (var item in Zones)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Id != null)
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (SystemData != null)
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (UpgradePolicy != null)
            {
                builder.Append("    upgradePolicy:");
                AppendChildObject(builder, UpgradePolicy, options, 4, false);
            }

            if (AutomaticRepairsPolicy != null)
            {
                builder.Append("    automaticRepairsPolicy:");
                AppendChildObject(builder, AutomaticRepairsPolicy, options, 4, false);
            }

            if (VirtualMachineProfile != null)
            {
                builder.Append("    virtualMachineProfile:");
                AppendChildObject(builder, VirtualMachineProfile, options, 4, false);
            }

            if (ProvisioningState != null)
            {
                builder.Append("    provisioningState:");
                if (ProvisioningState.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ProvisioningState}'''");
                }
                else
                {
                    builder.AppendLine($" '{ProvisioningState}'");
                }
            }

            if (Overprovision.HasValue)
            {
                builder.Append("    overprovision:");
                var boolValue = Overprovision.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (DoNotRunExtensionsOnOverprovisionedVms.HasValue)
            {
                builder.Append("    doNotRunExtensionsOnOverprovisionedVMs:");
                var boolValue = DoNotRunExtensionsOnOverprovisionedVms.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (UniqueId != null)
            {
                builder.Append("    uniqueId:");
                if (UniqueId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{UniqueId}'''");
                }
                else
                {
                    builder.AppendLine($" '{UniqueId}'");
                }
            }

            if (SinglePlacementGroup.HasValue)
            {
                builder.Append("    singlePlacementGroup:");
                var boolValue = SinglePlacementGroup.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (ZoneBalance.HasValue)
            {
                builder.Append("    zoneBalance:");
                var boolValue = ZoneBalance.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (PlatformFaultDomainCount.HasValue)
            {
                builder.Append("    platformFaultDomainCount:");
                builder.AppendLine($" {PlatformFaultDomainCount.Value}");
            }

            if (ProximityPlacementGroup != null)
            {
                builder.Append("    proximityPlacementGroup:");
                AppendChildObject(builder, ProximityPlacementGroup, options, 4, false);
            }

            if (HostGroup != null)
            {
                builder.Append("    hostGroup:");
                AppendChildObject(builder, HostGroup, options, 4, false);
            }

            if (AdditionalCapabilities != null)
            {
                builder.Append("    additionalCapabilities:");
                AppendChildObject(builder, AdditionalCapabilities, options, 4, false);
            }

            if (ScaleInPolicy != null)
            {
                builder.Append("    scaleInPolicy:");
                AppendChildObject(builder, ScaleInPolicy, options, 4, false);
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<VirtualMachineScaleSetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetData IPersistableModel<VirtualMachineScaleSetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

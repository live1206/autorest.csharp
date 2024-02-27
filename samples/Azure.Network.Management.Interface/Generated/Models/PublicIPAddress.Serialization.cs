// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class PublicIPAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
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
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PublicIPAllocationMethod.HasValue)
            {
                writer.WritePropertyName("publicIPAllocationMethod"u8);
                writer.WriteStringValue(PublicIPAllocationMethod.Value.ToString());
            }
            if (PublicIPAddressVersion.HasValue)
            {
                writer.WritePropertyName("publicIPAddressVersion"u8);
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings);
            }
            if (DdosSettings != null)
            {
                writer.WritePropertyName("ddosSettings"u8);
                writer.WriteObjectValue(DdosSettings);
            }
            if (!(IpTags is ChangeTrackingList<IpTag> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("ipTags"u8);
                writer.WriteStartArray();
                foreach (var item in IpTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IpAddress != null)
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IpAddress);
            }
            if (PublicIPPrefix != null)
            {
                writer.WritePropertyName("publicIPPrefix"u8);
                writer.WriteObjectValue(PublicIPPrefix);
            }
            if (IdleTimeoutInMinutes.HasValue)
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicIPAddress DeserializePublicIPAddress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PublicIPAddressSku> sku = default;
            Optional<string> etag = default;
            IList<string> zones = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            IDictionary<string, string> tags = default;
            Optional<IPAllocationMethod> publicIPAllocationMethod = default;
            Optional<IPVersion> publicIPAddressVersion = default;
            Optional<IPConfiguration> ipConfiguration = default;
            Optional<PublicIPAddressDnsSettings> dnsSettings = default;
            Optional<DdosSettings> ddosSettings = default;
            IList<IpTag> ipTags = default;
            Optional<string> ipAddress = default;
            Optional<SubResource> publicIPPrefix = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PublicIPAddressSku.DeserializePublicIPAddressSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
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
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publicIPAllocationMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipConfiguration = IPConfiguration.DeserializeIPConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = PublicIPAddressDnsSettings.DeserializePublicIPAddressDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ddosSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ddosSettings = DdosSettings.DeserializeDdosSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IpTag> array = new List<IpTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpTag.DeserializeIpTag(item));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPPrefix = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicIPAddress(
                id.Value,
                name.Value,
                type.Value,
                location.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sku.Value,
                etag.Value,
                zones ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(publicIPAllocationMethod),
                Optional.ToNullable(publicIPAddressVersion),
                ipConfiguration.Value,
                dnsSettings.Value,
                ddosSettings.Value,
                ipTags ?? new ChangeTrackingList<IpTag>(),
                ipAddress.Value,
                publicIPPrefix.Value,
                Optional.ToNullable(idleTimeoutInMinutes),
                resourceGuid.Value,
                Optional.ToNullable(provisioningState));
        }
    }
}

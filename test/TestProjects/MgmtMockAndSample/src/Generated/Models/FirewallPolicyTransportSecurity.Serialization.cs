// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    internal partial class FirewallPolicyTransportSecurity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateAuthority))
            {
                writer.WritePropertyName("certificateAuthority"u8);
                writer.WriteObjectValue<FirewallPolicyCertificateAuthority>(CertificateAuthority);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyTransportSecurity DeserializeFirewallPolicyTransportSecurity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FirewallPolicyCertificateAuthority certificateAuthority = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateAuthority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateAuthority = FirewallPolicyCertificateAuthority.DeserializeFirewallPolicyCertificateAuthority(property.Value);
                    continue;
                }
            }
            return new FirewallPolicyTransportSecurity(certificateAuthority);
        }
    }
}

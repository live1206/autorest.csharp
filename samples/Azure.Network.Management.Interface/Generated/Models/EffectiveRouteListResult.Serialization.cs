// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class EffectiveRouteListResult
    {
        internal static EffectiveRouteListResult DeserializeEffectiveRouteListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<EffectiveRoute> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveRoute> array = new List<EffectiveRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveRoute.DeserializeEffectiveRoute(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EffectiveRouteListResult(value ?? new ChangeTrackingList<EffectiveRoute>(), nextLink);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtSupersetFlattenInheritance.Models
{
    internal partial class CustomModel1ListResult
    {
        internal static CustomModel1ListResult DeserializeCustomModel1ListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CustomModel1> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomModel1> array = new List<CustomModel1>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomModel1.DeserializeCustomModel1(item));
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
            return new CustomModel1ListResult(value ?? new ChangeTrackingList<CustomModel1>(), nextLink);
        }
    }
}

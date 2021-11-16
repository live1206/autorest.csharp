// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace SupersetFlattenInheritance.Models
{
    public partial class CustomModel1ListResult
    {
        internal static CustomModel1ListResult DeserializeCustomModel1ListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CustomModel1>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CustomModel1ListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}

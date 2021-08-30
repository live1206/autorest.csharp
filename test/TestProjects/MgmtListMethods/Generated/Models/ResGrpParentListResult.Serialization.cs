// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    public partial class ResGrpParentListResult
    {
        internal static ResGrpParentListResult DeserializeResGrpParentListResult(JsonElement element)
        {
            IReadOnlyList<ResGrpParentData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ResGrpParentData> array = new List<ResGrpParentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResGrpParentData.DeserializeResGrpParentData(item));
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
            return new ResGrpParentListResult(value, nextLink.Value);
        }
    }
}
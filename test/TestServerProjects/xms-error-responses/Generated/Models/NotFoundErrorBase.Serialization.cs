// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace xms_error_responses.Models
{
    internal partial class NotFoundErrorBase
    {
        internal static NotFoundErrorBase DeserializeNotFoundErrorBase(JsonElement element)
        {
            if (element.TryGetProperty("whatNotFound", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AnimalNotFound": return AnimalNotFound.DeserializeAnimalNotFound(element);
                    case "InvalidResourceLink": return LinkNotFound.DeserializeLinkNotFound(element);
                }
            }
            string reason = default;
            string whatNotFound = default;
            string someBaseProp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("whatNotFound"))
                {
                    whatNotFound = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("someBaseProp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    someBaseProp = property.Value.GetString();
                    continue;
                }
            }
            return new NotFoundErrorBase(someBaseProp, reason, whatNotFound);
        }
    }
}

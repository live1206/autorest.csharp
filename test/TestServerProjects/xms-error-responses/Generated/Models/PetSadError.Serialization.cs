// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace xms_error_responses.Models
{
    internal partial class PetSadError
    {
        internal static PetSadError DeserializePetSadError(JsonElement element)
        {
            if (element.TryGetProperty("errorType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "PetHungryOrThirstyError": return PetHungryOrThirstyError.DeserializePetHungryOrThirstyError(element);
                }
            }
            string reason = default;
            string errorType = default;
            string errorMessage = default;
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
                if (property.NameEquals("errorType"))
                {
                    errorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new PetSadError(errorType, errorMessage, reason);
        }
    }
}

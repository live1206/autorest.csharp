// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> The check availability request body. </summary>
    [PropertyReferenceType]
    public partial class CheckNameAvailabilityRequest
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityRequest. </summary>
        [InitializationConstructor]
        public CheckNameAvailabilityRequest()
        {
        }

        /// <summary> Initializes a new instance of CheckNameAvailabilityRequest. </summary>
        /// <param name="name"> The name of the resource for which availability needs to be checked. </param>
        /// <param name="type"> The resource type. </param>
        [SerializationConstructor]
        internal CheckNameAvailabilityRequest(string name, ResourceType type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public ResourceType Type { get; set; }
    }
}
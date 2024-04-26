// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using MgmtReferenceTypes;

[assembly: CodeGenSuppressType("TrackedResource")]
namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'. </summary>
    [ReferenceType]
    public abstract partial class TrackedResource : MgmtReferenceTypesResourceDataContent
    {
        /// <summary> Initializes a new instance of <see cref="TrackedResource"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        [InitializationConstructor]
        protected TrackedResource(AzureLocation location)
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="TrackedResource"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        [SerializationConstructor]
        protected TrackedResource(ResourceIdentifier id, string name, ResourceType resourceType, IDictionary<string, string> tags, AzureLocation location) : base(id, name, resourceType)
        {
            Tags = tags;
            Location = location;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation Location { get; set; }
    }
}

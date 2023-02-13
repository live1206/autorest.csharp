// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtParent;

namespace MgmtParent.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtParentModelFactory
    {
        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="bar"> specifies the bar. </param>
        /// <returns> A new <see cref="MgmtParent.AvailabilitySetData"/> instance for mocking. </returns>
        public static AvailabilitySetData AvailabilitySetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string bar = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AvailabilitySetData(id, name, resourceType, systemData, tags, location, bar);
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        /// <returns> A new <see cref="MgmtParent.DedicatedHostGroupData"/> instance for mocking. </returns>
        public static DedicatedHostGroupData DedicatedHostGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string foo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DedicatedHostGroupData(id, name, resourceType, systemData, tags, location, foo);
        }

        /// <summary> Initializes a new instance of DedicatedHostData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        /// <returns> A new <see cref="MgmtParent.DedicatedHostData"/> instance for mocking. </returns>
        public static DedicatedHostData DedicatedHostData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string foo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DedicatedHostData(id, name, resourceType, systemData, tags, location, foo);
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="bar"> specifies the bar. </param>
        /// <returns> A new <see cref="MgmtParent.VirtualMachineExtensionImageData"/> instance for mocking. </returns>
        public static VirtualMachineExtensionImageData VirtualMachineExtensionImageData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string bar = null)
        {
            tags ??= new Dictionary<string, string>();

            return new VirtualMachineExtensionImageData(id, name, resourceType, systemData, tags, location, bar);
        }
    }
}
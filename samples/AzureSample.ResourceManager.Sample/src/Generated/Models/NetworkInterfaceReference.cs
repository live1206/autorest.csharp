// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes a network interface reference.
    /// Serialized Name: NetworkInterfaceReference
    /// </summary>
    public partial class NetworkInterfaceReference : SubResource
    {
        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceReference"/>. </summary>
        public NetworkInterfaceReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceReference"/>. </summary>
        /// <param name="id">
        /// Resource Id
        /// Serialized Name: SubResource.id
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primary">
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// Serialized Name: NetworkInterfaceReference.properties.primary
        /// </param>
        internal NetworkInterfaceReference(string id, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? primary) : base(id, serializedAdditionalRawData)
        {
            Primary = primary;
        }

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// Serialized Name: NetworkInterfaceReference.properties.primary
        /// </summary>
        [WirePath("properties.primary")]
        public bool? Primary { get; set; }
    }
}

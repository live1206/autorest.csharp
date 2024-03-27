// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Specifies a list of virtual machine instance IDs from the VM scale set.
    /// Serialized Name: VirtualMachineScaleSetVMInstanceIDs
    /// </summary>
    public partial class VirtualMachineScaleSetVmInstanceIds
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceIds"/>. </summary>
        public VirtualMachineScaleSetVmInstanceIds()
        {
            InstanceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceIds"/>. </summary>
        /// <param name="instanceIds">
        /// The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetVMInstanceIDs.instanceIds
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmInstanceIds(IList<string> instanceIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceIds = instanceIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetVMInstanceIDs.instanceIds
        /// </summary>
        [WirePath("instanceIds")]
        public IList<string> InstanceIds { get; }
    }
}

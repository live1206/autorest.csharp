// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes a storage profile.
    /// Serialized Name: ImageStorageProfile
    /// </summary>
    public partial class ImageStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="ImageStorageProfile"/>. </summary>
        public ImageStorageProfile()
        {
            DataDisks = new ChangeTrackingList<ImageDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="ImageStorageProfile"/>. </summary>
        /// <param name="osDisk">
        /// Specifies information about the operating system disk used by the virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// Serialized Name: ImageStorageProfile.osDisk
        /// </param>
        /// <param name="dataDisks">
        /// Specifies the parameters that are used to add a data disk to a virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// Serialized Name: ImageStorageProfile.dataDisks
        /// </param>
        /// <param name="zoneResilient">
        /// Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage (ZRS).
        /// Serialized Name: ImageStorageProfile.zoneResilient
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageStorageProfile(ImageOSDisk osDisk, IList<ImageDataDisk> dataDisks, bool? zoneResilient, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSDisk = osDisk;
            DataDisks = dataDisks;
            ZoneResilient = zoneResilient;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Specifies information about the operating system disk used by the virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// Serialized Name: ImageStorageProfile.osDisk
        /// </summary>
        [WirePath("osDisk")]
        public ImageOSDisk OSDisk { get; set; }
        /// <summary>
        /// Specifies the parameters that are used to add a data disk to a virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// Serialized Name: ImageStorageProfile.dataDisks
        /// </summary>
        [WirePath("dataDisks")]
        public IList<ImageDataDisk> DataDisks { get; }
        /// <summary>
        /// Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage (ZRS).
        /// Serialized Name: ImageStorageProfile.zoneResilient
        /// </summary>
        [WirePath("zoneResilient")]
        public bool? ZoneResilient { get; set; }
    }
}

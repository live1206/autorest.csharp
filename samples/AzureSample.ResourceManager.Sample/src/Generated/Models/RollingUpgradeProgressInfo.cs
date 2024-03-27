// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Information about the number of virtual machine instances in each upgrade state.
    /// Serialized Name: RollingUpgradeProgressInfo
    /// </summary>
    public partial class RollingUpgradeProgressInfo
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

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeProgressInfo"/>. </summary>
        internal RollingUpgradeProgressInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeProgressInfo"/>. </summary>
        /// <param name="successfulInstanceCount">
        /// The number of instances that have been successfully upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.successfulInstanceCount
        /// </param>
        /// <param name="failedInstanceCount">
        /// The number of instances that have failed to be upgraded successfully.
        /// Serialized Name: RollingUpgradeProgressInfo.failedInstanceCount
        /// </param>
        /// <param name="inProgressInstanceCount">
        /// The number of instances that are currently being upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.inProgressInstanceCount
        /// </param>
        /// <param name="pendingInstanceCount">
        /// The number of instances that have not yet begun to be upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.pendingInstanceCount
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RollingUpgradeProgressInfo(int? successfulInstanceCount, int? failedInstanceCount, int? inProgressInstanceCount, int? pendingInstanceCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SuccessfulInstanceCount = successfulInstanceCount;
            FailedInstanceCount = failedInstanceCount;
            InProgressInstanceCount = inProgressInstanceCount;
            PendingInstanceCount = pendingInstanceCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The number of instances that have been successfully upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.successfulInstanceCount
        /// </summary>
        [WirePath("successfulInstanceCount")]
        public int? SuccessfulInstanceCount { get; }
        /// <summary>
        /// The number of instances that have failed to be upgraded successfully.
        /// Serialized Name: RollingUpgradeProgressInfo.failedInstanceCount
        /// </summary>
        [WirePath("failedInstanceCount")]
        public int? FailedInstanceCount { get; }
        /// <summary>
        /// The number of instances that are currently being upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.inProgressInstanceCount
        /// </summary>
        [WirePath("inProgressInstanceCount")]
        public int? InProgressInstanceCount { get; }
        /// <summary>
        /// The number of instances that have not yet begun to be upgraded.
        /// Serialized Name: RollingUpgradeProgressInfo.pendingInstanceCount
        /// </summary>
        [WirePath("pendingInstanceCount")]
        public int? PendingInstanceCount { get; }
    }
}

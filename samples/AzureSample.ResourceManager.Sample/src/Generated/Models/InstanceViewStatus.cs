// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureSample.ResourceManager.Sample.Models
{
    /// <summary>
    /// Instance view status.
    /// Serialized Name: InstanceViewStatus
    /// </summary>
    public partial class InstanceViewStatus
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

        /// <summary> Initializes a new instance of <see cref="InstanceViewStatus"/>. </summary>
        public InstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InstanceViewStatus"/>. </summary>
        /// <param name="code">
        /// The status code.
        /// Serialized Name: InstanceViewStatus.code
        /// </param>
        /// <param name="level">
        /// The level code.
        /// Serialized Name: InstanceViewStatus.level
        /// </param>
        /// <param name="displayStatus">
        /// The short localizable label for the status.
        /// Serialized Name: InstanceViewStatus.displayStatus
        /// </param>
        /// <param name="message">
        /// The detailed status message, including for alerts and error messages.
        /// Serialized Name: InstanceViewStatus.message
        /// </param>
        /// <param name="time">
        /// The time of the status.
        /// Serialized Name: InstanceViewStatus.time
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstanceViewStatus(string code, StatusLevelType? level, string displayStatus, string message, DateTimeOffset? time, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The status code.
        /// Serialized Name: InstanceViewStatus.code
        /// </summary>
        [WirePath("code")]
        public string Code { get; set; }
        /// <summary>
        /// The level code.
        /// Serialized Name: InstanceViewStatus.level
        /// </summary>
        [WirePath("level")]
        public StatusLevelType? Level { get; set; }
        /// <summary>
        /// The short localizable label for the status.
        /// Serialized Name: InstanceViewStatus.displayStatus
        /// </summary>
        [WirePath("displayStatus")]
        public string DisplayStatus { get; set; }
        /// <summary>
        /// The detailed status message, including for alerts and error messages.
        /// Serialized Name: InstanceViewStatus.message
        /// </summary>
        [WirePath("message")]
        public string Message { get; set; }
        /// <summary>
        /// The time of the status.
        /// Serialized Name: InstanceViewStatus.time
        /// </summary>
        [WirePath("time")]
        public DateTimeOffset? Time { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type._Dictionary.Models
{
    /// <summary> Dictionary inner model. </summary>
    public partial class InnerModel
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

        /// <summary> Initializes a new instance of <see cref="InnerModel"/>. </summary>
        /// <param name="property"> Required string property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="property"/> is null. </exception>
        public InnerModel(string property)
        {
            Argument.AssertNotNull(property, nameof(property));

            Property = property;
            Children = new ChangeTrackingDictionary<string, InnerModel>();
        }

        /// <summary> Initializes a new instance of <see cref="InnerModel"/>. </summary>
        /// <param name="property"> Required string property. </param>
        /// <param name="children"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InnerModel(string property, IDictionary<string, InnerModel> children, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Property = property;
            Children = children;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InnerModel"/> for deserialization. </summary>
        internal InnerModel()
        {
        }

        /// <summary> Required string property. </summary>
        public string Property { get; set; }
        /// <summary> Gets the children. </summary>
        public IDictionary<string, InnerModel> Children { get; }
    }
}

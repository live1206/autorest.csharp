// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The ChatCompletionResponseMessageFunctionCall. </summary>
    public partial class ChatCompletionResponseMessageFunctionCall
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

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessageFunctionCall"/>. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <param name="arguments">
        /// The arguments to call the function with, as generated by the model in JSON format. Note that
        /// the model does not always generate valid JSON, and may hallucinate parameters not defined by
        /// your function schema. Validate the arguments in your code before calling your function.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="arguments"/> is null. </exception>
        internal ChatCompletionResponseMessageFunctionCall(string name, string arguments)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Name = name;
            Arguments = arguments;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessageFunctionCall"/>. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <param name="arguments">
        /// The arguments to call the function with, as generated by the model in JSON format. Note that
        /// the model does not always generate valid JSON, and may hallucinate parameters not defined by
        /// your function schema. Validate the arguments in your code before calling your function.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionResponseMessageFunctionCall(string name, string arguments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Arguments = arguments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessageFunctionCall"/> for deserialization. </summary>
        internal ChatCompletionResponseMessageFunctionCall()
        {
        }

        /// <summary> The name of the function to call. </summary>
        public string Name { get; }
        /// <summary>
        /// The arguments to call the function with, as generated by the model in JSON format. Note that
        /// the model does not always generate valid JSON, and may hallucinate parameters not defined by
        /// your function schema. Validate the arguments in your code before calling your function.
        /// </summary>
        public string Arguments { get; }
    }
}

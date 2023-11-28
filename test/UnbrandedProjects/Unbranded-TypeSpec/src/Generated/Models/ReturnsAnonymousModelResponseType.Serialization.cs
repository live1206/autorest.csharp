// <auto-generated/>

#nullable disable

using System.Net.ClientModel.Core;
using System.Text.Json;

namespace UnbrandedTypeSpec.Models
{
    public partial class ReturnsAnonymousModelResponseType
    {
        internal static ReturnsAnonymousModelResponseType DeserializeReturnsAnonymousModelResponseType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            foreach (var property in element.EnumerateObject())
            {
            }
            return new ReturnsAnonymousModelResponseType();
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ReturnsAnonymousModelResponseType FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReturnsAnonymousModelResponseType(document.RootElement);
        }
    }
}
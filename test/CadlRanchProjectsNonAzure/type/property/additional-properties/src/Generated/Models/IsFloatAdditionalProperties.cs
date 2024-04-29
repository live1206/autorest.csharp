// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The model is from Record&lt;float32&gt; type. </summary>
    public partial class IsFloatAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="IsFloatAdditionalProperties"/>. </summary>
        /// <param name="id"> The id property. </param>
        public IsFloatAdditionalProperties(float id)
        {
            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, float>();
        }

        /// <summary> Initializes a new instance of <see cref="IsFloatAdditionalProperties"/>. </summary>
        /// <param name="id"> The id property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IsFloatAdditionalProperties(float id, IDictionary<string, float> additionalProperties)
        {
            Id = id;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="IsFloatAdditionalProperties"/> for deserialization. </summary>
        internal IsFloatAdditionalProperties()
        {
        }

        /// <summary> The id property. </summary>
        public float Id { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, float> AdditionalProperties { get; }
    }
}

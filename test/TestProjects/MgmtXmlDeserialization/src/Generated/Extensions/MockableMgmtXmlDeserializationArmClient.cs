// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtXmlDeserialization.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtXmlDeserializationArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtXmlDeserializationArmClient"/> class for mocking. </summary>
        protected MockableMgmtXmlDeserializationArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtXmlDeserializationArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtXmlDeserializationArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtXmlDeserializationArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="XmlInstanceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="XmlInstanceResource.CreateResourceIdentifier" /> to create a <see cref="XmlInstanceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="XmlInstanceResource"/> object. </returns>
        public virtual XmlInstanceResource GetXmlInstanceResource(ResourceIdentifier id)
        {
            XmlInstanceResource.ValidateResourceId(id);
            return new XmlInstanceResource(Client, id);
        }
    }
}

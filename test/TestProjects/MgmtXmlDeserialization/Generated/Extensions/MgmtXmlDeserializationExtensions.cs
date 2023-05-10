// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtXmlDeserialization
{
    /// <summary> A class to add extension methods to MgmtXmlDeserialization. </summary>
    public static partial class MgmtXmlDeserializationExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }
        #region XmlInstanceResource
        /// <summary>
        /// Gets an object representing a <see cref="XmlInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="XmlInstanceResource.CreateResourceIdentifier" /> to create a <see cref="XmlInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="XmlInstanceResource" /> object. </returns>
        public static XmlInstanceResource GetXmlInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                XmlInstanceResource.ValidateResourceId(id);
                return new XmlInstanceResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of XmlInstanceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of XmlInstanceResources and their operations over a XmlInstanceResource. </returns>
        public static XmlInstanceCollection GetXmlInstances(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetXmlInstances();
        }

        /// <summary>
        /// Gets the details of the Xml specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.XmlDeserialization/xmls/{xmlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>XmlDeserialization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="xmlName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="xmlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="xmlName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<XmlInstanceResource>> GetXmlInstanceAsync(this ResourceGroupResource resourceGroupResource, string xmlName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetXmlInstances().GetAsync(xmlName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the Xml specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.XmlDeserialization/xmls/{xmlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>XmlDeserialization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="xmlName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="xmlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="xmlName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<XmlInstanceResource> GetXmlInstance(this ResourceGroupResource resourceGroupResource, string xmlName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetXmlInstances().Get(xmlName, cancellationToken);
        }
    }
}
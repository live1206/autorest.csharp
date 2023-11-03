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
using MgmtSingletonResource.Mocking;

namespace MgmtSingletonResource
{
    /// <summary> A class to add extension methods to MgmtSingletonResource. </summary>
    public static partial class MgmtSingletonResourceExtensions
    {
        private static MockableMgmtSingletonResourceArmClient GetMockableMgmtSingletonResourceArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableMgmtSingletonResourceArmClient(client0));
        }

        private static MockableMgmtSingletonResourceResourceGroupResource GetMockableMgmtSingletonResourceResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMgmtSingletonResourceResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="CarResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CarResource.CreateResourceIdentifier" /> to create a <see cref="CarResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceArmClient.GetCarResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CarResource" /> object. </returns>
        public static CarResource GetCarResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtSingletonResourceArmClient(client).GetCarResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IgnitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IgnitionResource.CreateResourceIdentifier" /> to create an <see cref="IgnitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceArmClient.GetIgnitionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IgnitionResource" /> object. </returns>
        public static IgnitionResource GetIgnitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtSingletonResourceArmClient(client).GetIgnitionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BrakeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BrakeResource.CreateResourceIdentifier" /> to create a <see cref="BrakeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceArmClient.GetBrakeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BrakeResource" /> object. </returns>
        public static BrakeResource GetBrakeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtSingletonResourceArmClient(client).GetBrakeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SingletonResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SingletonResource.CreateResourceIdentifier" /> to create a <see cref="SingletonResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceArmClient.GetSingletonResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonResource" /> object. </returns>
        public static SingletonResource GetSingletonResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtSingletonResourceArmClient(client).GetSingletonResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ParentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ParentResource.CreateResourceIdentifier" /> to create a <see cref="ParentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceArmClient.GetParentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ParentResource" /> object. </returns>
        public static ParentResource GetParentResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtSingletonResourceArmClient(client).GetParentResource(id);
        }

        /// <summary>
        /// Gets a collection of CarResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetCars()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of CarResources and their operations over a CarResource. </returns>
        public static CarCollection GetCars(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetCars();
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cars_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetCarAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="carName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CarResource>> GetCarAsync(this ResourceGroupResource resourceGroupResource, string carName, CancellationToken cancellationToken = default)
        {
            return await GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetCarAsync(carName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cars_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetCar(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="carName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CarResource> GetCar(this ResourceGroupResource resourceGroupResource, string carName, CancellationToken cancellationToken = default)
        {
            return GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetCar(carName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of ParentResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetParentResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ParentResources and their operations over a ParentResource. </returns>
        public static ParentResourceCollection GetParentResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetParentResources();
        }

        /// <summary>
        /// Singleton Test Parent Example.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Billing/parentResources/{parentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ParentResources_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetParentResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ParentResource>> GetParentResourceAsync(this ResourceGroupResource resourceGroupResource, string parentName, CancellationToken cancellationToken = default)
        {
            return await GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetParentResourceAsync(parentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Singleton Test Parent Example.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Billing/parentResources/{parentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ParentResources_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtSingletonResourceResourceGroupResource.GetParentResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ParentResource> GetParentResource(this ResourceGroupResource resourceGroupResource, string parentName, CancellationToken cancellationToken = default)
        {
            return GetMockableMgmtSingletonResourceResourceGroupResource(resourceGroupResource).GetParentResource(parentName, cancellationToken);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sample
{
    /// <summary>
    /// A class representing a collection of <see cref="AvailabilitySetResource" /> and their operations.
    /// Each <see cref="AvailabilitySetResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AvailabilitySetCollection" /> instance call the GetAvailabilitySets method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AvailabilitySetCollection : ArmCollection, IEnumerable<AvailabilitySetResource>, IAsyncEnumerable<AvailabilitySetResource>
    {
        private readonly ClientDiagnostics _availabilitySetClientDiagnostics;
        private readonly AvailabilitySetsRestOperations _availabilitySetRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetCollection"/> class for mocking. </summary>
        protected AvailabilitySetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvailabilitySetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _availabilitySetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sample", AvailabilitySetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvailabilitySetResource.ResourceType, out string availabilitySetApiVersion);
            _availabilitySetRestClient = new AvailabilitySetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, availabilitySetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="data"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AvailabilitySetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string availabilitySetName, AvailabilitySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _availabilitySetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SampleArmOperation<AvailabilitySetResource>(Response.FromValue(new AvailabilitySetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="data"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AvailabilitySetResource> CreateOrUpdate(WaitUntil waitUntil, string availabilitySetName, AvailabilitySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _availabilitySetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data, cancellationToken);
                var operation = new SampleArmOperation<AvailabilitySetResource>(Response.FromValue(new AvailabilitySetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<Response<AvailabilitySetResource>> GetAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = await _availabilitySetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<AvailabilitySetResource> Get(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = _availabilitySetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all availability sets in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailabilitySetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _availabilitySetRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _availabilitySetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvailabilitySetResource(Client, AvailabilitySetData.DeserializeAvailabilitySetData(e)), _availabilitySetClientDiagnostics, Pipeline, "AvailabilitySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all availability sets in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailabilitySetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _availabilitySetRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _availabilitySetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvailabilitySetResource(Client, AvailabilitySetData.DeserializeAvailabilitySetData(e)), _availabilitySetClientDiagnostics, Pipeline, "AvailabilitySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _availabilitySetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = _availabilitySetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<NullableResponse<AvailabilitySetResource>> GetIfExistsAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _availabilitySetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AvailabilitySetResource>(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual NullableResponse<AvailabilitySetResource> GetIfExists(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _availabilitySetClientDiagnostics.CreateScope("AvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _availabilitySetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AvailabilitySetResource>(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvailabilitySetResource> IEnumerable<AvailabilitySetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvailabilitySetResource> IAsyncEnumerable<AvailabilitySetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

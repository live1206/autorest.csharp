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

namespace MgmtSupersetInheritance
{
    /// <summary>
    /// A class representing a collection of <see cref="SupersetModel7Resource" /> and their operations.
    /// Each <see cref="SupersetModel7Resource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SupersetModel7Collection" /> instance call the GetSupersetModel7s method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SupersetModel7Collection : ArmCollection, IEnumerable<SupersetModel7Resource>, IAsyncEnumerable<SupersetModel7Resource>
    {
        private readonly ClientDiagnostics _supersetModel7ClientDiagnostics;
        private readonly SupersetModel7SRestOperations _supersetModel7RestClient;

        /// <summary> Initializes a new instance of the <see cref="SupersetModel7Collection"/> class for mocking. </summary>
        protected SupersetModel7Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupersetModel7Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupersetModel7Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supersetModel7ClientDiagnostics = new ClientDiagnostics("MgmtSupersetInheritance", SupersetModel7Resource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupersetModel7Resource.ResourceType, out string supersetModel7ApiVersion);
            _supersetModel7RestClient = new SupersetModel7SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supersetModel7ApiVersion);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="data"> The SupersetModel7Data to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupersetModel7Resource>> CreateOrUpdateAsync(WaitUntil waitUntil, string supersetModel7SName, SupersetModel7Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _supersetModel7RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSupersetInheritanceArmOperation<SupersetModel7Resource>(Response.FromValue(new SupersetModel7Resource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="data"> The SupersetModel7Data to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupersetModel7Resource> CreateOrUpdate(WaitUntil waitUntil, string supersetModel7SName, SupersetModel7Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _supersetModel7RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, data, cancellationToken);
                var operation = new MgmtSupersetInheritanceArmOperation<SupersetModel7Resource>(Response.FromValue(new SupersetModel7Resource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual async Task<Response<SupersetModel7Resource>> GetAsync(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.Get");
            scope.Start();
            try
            {
                var response = await _supersetModel7RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel7Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual Response<SupersetModel7Resource> Get(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.Get");
            scope.Start();
            try
            {
                var response = _supersetModel7RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel7Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupersetModel7Resource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupersetModel7Resource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _supersetModel7RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SupersetModel7Resource(Client, SupersetModel7Data.DeserializeSupersetModel7Data(e)), _supersetModel7ClientDiagnostics, Pipeline, "SupersetModel7Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupersetModel7Resource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupersetModel7Resource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _supersetModel7RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SupersetModel7Resource(Client, SupersetModel7Data.DeserializeSupersetModel7Data(e)), _supersetModel7ClientDiagnostics, Pipeline, "SupersetModel7Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.Exists");
            scope.Start();
            try
            {
                var response = await _supersetModel7RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual Response<bool> Exists(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.Exists");
            scope.Start();
            try
            {
                var response = _supersetModel7RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual async Task<NullableResponse<SupersetModel7Resource>> GetIfExistsAsync(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _supersetModel7RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SupersetModel7Resource>(response.GetRawResponse());
                return Response.FromValue(new SupersetModel7Resource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        public virtual NullableResponse<SupersetModel7Resource> GetIfExists(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel7SName, nameof(supersetModel7SName));

            using var scope = _supersetModel7ClientDiagnostics.CreateScope("SupersetModel7Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _supersetModel7RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel7SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SupersetModel7Resource>(response.GetRawResponse());
                return Response.FromValue(new SupersetModel7Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupersetModel7Resource> IEnumerable<SupersetModel7Resource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupersetModel7Resource> IAsyncEnumerable<SupersetModel7Resource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

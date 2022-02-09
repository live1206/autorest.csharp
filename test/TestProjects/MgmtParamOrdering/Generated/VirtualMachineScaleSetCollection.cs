// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of VirtualMachineScaleSet and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetCollection : ArmCollection, IEnumerable<VirtualMachineScaleSet>, IAsyncEnumerable<VirtualMachineScaleSet>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetClientDiagnostics;
        private readonly VirtualMachineScaleSetsRestOperations _virtualMachineScaleSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetClientDiagnostics = new ClientDiagnostics("MgmtParamOrdering", VirtualMachineScaleSet.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VirtualMachineScaleSet.ResourceType, out string virtualMachineScaleSetApiVersion);
            _virtualMachineScaleSetRestClient = new VirtualMachineScaleSetsRestOperations(_virtualMachineScaleSetClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineScaleSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_CreateOrUpdate
        /// <summary> required body, required header;Create or update a VM scale set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set to create or update. </param>
        /// <param name="parameters"> The scale set object. </param>
        /// <param name="quick"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<VirtualMachineScaleSet>> CreateOrUpdateAsync(bool waitForCompletion, string vmScaleSetName, VirtualMachineScaleSetData parameters, string quick = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, quick, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation<VirtualMachineScaleSet>(new VirtualMachineScaleSetOperationSource(Client), _virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, quick).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_CreateOrUpdate
        /// <summary> required body, required header;Create or update a VM scale set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set to create or update. </param>
        /// <param name="parameters"> The scale set object. </param>
        /// <param name="quick"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSet> CreateOrUpdate(bool waitForCompletion, string vmScaleSetName, VirtualMachineScaleSetData parameters, string quick = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, quick, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation<VirtualMachineScaleSet>(new VirtualMachineScaleSetOperationSource(Client), _virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, quick).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Display information about a virtual machine scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> GetAsync(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualMachineScaleSetClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Display information about a virtual machine scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> Get(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualMachineScaleSetClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_List
        /// <summary> Gets a list of all VM scale sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_List
        /// <summary> Gets a list of all VM scale sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmScaleSetName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmScaleSetName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> GetIfExistsAsync(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSet>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> GetIfExists(string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmScaleSetName, nameof(vmScaleSetName));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSet>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSet> IEnumerable<VirtualMachineScaleSet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSet> IAsyncEnumerable<VirtualMachineScaleSet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
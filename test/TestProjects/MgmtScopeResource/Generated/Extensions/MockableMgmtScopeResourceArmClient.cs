// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtScopeResource;
using MgmtScopeResource.Models;

namespace MgmtScopeResource.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtScopeResourceArmClient : ArmResource
    {
        private ClientDiagnostics _resourceLinkClientDiagnostics;
        private ResourceLinksRestOperations _resourceLinkRestClient;
        private ClientDiagnostics _marketplacesClientDiagnostics;
        private MarketplacesRestOperations _marketplacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtScopeResourceArmClient"/> class for mocking. </summary>
        protected MockableMgmtScopeResourceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtScopeResourceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtScopeResourceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtScopeResourceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private ClientDiagnostics ResourceLinkClientDiagnostics => _resourceLinkClientDiagnostics ??= new ClientDiagnostics("MgmtScopeResource", ResourceLinkResource.ResourceType.Namespace, Diagnostics);
        private ResourceLinksRestOperations ResourceLinkRestClient => _resourceLinkRestClient ??= new ResourceLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResourceLinkResource.ResourceType));
        private ClientDiagnostics MarketplacesClientDiagnostics => _marketplacesClientDiagnostics ??= new ClientDiagnostics("MgmtScopeResource", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MarketplacesRestOperations MarketplacesRestClient => _marketplacesRestClient ??= new MarketplacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of FakePolicyAssignmentResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of FakePolicyAssignmentResources and their operations over a FakePolicyAssignmentResource. </returns>
        public virtual FakePolicyAssignmentCollection GetFakePolicyAssignments(ResourceIdentifier scope)
        {
            return new FakePolicyAssignmentCollection(Client, scope);
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FakePolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FakePolicyAssignmentResource>> GetFakePolicyAssignmentAsync(ResourceIdentifier scope, string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return await GetFakePolicyAssignments(scope).GetAsync(policyAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FakePolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<FakePolicyAssignmentResource> GetFakePolicyAssignment(ResourceIdentifier scope, string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return GetFakePolicyAssignments(scope).Get(policyAssignmentName, cancellationToken);
        }

        /// <summary> Gets an object representing a VMInsightsOnboardingStatusResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> Returns a <see cref="VMInsightsOnboardingStatusResource"/> object. </returns>
        public virtual VMInsightsOnboardingStatusResource GetVMInsightsOnboardingStatus(ResourceIdentifier scope)
        {
            return new VMInsightsOnboardingStatusResource(Client, scope.AppendProviderResource("Microsoft.Insights", "vmInsightsOnboardingStatuses", "default"));
        }

        /// <summary> Gets a collection of GuestConfigurationAssignmentResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of GuestConfigurationAssignmentResources and their operations over a GuestConfigurationAssignmentResource. </returns>
        public virtual GuestConfigurationAssignmentCollection GetGuestConfigurationAssignments(ResourceIdentifier scope)
        {
            if (!scope.ResourceType.Equals("Microsoft.Compute/virtualMachines"))
            {
                throw new ArgumentException(string.Format("Invalid resource type {0}, expected Microsoft.Compute/virtualMachines", scope.ResourceType));
            }
            return new GuestConfigurationAssignmentCollection(Client, scope);
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<GuestConfigurationAssignmentResource>> GetGuestConfigurationAssignmentAsync(ResourceIdentifier scope, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            return await GetGuestConfigurationAssignments(scope).GetAsync(guestConfigurationAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuestConfigurationAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignment(ResourceIdentifier scope, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            return GetGuestConfigurationAssignments(scope).Get(guestConfigurationAssignmentName, cancellationToken);
        }

        /// <summary>
        /// Gets a list of resource links at and below the specified source scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceLinks_ListAtSourceScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply when getting resource links. To get links only at the specified scope (not below the scope), use Filter.atScope(). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceLinkResource> GetAllAsync(ResourceIdentifier scope, Filter? filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            Azure.Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceLinkRestClient.CreateListAtSourceScopeRequest(scope, filter);
            Azure.Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceLinkRestClient.CreateListAtSourceScopeNextPageRequest(nextLink, scope, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceLinkResource(Client, ResourceLinkData.DeserializeResourceLinkData(e)), ResourceLinkClientDiagnostics, Pipeline, "MockableMgmtScopeResourceArmClient.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of resource links at and below the specified source scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceLinks_ListAtSourceScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> The filter to apply when getting resource links. To get links only at the specified scope (not below the scope), use Filter.atScope(). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceLinkResource> GetAll(ResourceIdentifier scope, Filter? filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            Azure.Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceLinkRestClient.CreateListAtSourceScopeRequest(scope, filter);
            Azure.Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceLinkRestClient.CreateListAtSourceScopeNextPageRequest(nextLink, scope, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceLinkResource(Client, ResourceLinkData.DeserializeResourceLinkData(e)), ResourceLinkClientDiagnostics, Pipeline, "MockableMgmtScopeResourceArmClient.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the marketplaces for a scope at the defined scope. Marketplaces are available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/marketplaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Marketplaces_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> May be used to filter marketplaces by properties/usageEnd (Utc time), properties/usageStart (Utc time), properties/resourceGroup, properties/instanceName or properties/instanceId. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N marketplaces. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="Marketplace"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Marketplace> GetMarketplacesAsync(ResourceIdentifier scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            Azure.Core.HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplacesRestClient.CreateListRequest(scope, filter, top, skiptoken);
            Azure.Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplacesRestClient.CreateListNextPageRequest(nextLink, scope, filter, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Marketplace.DeserializeMarketplace, MarketplacesClientDiagnostics, Pipeline, "MockableMgmtScopeResourceArmClient.GetMarketplaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the marketplaces for a scope at the defined scope. Marketplaces are available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/marketplaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Marketplaces_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> May be used to filter marketplaces by properties/usageEnd (Utc time), properties/usageStart (Utc time), properties/resourceGroup, properties/instanceName or properties/instanceId. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N marketplaces. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="Marketplace"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Marketplace> GetMarketplaces(ResourceIdentifier scope, string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            Azure.Core.HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplacesRestClient.CreateListRequest(scope, filter, top, skiptoken);
            Azure.Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplacesRestClient.CreateListNextPageRequest(nextLink, scope, filter, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Marketplace.DeserializeMarketplace, MarketplacesClientDiagnostics, Pipeline, "MockableMgmtScopeResourceArmClient.GetMarketplaces", "value", "nextLink", cancellationToken);
        }
        /// <summary>
        /// Gets an object representing a <see cref="FakePolicyAssignmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FakePolicyAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="FakePolicyAssignmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FakePolicyAssignmentResource"/> object. </returns>
        public virtual FakePolicyAssignmentResource GetFakePolicyAssignmentResource(ResourceIdentifier id)
        {
            FakePolicyAssignmentResource.ValidateResourceId(id);
            return new FakePolicyAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeploymentExtendedResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeploymentExtendedResource.CreateResourceIdentifier" /> to create a <see cref="DeploymentExtendedResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedResource"/> object. </returns>
        public virtual DeploymentExtendedResource GetDeploymentExtendedResource(ResourceIdentifier id)
        {
            DeploymentExtendedResource.ValidateResourceId(id);
            return new DeploymentExtendedResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceLinkResource.CreateResourceIdentifier" /> to create a <see cref="ResourceLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceLinkResource"/> object. </returns>
        public virtual ResourceLinkResource GetResourceLinkResource(ResourceIdentifier id)
        {
            ResourceLinkResource.ValidateResourceId(id);
            return new ResourceLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VMInsightsOnboardingStatusResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VMInsightsOnboardingStatusResource.CreateResourceIdentifier" /> to create a <see cref="VMInsightsOnboardingStatusResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMInsightsOnboardingStatusResource"/> object. </returns>
        public virtual VMInsightsOnboardingStatusResource GetVMInsightsOnboardingStatusResource(ResourceIdentifier id)
        {
            VMInsightsOnboardingStatusResource.ValidateResourceId(id);
            return new VMInsightsOnboardingStatusResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GuestConfigurationAssignmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GuestConfigurationAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="GuestConfigurationAssignmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GuestConfigurationAssignmentResource"/> object. </returns>
        public virtual GuestConfigurationAssignmentResource GetGuestConfigurationAssignmentResource(ResourceIdentifier id)
        {
            GuestConfigurationAssignmentResource.ValidateResourceId(id);
            return new GuestConfigurationAssignmentResource(Client, id);
        }
    }
}

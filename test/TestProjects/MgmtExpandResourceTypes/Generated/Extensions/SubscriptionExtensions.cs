// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtExpandResourceTypes.Models;

namespace MgmtExpandResourceTypes
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static ZonesRestOperations GetZonesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new ZonesRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        private static DnsResourceReferenceRestOperations GetDnsResourceReferenceRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new DnsResourceReferenceRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Zones_List
        /// <summary> Lists the Zones for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Zone> GetZonesByDnszoneAsync(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(Zone.ResourceType, out string apiVersion);
                ZonesRestOperations restOperations = GetZonesRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                async Task<Page<Zone>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetZonesByDnszone");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(subscription.Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Zone(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Zone>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetZonesByDnszone");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, subscription.Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Zone(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Zones_List
        /// <summary> Lists the Zones for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Zone> GetZonesByDnszone(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(Zone.ResourceType, out string apiVersion);
                ZonesRestOperations restOperations = GetZonesRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                Page<Zone> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetZonesByDnszone");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(subscription.Id.SubscriptionId, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Zone(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Zone> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetZonesByDnszone");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, subscription.Id.SubscriptionId, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Zone(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of Zones for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetZonesAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Zone.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Zones for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetZonesAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Zone.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DnsResourceReference_GetByTargetResources
        /// <summary> Returns the DNS records specified by the referencing targetResourceIds. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<DnsResourceReferenceResult>> GetByTargetResourcesDnsResourceReferenceAsync(this Subscription subscription, DnsResourceReferenceRequest parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetByTargetResourcesDnsResourceReference");
                scope.Start();
                try
                {
                    DnsResourceReferenceRestOperations restOperations = GetDnsResourceReferenceRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = await restOperations.GetByTargetResourcesAsync(subscription.Id.SubscriptionId, parameters, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DnsResourceReference_GetByTargetResources
        /// <summary> Returns the DNS records specified by the referencing targetResourceIds. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static Response<DnsResourceReferenceResult> GetByTargetResourcesDnsResourceReference(this Subscription subscription, DnsResourceReferenceRequest parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetByTargetResourcesDnsResourceReference");
                scope.Start();
                try
                {
                    DnsResourceReferenceRestOperations restOperations = GetDnsResourceReferenceRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = restOperations.GetByTargetResources(subscription.Id.SubscriptionId, parameters, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Client.Structure.Service.Multiple.Client;
using Client.Structure.Service.Multiple.Client.Models;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ClientAClient"/>, <see cref="ClientBClient"/> to client builder. </summary>
    public static partial class ClientStructureServiceMultipleClientClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ClientAClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        public static IAzureClientBuilder<ClientAClient, ClientStructureServiceMultipleClientOptions> AddClientAClient<TBuilder>(this TBuilder builder, Uri endpoint, ClientType client)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ClientAClient, ClientStructureServiceMultipleClientOptions>((options) => new ClientAClient(endpoint, client, options));
        }

        /// <summary> Registers a <see cref="ClientBClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        public static IAzureClientBuilder<ClientBClient, ClientStructureServiceMultipleClientOptions> AddClientBClient<TBuilder>(this TBuilder builder, Uri endpoint, ClientType client)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ClientBClient, ClientStructureServiceMultipleClientOptions>((options) => new ClientBClient(endpoint, client, options));
        }

        /// <summary> Registers a <see cref="ClientAClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ClientAClient, ClientStructureServiceMultipleClientOptions> AddClientAClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ClientAClient, ClientStructureServiceMultipleClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="ClientBClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ClientBClient, ClientStructureServiceMultipleClientOptions> AddClientBClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ClientBClient, ClientStructureServiceMultipleClientOptions>(configuration);
        }
    }
}

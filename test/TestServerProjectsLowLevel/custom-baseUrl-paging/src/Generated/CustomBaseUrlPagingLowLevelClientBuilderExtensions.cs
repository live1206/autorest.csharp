// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core.Extensions;
using custom_baseUrl_paging_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="PagingClient"/> to client builder. </summary>
    public static partial class CustomBaseUrlPagingLowLevelClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="PagingClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. The default value is "host". </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<PagingClient, PagingClientOptions> AddPagingClient<TBuilder>(this TBuilder builder, string host, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<PagingClient, PagingClientOptions>((options) => new PagingClient(host, credential, options));
        }

        /// <summary> Registers a <see cref="PagingClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<PagingClient, PagingClientOptions> AddPagingClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<PagingClient, PagingClientOptions>(configuration);
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Payload.MediaType;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="MediaTypeClient"/> to client builder. </summary>
    public static partial class PayloadMediaTypeClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="MediaTypeClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        public static IAzureClientBuilder<MediaTypeClient, MediaTypeClientOptions> AddMediaTypeClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<MediaTypeClient, MediaTypeClientOptions>((options) => new MediaTypeClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="MediaTypeClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<MediaTypeClient, MediaTypeClientOptions> AddMediaTypeClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<MediaTypeClient, MediaTypeClientOptions>(configuration);
        }
    }
}

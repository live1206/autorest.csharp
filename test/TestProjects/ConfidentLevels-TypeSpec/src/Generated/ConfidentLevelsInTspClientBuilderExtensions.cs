// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using ConfidentLevelsInTsp;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ConfidentLevelsInTspClient"/> to client builder. </summary>
    public static partial class ConfidentLevelsInTspClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ConfidentLevelsInTspClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        public static IAzureClientBuilder<ConfidentLevelsInTspClient, ConfidentLevelsInTspClientOptions> AddConfidentLevelsInTspClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ConfidentLevelsInTspClient, ConfidentLevelsInTspClientOptions>((options) => new ConfidentLevelsInTspClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="ConfidentLevelsInTspClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ConfidentLevelsInTspClient, ConfidentLevelsInTspClientOptions> AddConfidentLevelsInTspClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ConfidentLevelsInTspClient, ConfidentLevelsInTspClientOptions>(configuration);
        }
    }
}

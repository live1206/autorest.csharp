// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Parameters.Basic
{
    // Data plane generated client.
    /// <summary> Test for basic parameters cases. </summary>
    public partial class BasicClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of BasicClient. </summary>
        public BasicClient() : this(new Uri("http://localhost:3000"), new BasicClientOptions())
        {
        }

        /// <summary> Initializes a new instance of BasicClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public BasicClient(Uri endpoint, BasicClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new BasicClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private ExplicitBody _cachedExplicitBody;
        private ImplicitBody _cachedImplicitBody;

        /// <summary> Initializes a new instance of ExplicitBody. </summary>
        public virtual ExplicitBody GetExplicitBodyClient()
        {
            return Volatile.Read(ref _cachedExplicitBody) ?? Interlocked.CompareExchange(ref _cachedExplicitBody, new ExplicitBody(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedExplicitBody;
        }

        /// <summary> Initializes a new instance of ImplicitBody. </summary>
        public virtual ImplicitBody GetImplicitBodyClient()
        {
            return Volatile.Read(ref _cachedImplicitBody) ?? Interlocked.CompareExchange(ref _cachedImplicitBody, new ImplicitBody(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedImplicitBody;
        }
    }
}
// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm.SpecialWords
{
    // Data plane generated client.
    /// <summary> The SpecialWords service client. </summary>
    public partial class SpecialWordsClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SpecialWordsClient. </summary>
        public SpecialWordsClient() : this(new Uri("http://localhost:3000"), new SpecialWordsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SpecialWordsClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpecialWordsClient(Uri endpoint, SpecialWordsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SpecialWordsClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private ModelsOps _cachedModelsOps;
        private ModelProperties _cachedModelProperties;
        private Operations _cachedOperations;
        private Parameters _cachedParameters;

        /// <summary> Initializes a new instance of ModelsOps. </summary>
        public virtual ModelsOps GetModelsOpsClient()
        {
            return Volatile.Read(ref _cachedModelsOps) ?? Interlocked.CompareExchange(ref _cachedModelsOps, new ModelsOps(_pipeline, _endpoint), null) ?? _cachedModelsOps;
        }

        /// <summary> Initializes a new instance of ModelProperties. </summary>
        public virtual ModelProperties GetModelPropertiesClient()
        {
            return Volatile.Read(ref _cachedModelProperties) ?? Interlocked.CompareExchange(ref _cachedModelProperties, new ModelProperties(_pipeline, _endpoint), null) ?? _cachedModelProperties;
        }

        /// <summary> Initializes a new instance of Operations. </summary>
        public virtual Operations GetOperationsClient()
        {
            return Volatile.Read(ref _cachedOperations) ?? Interlocked.CompareExchange(ref _cachedOperations, new Operations(_pipeline, _endpoint), null) ?? _cachedOperations;
        }

        /// <summary> Initializes a new instance of Parameters. </summary>
        public virtual Parameters GetParametersClient()
        {
            return Volatile.Read(ref _cachedParameters) ?? Interlocked.CompareExchange(ref _cachedParameters, new Parameters(_pipeline, _endpoint), null) ?? _cachedParameters;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using xms_error_responses.Models;

namespace xms_error_responses
{
    /// <summary> The Pet service client. </summary>
    public partial class PetClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PetRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PetClient for mocking. </summary>
        protected PetClient()
        {
        }

        /// <summary> Initializes a new instance of PetClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal PetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new PetRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets pets by id. </summary>
        /// <param name="petId"> pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="petId"/> is null. </exception>
        public virtual async Task<Response<Pet>> GetPetByIdAsync(string petId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.GetPetById");
            scope.Start();
            try
            {
                return await RestClient.GetPetByIdAsync(petId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets pets by id. </summary>
        /// <param name="petId"> pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="petId"/> is null. </exception>
        public virtual Response<Pet> GetPetById(string petId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.GetPetById");
            scope.Start();
            try
            {
                return RestClient.GetPetById(petId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Asks pet to do something. </summary>
        /// <param name="whatAction"> what action the pet should do. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="whatAction"/> is null. </exception>
        public virtual async Task<Response<PetAction>> DoSomethingAsync(string whatAction, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.DoSomething");
            scope.Start();
            try
            {
                return await RestClient.DoSomethingAsync(whatAction, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Asks pet to do something. </summary>
        /// <param name="whatAction"> what action the pet should do. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="whatAction"/> is null. </exception>
        public virtual Response<PetAction> DoSomething(string whatAction, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.DoSomething");
            scope.Start();
            try
            {
                return RestClient.DoSomething(whatAction, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Ensure you can correctly deserialize the returned PetActionError and deserialization doesn't conflict with the input param name 'models'. </summary>
        /// <param name="models"> Make sure model deserialization doesn't conflict with this param name, which has input name 'models'. Use client default value in call. The default value is "value1". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> HasModelsParamAsync(string models = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.HasModelsParam");
            scope.Start();
            try
            {
                return await RestClient.HasModelsParamAsync(models, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Ensure you can correctly deserialize the returned PetActionError and deserialization doesn't conflict with the input param name 'models'. </summary>
        /// <param name="models"> Make sure model deserialization doesn't conflict with this param name, which has input name 'models'. Use client default value in call. The default value is "value1". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response HasModelsParam(string models = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PetClient.HasModelsParam");
            scope.Start();
            try
            {
                return RestClient.HasModelsParam(models, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

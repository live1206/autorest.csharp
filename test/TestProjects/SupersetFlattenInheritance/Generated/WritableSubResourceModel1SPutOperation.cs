// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    public partial class WritableSubResourceModel1SPutOperation : Operation<WritableSubResourceModel1>
    {
        private readonly OperationOrResponseInternals<WritableSubResourceModel1> _operation;

        /// <summary> Initializes a new instance of WritableSubResourceModel1SPutOperation for mocking. </summary>
        protected WritableSubResourceModel1SPutOperation()
        {
        }

        internal WritableSubResourceModel1SPutOperation(OperationsBase operationsBase, Response<WritableSubResourceModel1Data> response)
        {
            _operation = new OperationOrResponseInternals<WritableSubResourceModel1>(Response.FromValue(new WritableSubResourceModel1(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WritableSubResourceModel1 Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubResourceModel1>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubResourceModel1>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
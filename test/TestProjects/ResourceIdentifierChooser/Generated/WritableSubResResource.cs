// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A Class representing a WritableSubResResource along with the instance operations that can be performed on it. </summary>
    public class WritableSubResResource : WritableSubResResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "WritableSubResResource"/> class for mocking. </summary>
        protected WritableSubResResource() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WritableSubResResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal WritableSubResResource(OperationsBase options, WritableSubResResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the WritableSubResResourceData. </summary>
        public virtual WritableSubResResourceData Data { get; private set; }
    }
}
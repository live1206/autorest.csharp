// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A Class representing a WritableSubResourceModel2 along with the instance operations that can be performed on it. </summary>
    public class WritableSubResourceModel2 : WritableSubResourceModel2Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "WritableSubResourceModel2"/> class for mocking. </summary>
        protected WritableSubResourceModel2() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WritableSubResourceModel2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal WritableSubResourceModel2(OperationsBase options, WritableSubResourceModel2Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the WritableSubResourceModel2Data. </summary>
        public virtual WritableSubResourceModel2Data Data { get; private set; }
    }
}
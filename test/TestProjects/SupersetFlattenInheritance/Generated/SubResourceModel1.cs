// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A Class representing a SubResourceModel1 along with the instance operations that can be performed on it. </summary>
    public class SubResourceModel1 : SubResourceModel1Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "SubResourceModel1"/> class for mocking. </summary>
        protected SubResourceModel1() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubResourceModel1"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SubResourceModel1(OperationsBase options, SubResourceModel1Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SubResourceModel1Data. </summary>
        public virtual SubResourceModel1Data Data { get; private set; }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A Class representing a ResourceModel1 along with the instance operations that can be performed on it. </summary>
    public class ResourceModel1 : ResourceModel1Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "ResourceModel1"/> class for mocking. </summary>
        protected ResourceModel1() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceModel1"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ResourceModel1(OperationsBase options, ResourceModel1Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ResourceModel1Data. </summary>
        public virtual ResourceModel1Data Data { get; private set; }
    }
}
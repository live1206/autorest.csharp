// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a AzureResourceFlattenModel4 along with the instance operations that can be performed on it. </summary>
    public class AzureResourceFlattenModel4 : AzureResourceFlattenModel4Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel4"/> class for mocking. </summary>
        protected AzureResourceFlattenModel4()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel4"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AzureResourceFlattenModel4(OperationsBase options, AzureResourceFlattenModel4Data resource)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AzureResourceFlattenModel4Data. </summary>
        public virtual AzureResourceFlattenModel4Data Data { get; private set; }
    }
}
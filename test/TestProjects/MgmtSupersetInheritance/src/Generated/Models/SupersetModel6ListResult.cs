// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using MgmtSupersetInheritance;

namespace MgmtSupersetInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class SupersetModel6ListResult
    {
        /// <summary> Initializes a new instance of <see cref="SupersetModel6ListResult"/>. </summary>
        internal SupersetModel6ListResult()
        {
            Value = new ChangeTrackingList<SupersetModel6Data>();
        }

        /// <summary> Initializes a new instance of <see cref="SupersetModel6ListResult"/>. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal SupersetModel6ListResult(IReadOnlyList<SupersetModel6Data> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<SupersetModel6Data> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
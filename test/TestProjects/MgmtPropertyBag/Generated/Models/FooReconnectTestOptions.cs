// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using MgmtPropertyBag;

namespace MgmtPropertyBag.Models
{
    /// <summary> The FooReconnectTestOptions. </summary>
    public partial class FooReconnectTestOptions
    {
        /// <summary> Initializes a new instance of FooReconnectTestOptions. </summary>
        public FooReconnectTestOptions()
        {
            CountryOrRegions = new ChangeTrackingList<string>();
        }

        /// <summary> The parameters supplied to the Reconnect operation. </summary>
        public FooData Data { get; set; }
        /// <summary> The filter to apply on the operation. </summary>
        public string Filter { get; set; }
        /// <summary> The int? to use. </summary>
        public int? Top { get; set; }
        /// <summary> The String to use. </summary>
        public string Orderby { get; set; }
        /// <summary> The entity state (Etag) version. A value of "*" can be used for If-Match to unconditionally apply the operation. </summary>
        public ETag? IfMatch { get; set; }
        /// <summary> The IEnumerable{string} to use. </summary>
        public IList<string> CountryOrRegions { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Pagination.Models
{
    /// <summary> A class representing the PageSizeStringModel data model. </summary>
    public partial class PageSizeStringModelData : SubResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of PageSizeStringModelData. </summary>
        public PageSizeStringModelData()
        {
        }

        /// <summary> Initializes a new instance of PageSizeStringModelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        internal PageSizeStringModelData(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using MgmtSupersetInheritance.Models;

namespace MgmtSupersetInheritance
{
    /// <summary>
    /// A class representing the SupersetModel7 data model.
    /// This model has a systemData different from common type and should not inherit from Resource.
    /// </summary>
    public partial class SupersetModel7Data
    {
        /// <summary> Initializes a new instance of <see cref="SupersetModel7Data"/>. </summary>
        public SupersetModel7Data()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SupersetModel7Data"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="resourceType"></param>
        /// <param name="new"></param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal SupersetModel7Data(string id, string name, string resourceType, string @new, SupersetModel7SystemData systemData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            New = @new;
            SystemData = systemData;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SupersetModel7SystemData SystemData { get; }
    }
}
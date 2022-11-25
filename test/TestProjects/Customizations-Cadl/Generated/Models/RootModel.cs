// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CustomizationsInCadl.Models
{
    /// <summary> Root RoundTrip model to reference all other types to ensure generation. </summary>
    public partial class RootModel
    {
        /// <summary> Initializes a new instance of RootModel. </summary>
        public RootModel()
        {
        }

        /// <summary> Initializes a new instance of RootModel. </summary>
        /// <param name="propertyModelToMakeInternal"></param>
        /// <param name="propertyModelToRename"></param>
        /// <param name="propertyModelToChangeNamespace"></param>
        /// <param name="propertyModelWithCustomizedProperties"></param>
        /// <param name="propertyEnumToRename"></param>
        /// <param name="propertyEnumWithValueToRename"></param>
        /// <param name="propertyEnumToBeMadeExtensible"></param>
        internal RootModel(ModelToMakeInternal propertyModelToMakeInternal, RenamedModel propertyModelToRename, ModelToChangeNamespace propertyModelToChangeNamespace, ModelWithCustomizedProperties propertyModelWithCustomizedProperties, RenamedEnum? propertyEnumToRename, EnumWithValueToRename? propertyEnumWithValueToRename, EnumToBeMadeExtensible? propertyEnumToBeMadeExtensible)
        {
            PropertyModelToMakeInternal = propertyModelToMakeInternal;
            PropertyModelToRename = propertyModelToRename;
            PropertyModelToChangeNamespace = propertyModelToChangeNamespace;
            PropertyModelWithCustomizedProperties = propertyModelWithCustomizedProperties;
            PropertyEnumToRename = propertyEnumToRename;
            PropertyEnumWithValueToRename = propertyEnumWithValueToRename;
            PropertyEnumToBeMadeExtensible = propertyEnumToBeMadeExtensible;
        }
        /// <summary> Gets or sets the property model to rename. </summary>
        public RenamedModel PropertyModelToRename { get; set; }
        /// <summary> Gets or sets the property model to change namespace. </summary>
        public ModelToChangeNamespace PropertyModelToChangeNamespace { get; set; }
        /// <summary> Gets or sets the property model with customized properties. </summary>
        public ModelWithCustomizedProperties PropertyModelWithCustomizedProperties { get; set; }
        /// <summary> Gets or sets the property enum to rename. </summary>
        public RenamedEnum? PropertyEnumToRename { get; set; }
        /// <summary> Gets or sets the property enum with value to rename. </summary>
        public EnumWithValueToRename? PropertyEnumWithValueToRename { get; set; }
        /// <summary> Gets or sets the property enum to be made extensible. </summary>
        public EnumToBeMadeExtensible? PropertyEnumToBeMadeExtensible { get; set; }
    }
}
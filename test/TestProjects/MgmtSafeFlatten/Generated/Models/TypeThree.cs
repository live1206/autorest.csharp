// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtSafeFlatten.Models
{
    /// <summary> The TypeThree. </summary>
    internal partial class TypeThree
    {
        /// <summary> Initializes a new instance of TypeThree. </summary>
        internal TypeThree()
        {
        }

        /// <summary> The details of the type. </summary>
        public string MyType { get; }
        /// <summary> The single value prop. </summary>
        internal LayerTwoSingle Properties { get; }
        /// <summary> MyProp description. </summary>
        public string LayerTwoSingleMyProp
        {
            get => Properties.MyProp;
            set => Properties.MyProp = value;
        }
    }
}
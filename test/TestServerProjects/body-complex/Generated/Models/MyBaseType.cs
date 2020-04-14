// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace body_complex.Models
{
    /// <summary> The MyBaseType. </summary>
    public partial class MyBaseType
    {
        /// <summary> Initializes a new instance of MyBaseType. </summary>
        internal MyBaseType()
        {
            Kind = null;
        }

        /// <summary> Initializes a new instance of MyBaseType. </summary>
        /// <param name="kind"> . </param>
        /// <param name="propB1"> . </param>
        /// <param name="propBH1"> . </param>
        internal MyBaseType(string kind, string propB1, string propBH1)
        {
            Kind = kind;
            PropB1 = propB1;
            PropBH1 = propBH1;
        }

        internal string Kind { get; set; }
        public string PropB1 { get; }
        public string PropBH1 { get; }
    }
}

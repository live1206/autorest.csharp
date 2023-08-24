// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> Unknown version of Dinosaur. </summary>
    internal partial class UnknownDinosaur : Dinosaur
    {
        /// <summary> Initializes a new instance of UnknownDinosaur. </summary>
        /// <param name="size"></param>
        internal UnknownDinosaur(int size) : base(size)
        {
        }

        /// <summary> Initializes a new instance of UnknownDinosaur. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="size"></param>
        internal UnknownDinosaur(string kind, int size) : base(kind, size)
        {
        }
    }
}
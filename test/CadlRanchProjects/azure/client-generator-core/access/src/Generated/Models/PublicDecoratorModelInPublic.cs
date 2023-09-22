// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Models
{
    /// <summary> Used in a public operation, should be generated and exported. </summary>
    public partial class PublicDecoratorModelInPublic
    {
        /// <summary> Initializes a new instance of PublicDecoratorModelInPublic. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal PublicDecoratorModelInPublic(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}
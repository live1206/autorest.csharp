// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.NotDiscriminated.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class TypeModelInheritanceNotDiscriminatedModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.Pet"/>. </summary>
        /// <param name="name"></param>
        /// <returns> A new <see cref="Models.Pet"/> instance for mocking. </returns>
        public static Pet Pet(string name = null)
        {
            return new Pet(name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Cat"/>. </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <returns> A new <see cref="Models.Cat"/> instance for mocking. </returns>
        public static Cat Cat(string name = null, int age = default)
        {
            return new Cat(name, serializedAdditionalRawData: null, age);
        }
    }
}
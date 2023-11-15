// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal abstract class OutputLibrary
    {
        public abstract TypeProvider FindTypeProviderForInputType(InputType inputType);
        public abstract CSharpType? FindTypeByName(string originalName);

        /// <summary>
        /// Returns CSharpType that matches the enum definition provided in the input model, or a value type that enum can be converted to if enum wasn't defined in the input
        /// </summary>
        public abstract CSharpType ResolveEnum(InputEnumType enumType);

        /// <summary>
        /// Returns CSharpType that matches the model definition provided in the input model, or simple object type if model type wasn't defined in the input
        /// </summary>
        public abstract CSharpType ResolveModel(InputModelType model);
    }
}

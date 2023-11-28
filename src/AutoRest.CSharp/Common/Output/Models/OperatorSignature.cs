// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Shared;

namespace AutoRest.CSharp.Output.Models
{
    internal record OperatorSignature(bool IsExplicit, FormattableString? Summary, FormattableString? Description, Parameter FromParameter, CSharpType ToType)
        : MethodSignatureBase(ToType.Name, Summary, Description, null, MethodSignatureModifiers.Public | MethodSignatureModifiers.Static, new[]{FromParameter}, Array.Empty<CSharpAttribute>());
}
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using AutoRest.CSharp.Common.Output.Models.ValueExpressions;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.Common.Output.Models.KnownValueExpressions
{
    internal sealed record StringExpression(ValueExpression Untyped) : TypedValueExpression(typeof(string), Untyped)
    {
        public ValueExpression Length => new MemberExpression(Untyped, nameof(string.Length));

        public static BoolExpression Equals(StringExpression left, StringExpression right, StringComparison comparisonType)
            => new(new InvokeStaticMethodExpression(typeof(string), nameof(string.Equals), new[]{ left, right, FrameworkEnumValue(comparisonType) }));
    }
}

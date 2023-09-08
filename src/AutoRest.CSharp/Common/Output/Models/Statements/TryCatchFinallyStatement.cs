﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace AutoRest.CSharp.Common.Output.Models.Statements
{
    internal record TryCatchFinallyStatement(MethodBodyStatement Try, MethodBodyStatement? Catch, MethodBodyStatement? Finally) : MethodBodyStatement;
}

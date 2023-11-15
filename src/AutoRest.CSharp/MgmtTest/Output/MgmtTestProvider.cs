﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.MgmtTest.Output
{
    internal abstract class MgmtTestProvider : TypeProvider
    {
        public MgmtTestProvider() : base(Configuration.Namespace, null)
        {
        }

        public string Accessibility => DefaultAccessibility;
        protected override string DefaultAccessibility => "public";
        public string Namespace => DefaultNamespace;
        public abstract FormattableString Description { get; }
        public virtual CSharpType? BaseType => null;
    }
}

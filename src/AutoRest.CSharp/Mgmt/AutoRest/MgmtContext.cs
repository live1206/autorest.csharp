﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.AutoRest
{
    internal static class MgmtContext
    {
        private static BuildContext<MgmtOutputLibrary>? _context;
        public static BuildContext<MgmtOutputLibrary> Context => _context ?? throw new InvalidOperationException("MgmtContext was not initialized.");

        public static MgmtOutputLibrary Library => Context.Library;

        public static TypeFactory TypeFactory => Context.TypeFactory;

        public static InputNamespace? InputNamespace => Context.InputNamespace;

        public static CodeModel? CodeModel => Context.CodeModel;

        public static SchemaUsageProvider? SchemaUsageProvider => Context.SchemaUsageProvider;

        public static string DefaultNamespace => Configuration.Namespace;

        public static string RPName => ClientBuilder.GetRPName(DefaultNamespace);

        public static bool IsInitialized => _context is not null;

        public static void Initialize(BuildContext<MgmtOutputLibrary> context)
        {
            _context = context;
        }
    }
}

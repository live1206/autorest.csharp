﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Shared;
using MethodParameter = AutoRest.CSharp.Output.Models.Shared.Parameter;

namespace AutoRest.CSharp.Generation.Writers
{
    internal static class BreakingChangeWriter
    {
        public static void WriteMissingOverloadingMethod(this CodeWriter writer, OverloadMethodSignature overloadMethod)
        {
            writer.WriteXmlDocumentationSummary(overloadMethod.Description);
            writer.Line($"[{typeof(EditorBrowsableAttribute)}({typeof(EditorBrowsableState)}.{nameof(EditorBrowsableState.Never)})]");
            using (writer.WriteMethodDeclaration(overloadMethod.PreviousMethodSignature))
            {
                writer.Line();
                var isAwait = overloadMethod.PreviousMethodSignature.Modifiers.HasFlag(MethodSignatureModifiers.Async);
                var awaitOperation = isAwait ? "await " : "";
                writer.Append($"return {awaitOperation}{overloadMethod.MethodSignature.Name}(");
                var set = overloadMethod.MissingParameters.ToHashSet(new ParameterComparer());
                foreach (var parameter in overloadMethod.MethodSignature.Parameters)
                {
                    if (set.Contains(parameter))
                    {
                        writer.Append($"{parameter.DefaultValue?.Value ?? "default"}, ");
                    }
                    else
                    {
                        writer.Append($"{parameter.Name}, ");
                    }
                }
                writer.RemoveTrailingComma();
                if (isAwait)
                {
                    writer.Line($").ConfigureAwait(false);");
                }
                else
                {
                    writer.Line($");");
                }
            }
        }
    }
}

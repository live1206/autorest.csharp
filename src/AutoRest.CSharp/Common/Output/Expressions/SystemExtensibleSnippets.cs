﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions.System;
using AutoRest.CSharp.Common.Output.Expressions.Statements;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Shared;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.Common.Output.Expressions
{
    internal class SystemExtensibleSnippets : ExtensibleSnippets
    {
        public override JsonElementSnippets JsonElement { get; } = new SystemJsonElementSnippets();
        public override XElementSnippets XElement => throw new NotImplementedException("XElement extensions aren't supported in unbranded yet.");
        public override XmlWriterSnippets XmlWriter => throw new NotImplementedException("XmlWriter extensions aren't supported in unbranded yet.");
        public override OperationResponseSnippets OperationResponse { get; } = new SystemOperationResponseSnippets();
        public override ModelSnippets Model { get; } = new SystemModelSnippets();

        internal class SystemModelSnippets : ModelSnippets
        {
            public override Method BuildConversionToRequestBodyMethod(MethodSignatureModifiers modifiers)
            {
                return new Method
                (
                    new MethodSignature("ToRequestBody", null, $"Convert into a Utf8JsonRequestBody.", modifiers, typeof(RequestBody), null, Array.Empty<Parameter>()),
                    new[]
                    {
                        DeclareRequestBody(out var requestContent),
                        requestContent.JsonWriter.WriteObjectValue(This),
                        Return(requestContent)
                    }
                );
            }

            public override Method BuildFromOperationResponseMethod(SerializableObjectType type, MethodSignatureModifiers modifiers)
            {
                var result = new Parameter("result", "The result to deserialize the model from.", typeof(PipelineResponse), null, Validation.None, null);
                return new Method
                (
                    new MethodSignature("FromResponse", null, $"Deserializes the model from a raw response.", modifiers, type.Type, null, new[]{result}),
                    new MethodBodyStatement[]
                    {
                        UsingVar("document", JsonDocumentExpression.Parse(new PipelineResponseExpression(result).Content), out var document),
                        Return(SerializableObjectTypeExpression.Deserialize(type, document.RootElement))
                    }
                );
            }

            private static DeclarationStatement DeclareRequestBody(out Utf8JsonRequestBodyExpression variable)
            {
                var variableRef = new VariableReference(typeof(Utf8JsonRequestBody), "content");
                variable = new Utf8JsonRequestBodyExpression(variableRef);
                return new DeclareVariableStatement(null, variableRef.Declaration, New.Instance(typeof(Utf8JsonRequestBody)));
            }
        }

        private class SystemOperationResponseSnippets : OperationResponseSnippets
        {
            public override TypedValueExpression GetTypedResponseFromValue(TypedValueExpression value, TypedValueExpression response)
                => ResultExpression.FromValue(value, new PipelineResponseExpression(response));

            public override BinaryDataExpression GetBinaryDataFromResponse(TypedValueExpression response)
                => new PipelineResponseExpression(response).Content;
        }

        private class SystemJsonElementSnippets : JsonElementSnippets
        {
            public override ValueExpression GetBytesFromBase64(JsonElementExpression element, string? format) => InvokeExtension(typeof(ModelSerializationExtensions), element, nameof(ModelSerializationExtensions.GetBytesFromBase64), Literal(format));
            public override ValueExpression GetChar(JsonElementExpression element) => InvokeExtension(typeof(ModelSerializationExtensions), element, nameof(ModelSerializationExtensions.GetChar));
            public override ValueExpression GetDateTimeOffset(JsonElementExpression element, string? format) => InvokeExtension(typeof(ModelSerializationExtensions), element, nameof(ModelSerializationExtensions.GetDateTimeOffset), Literal(format));
            public override ValueExpression GetObject(JsonElementExpression element) => InvokeExtension(typeof(ModelSerializationExtensions), element, nameof(ModelSerializationExtensions.GetObject));
            public override ValueExpression GetTimeSpan(JsonElementExpression element, string? format) => InvokeExtension(typeof(ModelSerializationExtensions), element, nameof(ModelSerializationExtensions.GetTimeSpan), Literal(format));
            public override MethodBodyStatement ThrowNonNullablePropertyIsNull(JsonPropertyExpression property)
                => new InvokeStaticMethodStatement(typeof(ModelSerializationExtensions), nameof(ModelSerializationExtensions.ThrowNonNullablePropertyIsNull), new[] { property }, CallAsExtension: true);
        }
    }
}

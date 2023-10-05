﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions;
using AutoRest.CSharp.Common.Output.Expressions.Statements;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Output.Samples.Models;
using AutoRest.CSharp.Utilities;
using Azure;
using NUnit.Framework;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.LowLevel.Output.Samples
{
    internal class DpgClientSampleProvider : TypeProvider
    {
        protected override string DefaultNamespace { get; }
        protected override string DefaultName { get; }
        protected override string DefaultAccessibility => "public";

        public IReadOnlyList<Method> Methods { get; }

        private static readonly CSharpAttribute[] Attributes = { new(typeof(TestAttribute)), new(typeof(IgnoreAttribute), "Only validating compilation of examples") };
        private readonly IReadOnlyDictionary<MethodSignatureBase, IReadOnlyList<(string, Method)>> _restClientMethodsToTestMethods;

        public DpgClientSampleProvider(string defaultNamespace, LowLevelClient client, SourceInputModel? sourceInputModel) : base(defaultNamespace, sourceInputModel)
        {
            DefaultNamespace = $"{defaultNamespace}.Samples";
            DefaultName = $"Samples_{client.Declaration.Name}";

            BuildMethods(client, out var restClientMethodsToTestMethods, out var methods);
            _restClientMethodsToTestMethods = restClientMethodsToTestMethods;
            Methods = methods;
        }

        public IEnumerable<(string ExampleInformation, MethodBodyStatement TestMethodBody)> GetSampleInformation(MethodSignatureBase signature)
        {
            if (!_restClientMethodsToTestMethods.TryGetValue(signature, out var testMethods))
            {
                yield break;
            }

            foreach ((string? exampleInformation, Method? testMethod) in testMethods)
            {
                yield return (exampleInformation, testMethod.Body ?? new MethodBodyStatement());
            }
        }

        private bool? _isEmpty;
        public bool IsEmpty => _isEmpty ??= !Methods.Any();

        private static void BuildMethods(LowLevelClient client, out Dictionary<MethodSignatureBase, IReadOnlyList<(string ExampleInformation, Method TestMethod)>> restClientMethodsToTestMethods, out List<Method> methods)
        {
            methods = new List<Method>();
            restClientMethodsToTestMethods = new Dictionary<MethodSignatureBase, IReadOnlyList<(string, Method)>>();
            foreach (var operationMethods in client.OperationMethods.OrderBy(m => m.Order))
            {
                var samples = operationMethods.Samples;

                IReadOnlyList<(string, Method Method)> sampleProtocolMethods = Array.Empty<(string, Method)>();
                IReadOnlyList<(string, Method Method)> sampleProtocolAsyncMethods = Array.Empty<(string, Method)>();
                IReadOnlyList<(string, Method Method)> sampleConvenienceMethods = Array.Empty<(string, Method)>();
                IReadOnlyList<(string, Method Method)> sampleConvenienceAsyncMethods = Array.Empty<(string, Method)>();

                if (operationMethods.Protocol is { } protocol)
                {
                    sampleProtocolMethods = BuildSampleMethods(client.Type, protocol.Signature, samples, false, false);
                    restClientMethodsToTestMethods[protocol.Signature] = sampleProtocolMethods;
                }
                if (operationMethods.ProtocolAsync is { } protocolAsync)
                {
                    sampleProtocolAsyncMethods = BuildSampleMethods(client.Type, protocolAsync.Signature, samples, false, true);
                    restClientMethodsToTestMethods[protocolAsync.Signature] = sampleProtocolAsyncMethods;
                }
                if (operationMethods.Convenience is { } convenience)
                {
                    sampleConvenienceMethods = BuildSampleMethods(client.Type, convenience.Signature, samples, true, false);
                    restClientMethodsToTestMethods[convenience.Signature] = sampleConvenienceMethods;
                }
                if (operationMethods.ConvenienceAsync is { } convenienceAsync)
                {
                    sampleConvenienceAsyncMethods = BuildSampleMethods(client.Type, convenienceAsync.Signature, samples, true, true);
                    restClientMethodsToTestMethods[convenienceAsync.Signature] = sampleConvenienceAsyncMethods;
                }

                // Group methods by sample type
                var maxLength = Math.Max(
                    Math.Max(sampleProtocolMethods.Count, sampleProtocolAsyncMethods.Count),
                    Math.Max(sampleConvenienceMethods.Count, sampleConvenienceAsyncMethods.Count)
                );

                for (var i = 0; i < maxLength; i++)
                {
                    if (sampleProtocolMethods.Count > i)
                    {
                        methods.Add(sampleProtocolMethods[i].Method);
                    }
                    if (sampleProtocolAsyncMethods.Count > i)
                    {
                        methods.Add(sampleProtocolAsyncMethods[i].Method);
                    }
                    if (sampleConvenienceMethods.Count > i)
                    {
                        methods.Add(sampleConvenienceMethods[i].Method);
                    }
                    if (sampleConvenienceAsyncMethods.Count > i)
                    {
                        methods.Add(sampleConvenienceAsyncMethods[i].Method);
                    }
                }
            }
        }

        private static MethodSignature GetMethodSignature(DpgOperationSample sample, bool isAsync) => new(
                Name: GetMethodName(sample, isAsync),
                Summary: null,
                Description: null,
                Modifiers: isAsync ? MethodSignatureModifiers.Public | MethodSignatureModifiers.Async : MethodSignatureModifiers.Public,
                ReturnType: isAsync ? typeof(Task) : (CSharpType?)null,
                ReturnDescription: null,
                Parameters: Array.Empty<Parameter>(),
                Attributes: Attributes);

        private static string GetMethodName(DpgOperationSample sample, bool isAsync)
        {
            var builder = new StringBuilder("Example_").Append(sample.OperationMethodSignature.Name);

            builder.Append('_').Append(sample.ExampleKey);

            if (sample.IsConvenienceSample)
            {
                builder.Append("_Convenience");
            }
            if (isAsync)
            {
                builder.Append("_Async");
            }
            return builder.ToString();
        }

        private static IReadOnlyList<(string ExampleInformation, Method Method)> BuildSampleMethods(CSharpType clientType, MethodSignatureBase signature, IEnumerable<DpgOperationSample> samples, bool isConvenienceSample, bool isAsync)
            => samples
                .Where(s => s.IsConvenienceSample == isConvenienceSample)
                .Select(s => (s.GetSampleInformation(signature), BuildSampleMethod(clientType, s, isAsync)))
                .ToList();

        private static Method BuildSampleMethod(CSharpType clientType, DpgOperationSample sample, bool isAsync)
        {
            var signature = GetMethodSignature(sample, isAsync);
            var clientVariableStatements = new List<MethodBodyStatement>();
            var newClientStatement = BuildGetClientStatement(clientType, sample, sample.ClientInvocationChain, clientVariableStatements, out var clientVar);

            // the method invocation statements go here
            var operationVariableStatements = new List<MethodBodyStatement>();
            var operationInvocationStatements = BuildSampleOperationInvocation(sample, clientVar, operationVariableStatements, isAsync);

            return new Method(signature, new[]
            {
                clientVariableStatements,
                newClientStatement,
                EmptyLine,
                operationVariableStatements,
                operationInvocationStatements
            });
        }

        private static MethodBodyStatement BuildGetClientStatement(CSharpType clientType, DpgOperationSample sample, IReadOnlyList<MethodSignatureBase> methodsToCall, List<MethodBodyStatement> variableDeclarations, out VariableReference clientVar)
        {
            var first = methodsToCall[0];
            ValueExpression valueExpression = first switch
            {
                ConstructorSignature ctor => New.Instance(ctor.Type, sample.GetValueExpressionsForParameters(ctor.Parameters, variableDeclarations).ToArray()),
                _ => new InvokeInstanceMethodExpression(null, first.Name, sample.GetValueExpressionsForParameters(first.Parameters, variableDeclarations).ToArray(), null, false)
            };

            foreach (var method in methodsToCall.Skip(1))
            {
                valueExpression = valueExpression.Invoke(method.Name, sample.GetValueExpressionsForParameters(method.Parameters, variableDeclarations).ToArray());
            }

            clientVar = new VariableReference(clientType, "client");

            return Declare(clientVar, valueExpression);
        }

        private static MethodBodyStatement BuildSampleOperationInvocation(DpgOperationSample sample, ValueExpression clientVar, List<MethodBodyStatement> variableDeclarations, bool isAsync)
        {
            var methodSignature = sample.OperationMethodSignature.WithAsync(isAsync);
            var parameterExpressions = sample.GetValueExpressionsForParameters(methodSignature.Parameters, variableDeclarations);
            var invocation = clientVar.Invoke(methodSignature, parameterExpressions.ToArray(), addConfigureAwaitFalse: false);

            if (sample.PageItemType is {} pageItemType)
            {
                var foreachItemType = sample.IsConvenienceSample ? pageItemType : typeof(BinaryData);

                // if it is pageable, we need to wrap the invocation inside a foreach statement
                // but before the foreach, if this operation is long-running, we still need to call it, and pass the operation.Value into the foreach
                if (sample.IsLongRunning)
                {
                    /*
                     * This will generate code like:
                     * Operation<T> operation = <invocation>;
                     * await foreach (ItemType item in operation.Value)
                     * {}
                     */
                    return new MethodBodyStatement[]
                    {
                        Declare("operation", new OperationExpression(invocation), out var operation),
                        new ForeachStatement(foreachItemType, "item", operation.Value, isAsync, out var itemVar)
                        {
                            ParseResponse(pageItemType, sample, new BinaryDataExpression(itemVar).ToStream())
                        }
                    };
                }
                else
                {
                    /*
                     * This will generate code like:
                     * await foreach (ItemType item in <invocation>)
                     * {}
                     */
                    return new ForeachStatement(foreachItemType, "item", invocation, isAsync, out var itemVar)
                    {
                        ParseResponse(pageItemType, sample, new BinaryDataExpression(itemVar).ToStream())
                    };
                }
            }

            // if it is not pageable, we just call the operation, declare a local variable and assign the result to it
            if (sample is {ResponseType: {} responseType})
            {
                var returnType = sample.OperationMethodSignature.ReturnType!;

                if (sample.IsLongRunning)
                {
                    /*
                    * This will generate code like:
                    * Operation<T> operation = <invocation>;
                    * BinaryData responseData = operation.Value;
                    */
                    return new[]
                    {
                        Declare(returnType, "operation", new OperationExpression(invocation), out var operation),
                        Declare("responseData", new BinaryDataExpression(operation.Value), out var responseData),
                        EmptyLine,
                        ParseResponse(responseType, sample, responseData.ToStream())
                    };
                }

                /*
                 * This will generate code like:
                 * Response<T> operation = <invocation>;
                 */
                return new[]
                {
                    Declare(returnType, "response", new ResponseExpression(invocation), out var responseOfT),
                    EmptyLine,
                    ParseResponseOfT(responseType, sample, responseOfT)
                };
            }

            /*
             * This will generate code like:
             * Operation operation = <invocation>; // when it is long-running
             * Response response = <invocation>; // when it is not long-running
             */
            if (sample.IsLongRunning)
            {
                return Declare("operation", new OperationExpression(invocation), out _);
            }

            return new[]
            {
                Declare("response", new ResponseExpression(invocation), out var response),
                EmptyLine,
                InvokeConsoleWriteLine(response.Status)
            };
        }

        private static MethodBodyStatement ParseResponseOfT(CSharpType responseType, DpgOperationSample sample, ResponseExpression responseVar)
        {
            return sample.HasResponseBody
                ? ParseResponse(responseType, sample, responseVar.ContentStream)
                : InvokeConsoleWriteLine(responseVar.GetRawResponse().Status);
        }

        private static MethodBodyStatement ParseResponse(CSharpType responseType, DpgOperationSample sample, StreamExpression streamVar)
        {
            if (responseType.Equals(typeof(Stream)))
            {
                return new IfStatement(NotEqual(streamVar, Null))
                {
                    UsingDeclare("outFileStream", new StreamExpression(InvokeFileOpenWrite("<filepath>")), out var streamVariable),
                    streamVar.CopyTo(streamVariable)
                };
            }

            if (sample.IsConvenienceSample)
            {
                return new MethodBodyStatement();
            }

            var responseParsingStatements = new List<MethodBodyStatement>
            {
                Declare("result", JsonDocumentExpression.Parse(streamVar).RootElement, out var resultVar)
            };
            BuildResponseParseStatements(sample.IsAllParametersUsed, responseType, resultVar, responseParsingStatements, new HashSet<CSharpType>());
            return responseParsingStatements;
        }

        private static void BuildResponseParseStatements(bool useAllProperties, CSharpType jsonElementType, JsonElementExpression jsonElement, List<MethodBodyStatement> statements, HashSet<CSharpType> visitedTypes)
        {
            if (TypeFactory.IsList(jsonElementType, out var elementType))
            {
                if (!visitedTypes.Contains(elementType))
                {
                    // <invocation>[0]
                    BuildResponseParseStatements(useAllProperties, elementType, jsonElement[0], statements, visitedTypes);
                }
            }
            else if (TypeFactory.IsDictionary(jsonElementType, out _, out var valueType))
            {
                if (!visitedTypes.Contains(valueType))
                {
                    // <invocation>.GetProperty("<key>")
                    BuildResponseParseStatements(useAllProperties, valueType, jsonElement.GetProperty("<key>"), statements, visitedTypes);
                }
            }
            else if (jsonElementType is { IsFrameworkType: false, Implementation: ObjectType implementation })
            {
                switch (implementation)
                {
                    case SerializableObjectType model:
                        BuildResponseParseStatementsForModelType(useAllProperties, model, jsonElement, statements, visitedTypes);
                        return;

                    case SystemObjectType systemObjectType:
                        BuildResponseParseStatementsForSystemType(useAllProperties, systemObjectType, jsonElement, statements, visitedTypes);
                        return;
                }
            }
            else
            {
                // we get primitive types, return the statement
                var statement = InvokeConsoleWriteLine(jsonElement.InvokeToString());
                statements.Add(statement);
            }
        }

        private static void BuildResponseParseStatementsForModelType(bool useAllProperties, SerializableObjectType model, JsonElementExpression jsonElement, List<MethodBodyStatement> statements, HashSet<CSharpType> visitedTypes)
        {
            var propertiesToExplore = useAllProperties
                ? model.JsonSerialization?.Properties
                : model.JsonSerialization?.Properties.Where(p => p.IsRequired).ToArray();

            if (propertiesToExplore is null ||  !propertiesToExplore.Any()) // if you have a required property, but its child properties are all optional
            {
                // return the object
                statements.Add(InvokeConsoleWriteLine(jsonElement.InvokeToString()));
                return;
            }

            foreach (var property in propertiesToExplore)
            {
                var propertyType = property.Value.Type;
                if (!visitedTypes.Contains(propertyType))
                {
                    // <invocation>.GetProperty("<propertyName>");
                    visitedTypes.Add(propertyType);
                    var next = jsonElement.GetProperty(property.SerializedName);
                    BuildResponseParseStatements(useAllProperties, propertyType, next, statements, visitedTypes);
                    visitedTypes.Remove(propertyType);
                }
            }
        }

        private static void BuildResponseParseStatementsForSystemType(bool useAllProperties, SystemObjectType systemObjectType, JsonElementExpression jsonElement, List<MethodBodyStatement> statements, HashSet<CSharpType> visitedTypes)
        {
            var propertiesToExplore = useAllProperties
                ? systemObjectType.Properties
                : systemObjectType.Properties.Where(p => p.IsRequired).ToArray();

            foreach (var property in propertiesToExplore)
            {
                var propertyType = property.ValueType;
                if (!visitedTypes.Contains(propertyType) && property.SchemaProperty is {SerializedName: var propertyName})
                {
                    // <invocation>.GetProperty("<propertyName>");
                    visitedTypes.Add(propertyType);
                    var next = jsonElement.GetProperty(propertyName);
                    BuildResponseParseStatements(useAllProperties, propertyType, next, statements, visitedTypes);
                    visitedTypes.Remove(propertyType);
                }
            }
        }
    }
}
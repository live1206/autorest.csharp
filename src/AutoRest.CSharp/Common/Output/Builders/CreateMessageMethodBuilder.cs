﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Common.Output.Models.KnownValueExpressions;
using AutoRest.CSharp.Common.Output.Models.Responses;
using AutoRest.CSharp.Common.Output.Models.Statements;
using AutoRest.CSharp.Common.Output.Models.ValueExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Serialization;
using AutoRest.CSharp.Output.Models.Serialization.Json;
using AutoRest.CSharp.Output.Models.Serialization.Xml;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.Core;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.Common.Output.Builders
{
    internal class CreateMessageMethodBuilder
    {
        private static readonly HashSet<string> ContentHeaders = new(StringComparer.OrdinalIgnoreCase)
        {
            "Allow",
            "Content-Disposition",
            "Content-Encoding",
            "Content-Language",
            "Content-Length",
            "Content-Location",
            "Content-MD5",
            "Content-Range",
            "Content-Type",
            "Expires",
            "Last-Modified",
        };

        private readonly ClientFields _fields;
        private readonly IReadOnlyList<RequestPartSource> _requestParts;
        private readonly IReadOnlyList<Parameter> _parameters;
        private readonly HttpPipelineExpression _pipeline;
        private readonly RequestContextExpression? _requestContext;

        public CreateMessageMethodBuilder(ClientFields fields, IReadOnlyList<RequestPartSource> requestParts, IReadOnlyList<Parameter> parameters, RequestContextExpression? requestContext)
        {
            _fields = fields;
            _requestParts = requestParts;
            _parameters = parameters;
            _requestContext = requestContext;
            _pipeline  = new HttpPipelineExpression(_fields.PipelineField.Declaration);
        }

        public MethodBodyStatement CreateHttpMessage(RequestMethod requestMethod, bool bufferResponse, ResponseClassifierType? responseClassifierType, out HttpMessageExpression message, out RequestExpression request, out RawRequestUriBuilderExpression uriBuilder)
        {
            var callPipelineCreateMessage = _requestContext is not null
                ? responseClassifierType is not null
                    ? _pipeline.CreateMessage(_requestContext, new FormattableStringToExpression($"{responseClassifierType.Name}"))
                    : _pipeline.CreateMessage(_requestContext)
                : _pipeline.CreateMessage();

            var statements = new List<MethodBodyStatement>
            {
                Var("message", callPipelineCreateMessage, out message),
                Var("request", message.Request, out request)
            };

            if (!bufferResponse)
            {
                statements.Add(Assign(message.BufferResponse, False));
            }

            statements.Add(Assign(request.Method, new MemberExpression(typeof(RequestMethod), requestMethod.ToRequestMethodName())));
            statements.Add(Var("uri", New.RawRequestUriBuilder(), out uriBuilder));

            return statements;
        }

        public MethodBodyStatement AddUri(RawRequestUriBuilderExpression uriBuilder, string uri)
        {
            var lines = new List<MethodBodyStatement>();
            foreach ((ReadOnlySpan<char> span, bool isLiteral) in StringExtensions.GetPathParts(uri))
            {
                if (isLiteral)
                {
                    lines.Add(uriBuilder.AppendRaw(span.ToString(), false));
                }
                else if (TryGetUriOrPathRequestPart(span, RequestLocation.Uri, out var inputParameter, out var outputParameter, out _))
                {
                    if (inputParameter.IsEndpoint)
                    {
                        lines.Add(uriBuilder.Reset(_fields.EndpointField ?? throw new InvalidOperationException("Endpoint field is missing!")));
                    }
                    else
                    {
                        var value = GetValueForRequestPart(inputParameter, outputParameter);

                        lines.Add(outputParameter.Type.Equals(typeof(Uri))
                            ? uriBuilder.Reset(value)
                            : uriBuilder.AppendRaw(ConvertToRequestPartType(value, outputParameter.Type, convertOnlyExtendableEnumToString: true), !inputParameter.SkipUrlEncoding));
                    }
                }
                else
                {
                    ErrorHelpers.ThrowError($"\n\nError while processing request '{uri}'\n\n  '{span.ToString()}' in URI is missing a matching definition in the path parameters collection{ErrorHelpers.UpdateSwaggerOrFile}");
                }
            }
            return lines;
        }

        public List<MethodBodyStatement> AddPath(RawRequestUriBuilderExpression uriBuilder, string path)
        {
            var lines = new List<MethodBodyStatement>();
            foreach ((ReadOnlySpan<char> span, bool isLiteral) in StringExtensions.GetPathParts(path))
            {
                if (isLiteral)
                {
                    lines.Add(uriBuilder.AppendPath(span.ToString(), false));
                }
                else if (TryGetUriOrPathRequestPart(span, RequestLocation.Path, out var inputParameter, out var outputParameter, out var format))
                {
                    var value = GetValueForRequestPart(inputParameter, outputParameter);
                    lines.Add(value is not ConstantExpression && outputParameter.Name == "nextLink"
                        ? uriBuilder.AppendRawNextLink(outputParameter, !inputParameter.SkipUrlEncoding)
                        : uriBuilder.AppendPath(ConvertToRequestPartType(value, outputParameter.Type, format), format, !inputParameter.SkipUrlEncoding));
                }
                else
                {
                    ErrorHelpers.ThrowError($"\n\nError while processing request '{path}'\n\n  '{span.ToString()}' in URI is missing a matching definition in the path parameters collection{ErrorHelpers.UpdateSwaggerOrFile}");
                }
            }
            return lines;
        }

        public IEnumerable<MethodBodyStatement> AddQuery(RawRequestUriBuilderExpression uriBuilder)
        {
            foreach (var (nameInRequest, inputParameter, outputParameter, format) in _requestParts)
            {
                if (inputParameter is not null && outputParameter is not null && inputParameter.Location == RequestLocation.Query)
                {
                    yield return AddToQuery(uriBuilder, inputParameter, outputParameter, nameInRequest, format);
                }
            }
        }

        public IEnumerable<MethodBodyStatement> AddHeaders(RequestExpression request, bool addContentHeaders)
        {
            foreach (var (nameInRequest, inputParameter, outputParameter, format) in _requestParts)
            {
                if (outputParameter is null)
                {
                    if (!addContentHeaders && inputParameter is {Location: RequestLocation.Header})
                    {
                        yield return request.Headers.Add(nameInRequest, GetNonParameterizedHeaderValue(nameInRequest, request), format);
                    }
                }
                else if (inputParameter is null)
                {
                    if (!addContentHeaders)
                    {
                        yield return AddRequestConditionsHeaders(request, outputParameter, format);
                    }
                }
                else if (inputParameter.Location == RequestLocation.Header && addContentHeaders == ContentHeaders.Contains(nameInRequest))
                {
                    yield return AddHeader(request, nameInRequest, inputParameter, outputParameter, format);
                }
            }
        }

        private ValueExpression GetNonParameterizedHeaderValue(string nameInRequest, RequestExpression request)
        {
            if (nameInRequest.Equals(SpecialHandledHeaders.ClientRequestId, StringComparison.OrdinalIgnoreCase))
            {
                return request.ClientRequestId;
            }
            if (nameInRequest.Equals(SpecialHandledHeaders.ReturnClientRequestId, StringComparison.OrdinalIgnoreCase))
            {
                return Literal("true");
            }
            if (nameInRequest.Equals(SpecialHandledHeaders.RepeatabilityRequestId, StringComparison.OrdinalIgnoreCase))
            {
                return InvokeGuidNewGuid();
            }
            if (nameInRequest.Equals(SpecialHandledHeaders.RepeatabilityFirstSent, StringComparison.OrdinalIgnoreCase))
            {
                return InvokeDateTimeOffsetNow();
            }

            throw new InvalidOperationException($"Unknown non-parameterized header {nameInRequest}.");
        }

        public MethodBodyStatement AddBody(InputOperation operation, RequestExpression request)
        {
            var bodyParameters = new List<RequestPartSource>();
            foreach (var requestPart in _requestParts)
            {
                var (_, inputParameter, outputParameter, _) = requestPart;
                if (inputParameter is null || outputParameter is null || inputParameter.Location != RequestLocation.Body)
                {
                    continue;
                }

                if (outputParameter == KnownParameters.RequestContent || outputParameter == KnownParameters.RequestContentNullable)
                {
                    return new[]
                    {
                        AddHeaders(request, true).AsStatement(),
                        Assign(request.Content, new RequestContentExpression(outputParameter))
                    };
                }

                switch (operation.RequestBodyMediaType)
                {
                    case BodyMediaType.Multipart or BodyMediaType.Form:
                        bodyParameters.Add(requestPart);
                        break;

                    case BodyMediaType.Binary:
                        var binaryValue = GetValueForRequestPart(inputParameter, outputParameter);
                        return NullCheckRequestPartValue(binaryValue, outputParameter.Type, new[]
                        {
                            AddHeaders(request, true).AsStatement(),
                            Assign(request.Content, RequestContentExpression.Create(RemoveAllNullConditional(binaryValue)))
                        });

                    case BodyMediaType.Text:
                        var stringValue = GetValueForRequestPart(inputParameter, outputParameter);
                        return NullCheckRequestPartValue(stringValue, outputParameter.Type, new[]
                        {
                            AddHeaders(request, true).AsStatement(),
                            Assign(request.Content, New.StringRequestContent(RemoveAllNullConditional(stringValue)))
                        });

                    case var _ when inputParameter.Kind == InputOperationParameterKind.Flattened:
                        return AddFlattenedBody(request);

                    default:
                        var value = GetValueForRequestPart(inputParameter, outputParameter);
                        var serialization = SerializationBuilder.Build(operation.RequestBodyMediaType, inputParameter.Type, outputParameter.Type);
                        return NullCheckRequestPartValue(value, outputParameter.Type, new[]
                        {
                            AddHeaders(request, true).AsStatement(),
                            SerializeContentIntoRequest(request, serialization, RemoveAllNullConditional(value))
                        });
                }
            }

            if (bodyParameters.Any())
            {
                return operation.RequestBodyMediaType == BodyMediaType.Multipart
                    ? AddMultipartBody(request, bodyParameters).AsStatement()
                    : AddFormBody(request, bodyParameters).AsStatement();
            }

            return new MethodBodyStatement();
        }

        public MethodBodyStatement AddUserAgent(HttpMessageExpression message)
            => _fields.UserAgentField is not null
                ? new InvokeInstanceMethodStatement(_fields.UserAgentField, nameof(TelemetryDetails.Apply), message)
                : new MethodBodyStatement();

        private MethodBodyStatement AddToQuery(RawRequestUriBuilderExpression uriBuilder, InputParameter inputParameter, Parameter outputParameter, string nameInRequest, SerializationFormat format)
        {
            var value = GetValueForRequestPart(inputParameter, outputParameter);
            var convertedValue = ConvertToRequestPartType(RemoveAllNullConditional(value), outputParameter.Type, format);
            var escape = !inputParameter.SkipUrlEncoding;

            MethodBodyStatement addToQuery;
            if (inputParameter.Explode)
            {
                addToQuery = new ForeachStatement("param", convertedValue, out var paramVariable)
                {
                    uriBuilder.AppendQuery(nameInRequest, paramVariable, format, escape)
                };
            }
            else
            {
                addToQuery = inputParameter.ArraySerializationDelimiter is { } delimiter
                    ? uriBuilder.AppendQueryDelimited(nameInRequest, convertedValue, delimiter, format, escape)
                    : uriBuilder.AppendQuery(nameInRequest, convertedValue, format, escape);
            }

            if (outputParameter is { IsApiVersionParameter: true, IsOptionalInSignature: true, Initializer: { } })
            {
                return addToQuery;
            }

            return NullCheckRequestPartValue(value, outputParameter.Type, addToQuery);
        }

        private MethodBodyStatement AddRequestConditionsHeaders(RequestExpression request, Parameter outputParameter, SerializationFormat format)
        {
            if (outputParameter.Type.EqualsIgnoreNullable(KnownParameters.MatchConditionsParameter.Type) && outputParameter.Name == KnownParameters.MatchConditionsParameter.Name)
            {
                return NullCheckRequestPartValue(outputParameter, outputParameter.Type, request.Headers.Add(outputParameter));
            }

            if (outputParameter.Type.EqualsIgnoreNullable(KnownParameters.RequestConditionsParameter.Type) && outputParameter.Name == KnownParameters.RequestConditionsParameter.Name)
            {
                return NullCheckRequestPartValue(outputParameter, outputParameter.Type, request.Headers.Add(outputParameter, format));
            }

            throw new InvalidOperationException();
        }

        protected MethodBodyStatement AddHeader(RequestExpression request, string nameInRequest, InputParameter inputParameter, Parameter outputParameter, SerializationFormat format)
        {
            var headerName = inputParameter.HeaderCollectionPrefix ?? nameInRequest;
            var value = GetValueForRequestPart(inputParameter, outputParameter);
            var convertedValue = ConvertToRequestPartType(RemoveAllNullConditional(value), outputParameter.Type, format);

            var addToHeader = inputParameter.ArraySerializationDelimiter is {} delimiter
                ? request.Headers.AddDelimited(headerName, convertedValue, delimiter, format)
                : request.Headers.Add(headerName, convertedValue, format);

            return NullCheckRequestPartValue(value, outputParameter.Type, addToHeader);
        }

        private ValueExpression GetValueForRequestPart(InputParameter inputParameter, Parameter outputParameter)
        {
            switch (inputParameter.Kind)
            {
                case InputOperationParameterKind.Client:
                    return _fields.GetFieldByParameter(outputParameter) ?? throw new InvalidOperationException($"Parameter {outputParameter.Name} should have matching field");

                case InputOperationParameterKind.Constant when outputParameter.DefaultValue is {} defaultValue:
                    return new ConstantExpression(defaultValue);

                case var _ when inputParameter.GroupedBy is {} groupedByInputParameter:
                    var groupedByParameterName = groupedByInputParameter.Name.ToVariableName();
                    var groupedByParameter = _parameters.Single(p => p.Name == groupedByParameterName);
                    var propertyName = groupedByParameter.Type.Implementation switch
                    {
                        ModelTypeProvider modelType => modelType.Fields.GetFieldByParameterName(outputParameter.Name)?.Name,
                        SchemaObjectType schemaObjectType => schemaObjectType.GetPropertyForGroupedParameter(inputParameter.Name).Declaration.Name,
                        _ => throw new InvalidOperationException($"Unexpected object type {groupedByParameter.Type.GetType()} for grouped parameter {outputParameter.Name}")
                    };

                    if (propertyName is null)
                    {
                        throw new InvalidOperationException($"Unable to find object property for grouped parameter {outputParameter.Name} in {groupedByParameter.Type.Name}");
                    }

                    return new MemberExpression(NullConditional(groupedByParameter), propertyName);

                default:
                    return outputParameter;
            }
        }

        private IEnumerable<MethodBodyStatement> AddMultipartBody(RequestExpression request, IEnumerable<RequestPartSource> bodyParameters)
        {
            yield return AddHeaders(request, true).AsStatement();
            yield return Var("content", New.MultipartFormDataContent(), out var multipartContent);

            foreach (var (_, _, parameter, _) in bodyParameters)
            {
                var bodyPartName = parameter!.Name;
                var bodyPartType = parameter.Type;

                if (bodyPartType.Equals(typeof(string)))
                {
                    yield return NullCheckRequestPartValue(parameter, bodyPartType, multipartContent.Add(New.StringRequestContent(parameter), bodyPartName, Null));
                }
                else if (bodyPartType.IsFrameworkType && bodyPartType.FrameworkType == typeof(Stream))
                {
                    yield return NullCheckRequestPartValue(parameter, bodyPartType, multipartContent.Add(RequestContentExpression.Create(parameter), bodyPartName, Null));
                }
                else if (TypeFactory.IsList(bodyPartType))
                {
                    yield return new ForeachStatement("value", parameter, out var item)
                    {
                        multipartContent.Add(RequestContentExpression.Create(item), bodyPartName, Null)
                    };
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            yield return multipartContent.ApplyToRequest(request);
        }

        private IEnumerable<MethodBodyStatement> AddFormBody(RequestExpression request, IEnumerable<RequestPartSource> bodyParameters)
        {
            yield return AddHeaders(request, true).AsStatement();
            yield return Var("content", New.FormUrlEncodedContent(), out var urlContent);

            foreach (var (nameInRequest, inputParameter, outputParameter, _) in bodyParameters)
            {
                var type = outputParameter!.Type;
                var value = GetValueForRequestPart(inputParameter!, outputParameter);

                yield return NullCheckRequestPartValue(value, type, urlContent.Add(nameInRequest, ConvertToString(value, type)));
            }

            yield return Assign(request.Content, urlContent);
        }

        private MethodBodyStatement AddFlattenedBody(RequestExpression request)
        {
            var requestParts = new Dictionary<InputModelProperty, (InputParameter, Parameter)>();
            var conversions = new List<MethodBodyStatement>();
            foreach (var (_, inputParameter, outputParameter, _) in _requestParts)
            {
                if (inputParameter is { FlattenedBodyProperty: { } property } &&  outputParameter is not null )
                {
                    // Special case to match behaviour of the new ChangeTrackingList<> which would be considered uninitialized when empty
                    // It is not clear if that is expected behavior or just coincidence
                    if (property is { IsRequired: false, Type.IsNullable: false } && TypeFactory.IsCollectionType(outputParameter.Type))
                    {
                        var changeTrackingListType = TypeFactory.IsDictionary(outputParameter.Type)
                            ? new CSharpType(typeof(ChangeTrackingDictionary<,>), outputParameter.Type.Arguments)
                            : new CSharpType(typeof(ChangeTrackingList<>), outputParameter.Type.Arguments);

                        var enumerable = new EnumerableExpression(outputParameter);
                        conversions.Add(new IfStatement(Or(Equal(enumerable, Null), Not(enumerable.Any())))
                        {
                            new AssignValueStatement(enumerable, New.Instance(changeTrackingListType))
                        });
                    }

                    requestParts[property] = (inputParameter, outputParameter);
                }
            }

            var serializations = SerializationBuilder.GetPropertySerializations(requestParts.Keys, p =>
            {
                var (inputParameter, outputParameter) = requestParts[p];
                return CreatePropertySerialization(p, inputParameter, outputParameter);
            });

            return new[]
            {
                AddHeaders(request, true).AsStatement(),
                conversions,
                Var("content", New.Utf8JsonRequestContent(), out var content),
                content.JsonWriter.WriteStartObject(),
                JsonSerializationMethodsBuilder.WriteProperties(content.JsonWriter, serializations).AsStatement(),
                content.JsonWriter.WriteEndObject(),
                Assign(request.Content, content)
            };
        }

        private JsonPropertySerialization CreatePropertySerialization(InputModelProperty inputModelProperty, InputParameter inputParameter, Parameter outputParameter)
        {
            var serializedName = inputModelProperty.SerializedName;
            var value = GetValueForRequestPart(inputParameter, outputParameter);
            var valueSerialization = SerializationBuilder.BuildJsonSerialization(inputModelProperty.Type, outputParameter.Type, false);
            var isCollectionParameter = TypeFactory.IsCollectionType(outputParameter.Type);
            var optionalViaNullability = inputModelProperty is { IsRequired: false, Type.IsNullable: false };

            return new JsonPropertySerialization(
                outputParameter.Name,
                value,
                serializedName,
                outputParameter.Type,
                outputParameter.Type.IsNullable && optionalViaNullability ? outputParameter.Type.WithNullable(false) : outputParameter.Type,
                valueSerialization,
                inputModelProperty.IsRequired,
                false,
                false);
        }

        private static MethodBodyStatement SerializeContentIntoRequest(RequestExpression request, ObjectSerialization serialization, ValueExpression expression)
            => serialization switch
            {
                JsonSerialization jsonSerialization => new[]
                {
                    Var("content", New.Utf8JsonRequestContent(), out var content),
                    JsonSerializationMethodsBuilder.SerializeExpression(content.JsonWriter, jsonSerialization, expression),
                    Assign(request.Content, content)
                },
                XmlElementSerialization xmlSerialization => new[]
                {
                    Var("content", New.XmlWriterContent(), out var content),
                    XmlSerializationMethodsBuilder.SerializeExpression(content.XmlWriter, xmlSerialization, expression),
                    Assign(request.Content, content)
                },
                _ => throw new NotImplementedException()
            };

        private bool TryGetUriOrPathRequestPart(in ReadOnlySpan<char> key, in RequestLocation location, [MaybeNullWhen(false)] out InputParameter inputParameter, [MaybeNullWhen(false)] out Parameter outputParameter, out SerializationFormat serializationFormat)
        {
            foreach (var part in _requestParts)
            {
                if (part.InputParameter?.Location == location && part.NameInRequest.AsSpan().Equals(key, StringComparison.InvariantCulture) && part.OutputParameter is not null)
                {
                    inputParameter = part.InputParameter;
                    outputParameter = part.OutputParameter;
                    serializationFormat = part.SerializationFormat;
                    return true;
                }
            }

            inputParameter = null;
            outputParameter = null;
            serializationFormat = SerializationFormat.Default;
            return false;
        }

        private static StringExpression ConvertToString(ValueExpression value, CSharpType fromType)
        {
            if (fromType is { IsFrameworkType: false, Implementation: EnumType enumType })
            {
                return new EnumExpression(enumType, value.NullableStructValue(fromType)).ToSerial();
            }

            return fromType.EqualsIgnoreNullable(typeof(string))
                ? new(value)
                : value.NullableStructValue(fromType).InvokeToString();
        }

        private static MethodBodyStatement NullCheckRequestPartValue(ValueExpression value, CSharpType type, MethodBodyStatement inner)
        {
            if (value is ConstantExpression || !type.IsNullable)
            {
                return inner;
            }

            return type.IsCollectionType()
                ? new IfElseStatement(And(NotEqual(value, Null), InvokeOptional.IsCollectionDefined(value)), inner, null)
                : new IfElseStatement(NotEqual(value, Null), inner, null);
        }

        private static ValueExpression ConvertToRequestPartType(ValueExpression value, CSharpType fromType, SerializationFormat format = SerializationFormat.Default, bool convertOnlyExtendableEnumToString = false)
        {
            if (fromType is { IsFrameworkType: false, Implementation: EnumType enumType } && (!convertOnlyExtendableEnumToString || enumType.IsExtensible))
            {
                return new EnumExpression(enumType, value.NullableStructValue(fromType)).ToSerial();
            }

            if (value is ConstantExpression)
            {
                return value;
            }

            if (fromType.EqualsIgnoreNullable(typeof(ContentType)))
            {
                return value.NullableStructValue(fromType).InvokeToString();
            }

            if (fromType.EqualsIgnoreNullable(typeof(BinaryData)) && format is SerializationFormat.Bytes_Base64 or SerializationFormat.Bytes_Base64Url)
            {
                return new BinaryDataExpression(value).ToArray();
            }

            return value.NullableStructValue(fromType);
        }
    }
}

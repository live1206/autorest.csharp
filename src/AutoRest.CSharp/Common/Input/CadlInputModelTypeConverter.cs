﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class CadlInputModelTypeConverter : JsonConverter<InputModelType>
    {
        private readonly CadlReferenceHandler _referenceHandler;

        public CadlInputModelTypeConverter(CadlReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputModelType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => ReadModelType(ref reader, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputModelType value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        private static InputModelType? ReadModelType(ref Utf8JsonReader reader, JsonSerializerOptions options, ReferenceResolver resolver)
            => reader.ReadReferenceAndResolve<InputModelType>(resolver) ?? CreateModelType(ref reader, null, null, options, resolver);

        public static InputModelType CreateModelType(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = id == null && name == null;
            var properties = new List<InputModelProperty>();

            string? ns = null;
            string? accessibility = null;
            string? description = null;
            InputModelTypeUsage? usage = null;
            InputModelType? baseModel = null;
            InputModelType? model = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputType.Name), ref name)
                    || reader.TryReadString(nameof(InputModelType.Namespace), ref ns)
                    || reader.TryReadString(nameof(InputModelType.Accessibility), ref accessibility)
                    || reader.TryReadString(nameof(InputModelType.Description), ref description)
                    || reader.TryReadWithConverter(nameof(InputModelType.Usage), options, ref usage)
                    || reader.TryReadWithConverter(nameof(InputModelType.BaseModel), options, ref baseModel);

                if (isKnownProperty)
                {
                    continue;
                }

                if (reader.GetString() == nameof(InputModelType.Properties))
                {
                    model = CreateInputModelTypeInstance(id, name, ns, accessibility, description, usage, baseModel, properties, resolver);
                    reader.Read();
                    CreateProperties(ref reader, properties, options);
                    if (reader.TokenType != JsonTokenType.EndObject)
                    {
                        throw new JsonException($"{nameof(InputModelType)}.{nameof(InputModelType.Properties)} must be the last defined property.");
                    }
                }
                else
                {
                    reader.SkipProperty();
                }
            }

            return model ?? CreateInputModelTypeInstance(id, name, ns, accessibility, description, usage, baseModel, properties, resolver);
        }

        private static InputModelType CreateInputModelTypeInstance(string? id, string? name, string? ns, string? accessibility, string? description, InputModelTypeUsage? usage, InputModelType? baseModel, List<InputModelProperty> properties, ReferenceResolver resolver)
        {
            name = name ?? throw new JsonException("Model must have name");
            var model = new InputModelType(name, ns, accessibility, description, usage ?? InputModelTypeUsage.RoundTrip, properties, baseModel, new List<InputModelType>(), null);
            if (id != null)
            {
                resolver.AddReference(id, model);
            }
            return model;
        }

        private static void CreateProperties(ref Utf8JsonReader reader, ICollection<InputModelProperty> properties, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                var property = reader.ReadWithConverter<InputModelProperty>(options);
                properties.Add(property ?? throw new JsonException($"null {nameof(InputModelProperty)} isn't allowed"));
            }
            reader.Read();
        }
    }
}
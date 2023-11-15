﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Mgmt.Report;
using AutoRest.CSharp.Output.Models.Types;
using Azure.ResourceManager.Models;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class ReferenceTypePropertyChooser
    {
        internal const string OptionalPropertiesName = "OptionalProperties";

        private static ConcurrentDictionary<InputType, CSharpType?> _valueCache = new ConcurrentDictionary<InputType, CSharpType?>();

        private static readonly Type _locationType = typeof(Azure.Core.AzureLocation);
        private static readonly Type _resourceIdentifierType = typeof(Azure.Core.ResourceIdentifier);
        private static readonly Type _resourceTypeType = typeof(Azure.Core.ResourceType);

        public static ObjectTypeProperty? GetExactMatchForReferenceType(ObjectTypeProperty originalType, Type frameworkType)
        {
            return FindSimpleReplacements(originalType, frameworkType);
        }

        public static bool TryGetCachedExactMatch(InputType inputType, out CSharpType? result)
        {
            return _valueCache.TryGetValue(inputType, out result);
        }

        public static CSharpType? GetExactMatch(MgmtObjectType typeToReplace, SourceInputModel? sourceInputModel)
        {
            if (_valueCache.TryGetValue(typeToReplace.InputModel, out var result))
                return result;

            if (!typeToReplace.ShouldNotReplaceForProperty())
            {
                foreach (Type replacementType in ReferenceClassFinder.GetPropertyReferenceClassCollection())
                {
                    var typeToReplacePropertyNames = typeToReplace.MyProperties.Select(p => p.Declaration.Name).ToHashSet();
                    var attributeObj = replacementType.GetCustomAttributes()?.Where(a => a.GetType().Name == ReferenceClassFinder.PropertyReferenceTypeAttributeName).First();
                    var optionalPropertiesForMatch = new HashSet<string>((attributeObj?.GetType().GetProperty(OptionalPropertiesName)?.GetValue(attributeObj) as string[])!);
                    List<PropertyInfo> replacementTypeProperties = replacementType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => !optionalPropertiesForMatch.Contains(p.Name) || typeToReplacePropertyNames.Contains(p.Name)).ToList();
                    List<ObjectTypeProperty> typeToReplaceProperties = typeToReplace.MyProperties.ToList();

                    if (PropertyMatchDetection.IsEqual(replacementType, typeToReplace, replacementTypeProperties, typeToReplaceProperties, new Dictionary<Type, CSharpType> { { replacementType, typeToReplace.Type } }))
                    {
                        result = CSharpType.FromSystemType(sourceInputModel, replacementType);
                        _valueCache.TryAdd(typeToReplace.InputModel, result);
                        return result;
                    }
                }
            }
            else
            {
                MgmtReport.Instance.TransformSection.AddTransformLog(new TransformItem(TransformTypeName.NoPropertyTypeReplacement, typeToReplace.Type.Name), typeToReplace.Type.Name, "NoReplaceForType:" + typeToReplace.Type.Name);
            }
            _valueCache.TryAdd(typeToReplace.InputModel, null);
            return null;
        }

        private static ObjectTypeProperty? FindSimpleReplacements(ObjectTypeProperty originalType, Type frameworkType)
        {
            //TODO for core generation this list is small enough we can simply define each of them here.
            //eventually we might want to come up with a more robust way of doing this

            bool isString = frameworkType == typeof(string);

            if (originalType.Declaration.Name == "Location" && (isString || frameworkType.Name == _locationType.Name))
                return GetObjectTypeProperty(originalType, _locationType);

            if (originalType.Declaration.Name == "ResourceType" && (isString || frameworkType.Name == _resourceTypeType.Name))
                return GetObjectTypeProperty(originalType, _resourceTypeType);

            if (originalType.Declaration.Name == "Id" && (isString || frameworkType.Name == _resourceIdentifierType.Name))
                return GetObjectTypeProperty(originalType, _resourceIdentifierType);

            return null;
        }

        public static ObjectTypeProperty GetObjectTypeProperty(ObjectTypeProperty originalType, CSharpType replacementCSharpType)
        {
            var extraDescription = IsReplacementTypeManagedServiceIdentity(replacementCSharpType) ? originalType.CreateExtraDescriptionWithManagedServiceIdentity() : string.Empty;
            var originalDescription = originalType.Description;
            var periodAndSpace = originalDescription.ToString().EndsWith(".") ? " " : ". ";
            var description = string.IsNullOrEmpty(extraDescription) ? originalDescription : $"{originalDescription}{periodAndSpace}{extraDescription}";
            return new ObjectTypeProperty(
                    new MemberDeclarationOptions(originalType.Declaration.Accessibility, originalType.Declaration.Name, replacementCSharpType),
                    description,
                    originalType.IsReadOnly,
                    originalType.InputModelProperty
                    );
        }

        private static bool IsReplacementTypeManagedServiceIdentity(CSharpType replacementCSharpType)
        {
            return !replacementCSharpType.IsFrameworkType && replacementCSharpType.Implementation is SystemObjectType systemObjectType && systemObjectType.SystemType == typeof(ManagedServiceIdentity);
        }
    }
}

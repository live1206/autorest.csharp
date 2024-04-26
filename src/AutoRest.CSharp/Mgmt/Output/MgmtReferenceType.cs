﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Report;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtReferenceType : MgmtObjectType
    {
        private static HashSet<string> PropertyReferenceTypeModels = new HashSet<string>
        {
            "ArmPlan",
            "ArmSku",
            "EncryptionProperties",
            "ExtendedLocation",
            "ManagedServiceIdentity",
            "KeyVaultProperties",
            "ResourceProviderData",
            "SystemAssignedServiceIdentity",
            "SystemData",
            "UserAssignedIdentity",
            "WritableSubResource"
        };

        private static HashSet<string> TypeReferenceTypeModels = new HashSet<string>
        {
            "OperationStatusResult"
        };

        // ReferenceType is only applied to ResourceData and TrackedResourceData in custom code, not handled by generator

        public static bool IsPropertyReferenceType(Schema schema)
        {
            // reference types are only applied for Azure.ResourceManager
            if (!Configuration.MgmtConfiguration.IsArmCore)
            {
                return false;
            }

            // Azure.ResourceManager.Models.SystemData is PropertyReferenceType, but Azure.ResourceManager.Resources.Models.SystemData is not
            if (schema.Language.Default.Name == "SystemData")
            {
                if ("Azure.ResourceManager.Models" == schema.Extensions?.Namespace)
                {
                    return true;
                }
                return false;
            }

            return PropertyReferenceTypeModels.Contains(schema.Language.Default.Name);
        }

        public static bool IsTypeReferenceType(Schema schema)
        {
            if (!Configuration.MgmtConfiguration.IsArmCore)
            {
                return false;
            }

            return TypeReferenceTypeModels.Contains(schema.Language.Default.Name);
        }

        public MgmtReferenceType(ObjectSchema objectSchema, string? name = default, string? nameSpace = default) : base(objectSchema, name, nameSpace)
        {
            JsonConverter = (IsPropertyReferenceType(objectSchema) || IsTypeReferenceType(ObjectSchema))
                ? new JsonConverterProvider(this, _sourceInputModel)
                : null;
        }

        protected override ObjectTypeProperty CreatePropertyType(ObjectTypeProperty objectTypeProperty)
        {
            if (objectTypeProperty.ValueType != null && objectTypeProperty.ValueType.IsFrameworkType)
            {
                var newProperty = ReferenceTypePropertyChooser.GetExactMatchForReferenceType(objectTypeProperty, objectTypeProperty.ValueType.FrameworkType);
                if (newProperty != null)
                {
                    string fullSerializedName = this.GetFullSerializedName(objectTypeProperty);
                    MgmtReport.Instance.TransformSection.AddTransformLogForApplyChange(
                        new TransformItem(TransformTypeName.ReplacePropertyType, fullSerializedName),
                       fullSerializedName,
                        "ReplacePropertyType", objectTypeProperty.Declaration.Type.ToString(), newProperty.Declaration.Type.ToString());
                    return newProperty;
                }
            }

            return objectTypeProperty;
        }

        protected override CSharpType? CreateInheritedType() => base.CreateInheritedType();

        // the reference types do not need raw data field
        public override ObjectTypeProperty? RawDataField => null;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Report;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtReferenceType : MgmtObjectType
    {
        public MgmtReferenceType(ObjectSchema objectSchema, string? name = default, string? nameSpace = default) : base(objectSchema, name, nameSpace)
        {
            JsonConverter = (ObjectSchema.Extensions?.MgmtPropertyReferenceType == true || ObjectSchema.Extensions?.MgmtTypeReferenceType == true)
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

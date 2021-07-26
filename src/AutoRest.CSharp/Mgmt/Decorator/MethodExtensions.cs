﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Types;
using Azure;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class MethodExtensions
    {
        /// <summary>
        /// Returns the expected return type of the RestClientMethod.
        /// If the RestClientMethod represents a List operation, it will return IReadOnlyList<Item> where Item is the element type
        /// of the array
        /// If the RestClientMethod is anything else, it will return its original return type.
        /// </summary>
        /// <param name="method">the <see cref="RestClientMethod"/></param>
        /// <param name="operationGroup">the <see cref="OperationGroup"/> this RestClientMethod belongs</param>
        /// <param name="context">the current building context</param>
        /// <returns>a tuple with the first argument is the expected return type of this function and the second argument is a boolean indicating whether this function is returning a collection</returns>
        public static (CSharpType? BodyType, bool IsListFunction) GetBodyTypeForList(this RestClientMethod method, OperationGroup operationGroup, BuildContext<MgmtOutputLibrary> context)
        {
            var returnType = method.ReturnType;
            if (returnType == null)
                return (null, false);

            if (returnType.IsFrameworkType || returnType.Implementation is not SchemaObjectType)
                return (returnType, false);

            var schemaObject = (SchemaObjectType)returnType.Implementation;
            var valueProperty = GetValueProperty(schemaObject);

            if (valueProperty == null) // The returnType does not have a value of array in it, therefore it cannot be a list
            {
                return (returnType, false);
            }
            // first we try to get the resource data - this could be a resource
            if (context.Library.TryGetResourceData(operationGroup, out var resourceData))
            {
                if (valueProperty.ValueType.EqualsByName(new CSharpType(typeof(IReadOnlyList<>), resourceData.Type)))
                {
                    return (new CSharpType(typeof(IReadOnlyList<>), context.Library.GetArmResource(operationGroup).Type), true);
                }
            }

            // otherwise this must be a non-resource, but still a list
            return (new CSharpType(typeof(IReadOnlyList<>), valueProperty.Declaration.Type.Arguments), true);
        }

        private static ObjectTypeProperty? GetValueProperty(SchemaObjectType schemaObject)
        {
            return schemaObject.Properties.FirstOrDefault(p => p.Declaration.Name == "Value" &&
                p.Declaration.Type.IsFrameworkType && p.Declaration.Type.FrameworkType == typeof(IReadOnlyList<>));
        }

        /// <summary>
        /// Get the body type of a ClientMethod
        /// </summary>
        /// <param name="clientMethod">the ClientMethod</param>
        /// <returns>the body type of the ClientMethod</returns>
        public static CSharpType? GetBodyType(this ClientMethod clientMethod)
        {
            return clientMethod.RestClientMethod.ReturnType;
        }

        /// <summary>
        /// Get the proper return type of the ClientMethod considering the async status
        /// </summary>
        /// <param name="clientMethod">the ClientMethod</param>
        /// <param name="async">Is this method async?</param>
        /// <returns>the response type of the ClientMethod</returns>
        public static CSharpType GetResponseType(this ClientMethod clientMethod, bool async)
        {
            var bodyType = clientMethod.GetBodyType();
            var responseType = bodyType != null ? new CSharpType(typeof(Response<>), bodyType) : typeof(Response);
            return responseType.WrapAsync(async);
        }

        /// <summary>
        /// Get the proper return type of the PagingMethod considering the async status
        /// </summary>
        /// <param name="pagingMethod">the PagingMethod</param>
        /// <param name="async">Is this method async?</param>
        /// <returns>the response type of the PagingMethod</returns>
        public static CSharpType GetResponseType(this PagingMethod pagingMethod, bool async)
        {
            var pageType = pagingMethod.PagingResponse.ItemType;
            return pageType.WrapPageable(async);
        }

        /// <summary>
        /// Checks if parent exists in path parameters
        /// </summary>
        /// <param name="clientMethod">Rest client method</param>
        /// <param name="parentResourceType">Parent resource type</param>
        public static bool IsParentExistsInPathParamaters(this RestClientMethod clientMethod, string parentResourceType)
        {
            var isParentExistsInPathParams = false;
            if (clientMethod.Operation?.Requests.FirstOrDefault().Protocol.Http is HttpRequest httpRequest)
            {
                // Example - "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}/subParents/{instanceId}/children"
                var fullPath = httpRequest.Path;

                // This will replace -
                // "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}/subParents/{instanceId}/children" with
                // "/subscriptions/resourceGroups/providers/Microsoft.Compute/parents/subParents/children" in order to find the parent
                var path = Regex.Replace(fullPath, @"\{[a-zA-Z]+\}\/", "");
                var isParentFound = path.IndexOf(parentResourceType);
                if (isParentFound != -1)
                {
                    // Parent is found, now check if the parent exists in path parameters
                    var parentArr = parentResourceType.Split('/');
                    var fullPathArr = fullPath.Split('/');
                    foreach (var parentSegment in parentArr)
                    {
                        var index = Array.IndexOf(fullPathArr, parentSegment);
                        if (index + 1 < fullPathArr.Length && fullPathArr[index + 1].StartsWith('{'))
                        {
                            char[] charsToTrim = { '{', '}' };
                            var parentParamName = fullPathArr[index + 1].Trim(charsToTrim);
                            isParentExistsInPathParams = clientMethod.PathParameters.Any(p => p.Name == parentParamName);
                            if (isParentExistsInPathParams)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return isParentExistsInPathParams;
        }

    }
}
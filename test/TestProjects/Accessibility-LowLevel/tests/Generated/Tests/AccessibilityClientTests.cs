// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Accessibility_LowLevel;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Accessibility_LowLevel.Tests
{
    public partial class AccessibilityClientTests : Accessibility_LowLevelTestBase
    {
        public AccessibilityClientTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Operation_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AccessibilityClient client = CreateAccessibilityClient(endpoint, credential);

            using RequestContent content = null;
            Response response = await client.OperationAsync(content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task Operation_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            AccessibilityClient client = CreateAccessibilityClient(endpoint, credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = await client.OperationAsync(content);
        }
    }
}
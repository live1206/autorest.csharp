// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using custom_baseUrl_LowLevel;

namespace custom_baseUrl_LowLevel.Samples
{
    public class Samples_PathsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new PathsClient("<host>", credential);

            Response response = client.GetEmpty("<accountName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEmpty_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new PathsClient("<host>", credential);

            Response response = client.GetEmpty("<accountName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new PathsClient("<host>", credential);

            Response response = await client.GetEmptyAsync("<accountName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmpty_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new PathsClient("<host>", credential);

            Response response = await client.GetEmptyAsync("<accountName>");
            Console.WriteLine(response.Status);
        }
    }
}

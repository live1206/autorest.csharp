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
using Server.Path.Single;

namespace Server.Path.Single.Samples
{
    public class Samples_SingleClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MyOp()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new SingleClient(endpoint);

            Response response = client.MyOp();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MyOp_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new SingleClient(endpoint);

            Response response = client.MyOp();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MyOp_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new SingleClient(endpoint);

            Response response = await client.MyOpAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MyOp_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new SingleClient(endpoint);

            Response response = await client.MyOpAsync();
            Console.WriteLine(response.Status);
        }
    }
}

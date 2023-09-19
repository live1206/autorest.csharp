// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using ClientAndOperationGroup;
using NUnit.Framework;

namespace ClientAndOperationGroup.Samples
{
    internal class Samples_Gamma
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Four(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FourAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Four(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FourAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Five(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FiveAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Five(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FiveAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}

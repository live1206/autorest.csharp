// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Authentication.Union;
using Azure;
using NUnit.Framework;

namespace Authentication.Union.Samples
{
    public class Samples_UnionClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ValidKey()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = client.ValidKey();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ValidKey_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = await client.ValidKeyAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ValidKey_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = client.ValidKey();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ValidKey_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = await client.ValidKeyAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ValidToken()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = client.ValidToken();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ValidToken_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = await client.ValidTokenAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ValidToken_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = client.ValidToken();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ValidToken_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            UnionClient client = new UnionClient(credential);

            Response response = await client.ValidTokenAsync();
            Console.WriteLine(response.Status);
        }
    }
}

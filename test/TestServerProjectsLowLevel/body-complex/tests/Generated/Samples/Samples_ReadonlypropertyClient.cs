// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using body_complex_LowLevel;

namespace body_complex_LowLevel.Samples
{
    public class Samples_ReadonlypropertyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("size").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("size").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutValid()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            RequestContent content = RequestContent.Create(new object());
            Response response = client.PutValid(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            RequestContent content = RequestContent.Create(new
            {
                size = 1234,
            });
            Response response = client.PutValid(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutValid_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutValidAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ReadonlypropertyClient client = new ReadonlypropertyClient(credential);

            RequestContent content = RequestContent.Create(new
            {
                size = 1234,
            });
            Response response = await client.PutValidAsync(content);
            Console.WriteLine(response.Status);
        }
    }
}

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
using MixApiVersion;
using NUnit.Framework;

namespace MixApiVersion.Samples
{
    public class Samples_MixApiVersionClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = client.Delete("<name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = client.Delete("<name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = await client.DeleteAsync("<name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = await client.DeleteAsync("<name>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Read()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = client.Read(1234, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Read_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = client.Read(1234, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tag").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Read_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = await client.ReadAsync(1234, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Read_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            Response response = await client.ReadAsync(1234, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tag").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            var data = new
            {
                age = 1234,
            };

            Response response = client.Create(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            var data = new
            {
                tag = "<tag>",
                age = 1234,
            };

            Response response = client.Create(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tag").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            var data = new
            {
                age = 1234,
            };

            Response response = await client.CreateAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            var data = new
            {
                tag = "<tag>",
                age = 1234,
            };

            Response response = await client.CreateAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tag").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPets()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            foreach (var item in client.GetPets(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("petId").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPets_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            foreach (var item in client.GetPets(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("petId").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPets_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            await foreach (var item in client.GetPetsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("petId").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPets_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new MixApiVersionClient(endpoint);

            await foreach (var item in client.GetPetsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("petId").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    internal class Samples_CollectionsString
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCollectionsString()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response response = client.GetCollectionsString(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCollectionsString_AllParameters()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response response = client.GetCollectionsString(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCollectionsString_Convenience()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response<CollectionsStringProperty> response = client.GetCollectionsString();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCollectionsString_AllParameters_Convenience()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response<CollectionsStringProperty> response = client.GetCollectionsString();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCollectionsString_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response response = await client.GetCollectionsStringAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCollectionsString_AllParameters_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response response = await client.GetCollectionsStringAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCollectionsString_Convenience_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response<CollectionsStringProperty> response = await client.GetCollectionsStringAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCollectionsString_AllParameters_Convenience_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            Response<CollectionsStringProperty> response = await client.GetCollectionsStringAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new List<object>()
{
"<property>"
},
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new List<object>()
{
"<property>"
},
            });
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_Convenience()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            CollectionsStringProperty body = new CollectionsStringProperty(new List<string>()
{
"<property>"
});
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            CollectionsStringProperty body = new CollectionsStringProperty(new List<string>()
{
"<property>"
});
            Response response = client.Put(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new List<object>()
{
"<property>"
},
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new List<object>()
{
"<property>"
},
            });
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            CollectionsStringProperty body = new CollectionsStringProperty(new List<string>()
{
"<property>"
});
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            CollectionsString client = new ValueTypesClient().GetCollectionsStringClient(apiVersion: "1.0.0");

            CollectionsStringProperty body = new CollectionsStringProperty(new List<string>()
{
"<property>"
});
            Response response = await client.PutAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}

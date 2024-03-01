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
using Serialization.EncodedName.Json;
using Serialization.EncodedName.Json.Models;

namespace Serialization.EncodedName.Json.Samples
{
    public partial class Samples_Property
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_Send_ShortVersion()
        {
            Property client = new JsonClient().GetPropertyClient();

            using RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_Send_ShortVersion_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            using RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_Send_ShortVersion_Convenience()
        {
            Property client = new JsonClient().GetPropertyClient();

            JsonEncodedNameModel jsonEncodedNameModel = new JsonEncodedNameModel(true);
            Response response = client.Send(jsonEncodedNameModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_Send_ShortVersion_Convenience_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            JsonEncodedNameModel jsonEncodedNameModel = new JsonEncodedNameModel(true);
            Response response = await client.SendAsync(jsonEncodedNameModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_Send_AllParameters()
        {
            Property client = new JsonClient().GetPropertyClient();

            using RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_Send_AllParameters_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            using RequestContent content = RequestContent.Create(new
            {
                wireName = true,
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_Send_AllParameters_Convenience()
        {
            Property client = new JsonClient().GetPropertyClient();

            JsonEncodedNameModel jsonEncodedNameModel = new JsonEncodedNameModel(true);
            Response response = client.Send(jsonEncodedNameModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_Send_AllParameters_Convenience_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            JsonEncodedNameModel jsonEncodedNameModel = new JsonEncodedNameModel(true);
            Response response = await client.SendAsync(jsonEncodedNameModel);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_GetProperty_ShortVersion()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response response = client.GetProperty(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("wireName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_GetProperty_ShortVersion_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response response = await client.GetPropertyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("wireName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_GetProperty_ShortVersion_Convenience()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response<JsonEncodedNameModel> response = client.GetProperty();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_GetProperty_ShortVersion_Convenience_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response<JsonEncodedNameModel> response = await client.GetPropertyAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_GetProperty_AllParameters()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response response = client.GetProperty(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("wireName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_GetProperty_AllParameters_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response response = await client.GetPropertyAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("wireName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Property_GetProperty_AllParameters_Convenience()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response<JsonEncodedNameModel> response = client.GetProperty();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Property_GetProperty_AllParameters_Convenience_Async()
        {
            Property client = new JsonClient().GetPropertyClient();

            Response<JsonEncodedNameModel> response = await client.GetPropertyAsync();
        }
    }
}

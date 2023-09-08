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
using _Type._Array;

namespace _Type._Array.Samples
{
    internal class Samples_DatetimeValue
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDatetimeValue()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            Response response = client.GetDatetimeValue(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDatetimeValue_AllParameters()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            Response response = client.GetDatetimeValue(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDatetimeValue_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            Response response = await client.GetDatetimeValueAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDatetimeValue_AllParameters_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            Response response = await client.GetDatetimeValueAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDatetimeValue_Convenience_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var result = await client.GetDatetimeValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var data = new[] {
    "2022-05-10T14:14:57.0310000Z"
};

            Response response = client.Put(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var data = new[] {
    "2022-05-10T14:14:57.0310000Z"
};

            Response response = client.Put(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var data = new[] {
    "2022-05-10T14:14:57.0310000Z"
};

            Response response = await client.PutAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var data = new[] {
    "2022-05-10T14:14:57.0310000Z"
};

            Response response = await client.PutAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            var client = new ArrayClient().GetDatetimeValueClient("1.0.0");

            var body = new DateTimeOffset[]
            {
    DateTimeOffset.UtcNow
            };
            var result = await client.PutAsync(body);
        }
    }
}

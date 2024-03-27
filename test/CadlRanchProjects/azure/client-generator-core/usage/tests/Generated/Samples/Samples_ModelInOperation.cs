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
using _Specs_.Azure.ClientGenerator.Core.Usage.Models;

namespace _Specs_.Azure.ClientGenerator.Core.Usage.Samples
{
    public partial class Samples_ModelInOperation
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_InputToInputOutput_ShortVersion()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.InputToInputOutput(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_InputToInputOutput_ShortVersion_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.InputToInputOutputAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_InputToInputOutput_ShortVersion_Convenience()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            InputModel body = new InputModel("<name>");
            Response response = client.InputToInputOutput(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_InputToInputOutput_ShortVersion_Convenience_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            InputModel body = new InputModel("<name>");
            Response response = await client.InputToInputOutputAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_InputToInputOutput_AllParameters()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.InputToInputOutput(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_InputToInputOutput_AllParameters_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.InputToInputOutputAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_InputToInputOutput_AllParameters_Convenience()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            InputModel body = new InputModel("<name>");
            Response response = client.InputToInputOutput(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_InputToInputOutput_AllParameters_Convenience_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            InputModel body = new InputModel("<name>");
            Response response = await client.InputToInputOutputAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_OutputToInputOutput_ShortVersion()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response response = client.OutputToInputOutput(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_OutputToInputOutput_ShortVersion_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response response = await client.OutputToInputOutputAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_OutputToInputOutput_ShortVersion_Convenience()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response<OutputModel> response = client.OutputToInputOutput();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_OutputToInputOutput_ShortVersion_Convenience_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response<OutputModel> response = await client.OutputToInputOutputAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_OutputToInputOutput_AllParameters()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response response = client.OutputToInputOutput(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_OutputToInputOutput_AllParameters_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response response = await client.OutputToInputOutputAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ModelInOperation_OutputToInputOutput_AllParameters_Convenience()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response<OutputModel> response = client.OutputToInputOutput();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ModelInOperation_OutputToInputOutput_AllParameters_Convenience_Async()
        {
            ModelInOperation client = new UsageClient().GetModelInOperationClient();

            Response<OutputModel> response = await client.OutputToInputOutputAsync();
        }
    }
}

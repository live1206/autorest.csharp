// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using AuthoringTypeSpec;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace AuthoringTypeSpec.Samples
{
    public partial class Samples_Projects
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_GetProject_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetProject("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_GetProject_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetProjectAsync("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_GetProject_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetProject("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_GetProject_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetProjectAsync("<projectName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_GetProjects_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            foreach (BinaryData item in client.GetProjects())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_GetProjects_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            await foreach (BinaryData item in client.GetProjectsAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_GetProjects_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            foreach (BinaryData item in client.GetProjects())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("settings").ToString());
                Console.WriteLine(result.GetProperty("multilingual").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_GetProjects_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            await foreach (BinaryData item in client.GetProjectsAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("projectName").ToString());
                Console.WriteLine(result.GetProperty("projectKind").ToString());
                Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
                Console.WriteLine(result.GetProperty("settings").ToString());
                Console.WriteLine(result.GetProperty("multilingual").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_CreateOrUpdate_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                projectKind = "CustomSingleLabelClassification",
                storageInputContainerName = "<storageInputContainerName>",
                language = "<language>",
            });
            Operation<BinaryData> operation = client.CreateOrUpdate(WaitUntil.Completed, "<projectName>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_CreateOrUpdate_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                projectKind = "CustomSingleLabelClassification",
                storageInputContainerName = "<storageInputContainerName>",
                language = "<language>",
            });
            Operation<BinaryData> operation = await client.CreateOrUpdateAsync(WaitUntil.Completed, "<projectName>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_CreateOrUpdate_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                projectKind = "CustomSingleLabelClassification",
                storageInputContainerName = "<storageInputContainerName>",
                settings = new object(),
                multilingual = true,
                description = "<description>",
                language = "<language>",
            });
            Operation<BinaryData> operation = client.CreateOrUpdate(WaitUntil.Completed, "<projectName>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_CreateOrUpdate_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                projectKind = "CustomSingleLabelClassification",
                storageInputContainerName = "<storageInputContainerName>",
                settings = new object(),
                multilingual = true,
                description = "<description>",
                language = "<language>",
            });
            Operation<BinaryData> operation = await client.CreateOrUpdateAsync(WaitUntil.Completed, "<projectName>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("projectName").ToString());
            Console.WriteLine(result.GetProperty("projectKind").ToString());
            Console.WriteLine(result.GetProperty("storageInputContainerName").ToString());
            Console.WriteLine(result.GetProperty("settings").ToString());
            Console.WriteLine(result.GetProperty("multilingual").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("language").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastModifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastTrainedDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastDeployedDateTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_Delete_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Delete(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_Delete_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.DeleteAsync(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Project_Delete_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Delete(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Project_Delete_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.DeleteAsync(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Export_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Export(WaitUntil.Completed, "<projectName>", "<projectFileVersion>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Export_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.ExportAsync(WaitUntil.Completed, "<projectName>", "<projectFileVersion>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Export_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Export(WaitUntil.Completed, "<projectName>", "<projectFileVersion>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Export_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.ExportAsync(WaitUntil.Completed, "<projectName>", "<projectFileVersion>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Importx_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Importx(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Importx_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.ImportxAsync(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Importx_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = client.Importx(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Importx_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            Operation operation = await client.ImportxAsync(WaitUntil.Completed, "<projectName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Train_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                modelLabel = "<modelLabel>",
            });
            Operation operation = client.Train(WaitUntil.Completed, "<projectName>", content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Train_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                modelLabel = "<modelLabel>",
            });
            Operation operation = await client.TrainAsync(WaitUntil.Completed, "<projectName>", content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Projects_Train_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                modelLabel = "<modelLabel>",
            });
            Operation operation = client.Train(WaitUntil.Completed, "<projectName>", content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Projects_Train_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Projects client = new AuthoringTypeSpecClient(endpoint).GetProjectsClient(apiVersion: "2022-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                modelLabel = "<modelLabel>",
            });
            Operation operation = await client.TrainAsync(WaitUntil.Completed, "<projectName>", content);
        }
    }
}
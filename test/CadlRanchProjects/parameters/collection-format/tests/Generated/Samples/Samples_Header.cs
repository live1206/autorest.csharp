// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using Parameters.CollectionFormat;

namespace Parameters.CollectionFormat.Samples
{
    internal class Samples_Header
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Csv()
        {
            Header client = new CollectionFormatClient().GetHeaderClient(apiVersion: "1.0.0");

            Response response = client.Csv(new List<string>()
{
"<colors>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Csv_AllParameters()
        {
            Header client = new CollectionFormatClient().GetHeaderClient(apiVersion: "1.0.0");

            Response response = client.Csv(new List<string>()
{
"<colors>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Csv_Async()
        {
            Header client = new CollectionFormatClient().GetHeaderClient(apiVersion: "1.0.0");

            Response response = await client.CsvAsync(new List<string>()
{
"<colors>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Csv_AllParameters_Async()
        {
            Header client = new CollectionFormatClient().GetHeaderClient(apiVersion: "1.0.0");

            Response response = await client.CsvAsync(new List<string>()
{
"<colors>"
});
            Console.WriteLine(response.Status);
        }
    }
}

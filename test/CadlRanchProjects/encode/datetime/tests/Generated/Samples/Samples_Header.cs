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

namespace Encode.Datetime.Samples
{
    internal class Samples_Header
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Default(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_AllParameters()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Default(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.DefaultAsync(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_AllParameters_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.DefaultAsync(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Rfc3339()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Rfc3339(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Rfc3339_AllParameters()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Rfc3339(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Rfc3339_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.Rfc3339Async(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Rfc3339_AllParameters_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.Rfc3339Async(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Rfc7231()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Rfc7231(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Rfc7231_AllParameters()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.Rfc7231(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Rfc7231_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.Rfc7231Async(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Rfc7231_AllParameters_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.Rfc7231Async(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnixTimestamp()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.UnixTimestamp(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnixTimestamp_AllParameters()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.UnixTimestamp(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnixTimestamp_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.UnixTimestampAsync(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnixTimestamp_AllParameters_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.UnixTimestampAsync(DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnixTimestampArray()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.UnixTimestampArray(new DateTimeOffset[] { DateTimeOffset.UtcNow });
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnixTimestampArray_AllParameters()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = client.UnixTimestampArray(new DateTimeOffset[] { DateTimeOffset.UtcNow });
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnixTimestampArray_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.UnixTimestampArrayAsync(new DateTimeOffset[] { DateTimeOffset.UtcNow });
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnixTimestampArray_AllParameters_Async()
        {
            var client = new DatetimeClient().GetHeaderClient("1.0.0");

            Response response = await client.UnixTimestampArrayAsync(new DateTimeOffset[] { DateTimeOffset.UtcNow });
            Console.WriteLine(response.Status);
        }
    }
}
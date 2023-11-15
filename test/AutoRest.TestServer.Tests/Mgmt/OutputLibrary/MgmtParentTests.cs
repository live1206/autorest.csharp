// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using AutoRest.CSharp.Mgmt.Decorator;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.OutputLibrary
{
    internal class MgmtParentTests : OutputLibraryTestBase
    {
        public MgmtParentTests() : base("MgmtParent") { }

        [TestCase("VirtualMachineExtensionImageResource", "SubscriptionResourceExtensions")]
        [TestCase("AvailabilitySetResource", "ResourceGroupResourceExtensions")]
        [TestCase("DedicatedHostResource", "DedicatedHostGroupResource")]
        public void TestParent(string resourceName, string parentName)
        {
            var resource = _library.ArmResources.FirstOrDefault(r => r.Type.Name == resourceName);
            Assert.NotNull(resource);
            var parents = resource.GetParents(_library);
            Assert.IsTrue(parents.Any(p => p.Type.Name == parentName));
        }
    }
}

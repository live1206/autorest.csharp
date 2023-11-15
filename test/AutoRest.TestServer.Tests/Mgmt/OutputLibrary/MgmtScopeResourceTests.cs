// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System.Linq;
using AutoRest.CSharp.Mgmt.Decorator;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.OutputLibrary
{
    internal class MgmtScopeResourceTests : OutputLibraryTestBase
    {
        public MgmtScopeResourceTests() : base("MgmtScopeResource") { }

        [TestCase("FakePolicyAssignmentResource", "ArmResourceExtensions")]
        [TestCase("DeploymentExtendedResource", "SubscriptionResourceExtensions")]
        [TestCase("DeploymentExtendedResource", "ResourceGroupResourceExtensions")]
        [TestCase("DeploymentExtendedResource", "ManagementGroupResourceExtensions")]
        [TestCase("DeploymentExtendedResource", "TenantResourceExtensions")]
        [TestCase("ResourceLinkResource", "TenantResourceExtensions")]
        public void TestScopeResource(string resourceName, string parentName)
        {
            var resource = _library.ArmResources.FirstOrDefault(r => r.Type.Name == resourceName);
            Assert.NotNull(resource);
            var parents = resource.GetParents(_library);
            Assert.IsTrue(parents.Any(p => p.Type.Name == parentName));
        }
    }
}

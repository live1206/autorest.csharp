// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample.Tests.Mock
{
    /// <summary> Test for RoleAssignmentCollection. </summary>
    public partial class RoleAssignmentCollectionMockTests : MockTestBase
    {
        public RoleAssignmentCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create role assignment

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/{0}", "scope"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "roleAssignmentName", new RoleAssignmentCreateOrUpdateContent()
            {
                RoleDefinitionId = "/subscriptions/4004a9fd-d58e-48dc-aeb2-4a4aec58606f/providers/Microsoft.Authorization/roleDefinitions/de139f84-1756-47ae-9be6-808fbbe84772",
                PrincipalId = "d93a38bc-d029-4160-bfb0-fbda779ac214",
                CanDelegate = false,
            });
        }

        [RecordedTest]
        public async Task Exists()
        {
            // Example: Get role assignment by name

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/{0}", "scope"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await collection.ExistsAsync("roleAssignmentName");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get role assignment by name

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/{0}", "scope"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await collection.GetAsync("roleAssignmentName");
        }

        [RecordedTest]
        public async Task GetAll_ListRoleAssignmentsForResource()
        {
            // Example: List role assignments for resource

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourcegroups/{1}/providers/{2}/{3}/{4}/{5}", "00000000-0000-0000-0000-000000000000", "rgname", "resourceProviderNamespace", "parentResourcePath", new ResourceType("resourceType"), "resourceName"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetAll_ListRoleAssignmentsForResourceGroup()
        {
            // Example: List role assignments for resource group

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}", "00000000-0000-0000-0000-000000000000", "rgname"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetAll_ListRoleAssignmentsForSubscription()
        {
            // Example: List role assignments for subscription

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/subscriptions/{0}", "00000000-0000-0000-0000-000000000000"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetAll_ListRoleAssignmentsForScope()
        {
            // Example: List role assignments for scope

            ResourceIdentifier resourceId = new ResourceIdentifier(string.Format("/{0}", "scope"));
            GenericResource resource = GetArmClient().GetGenericResource(resourceId);
            var collection = resource.GetRoleAssignments();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
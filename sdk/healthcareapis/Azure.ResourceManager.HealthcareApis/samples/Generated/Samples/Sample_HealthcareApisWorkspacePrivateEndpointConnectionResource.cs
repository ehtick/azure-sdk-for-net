// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthcareApis.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisWorkspacePrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkspacePrivateEndpointConnectionGetConnection()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/privatelink/WorkspaceGetPrivateEndpointConnection.json
            // this example is just showing the usage of "WorkspacePrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating HealthcareApisWorkspacePrivateEndpointConnectionResource, please refer to the document of HealthcareApisWorkspacePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier healthcareApisWorkspacePrivateEndpointConnectionResourceId = HealthcareApisWorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            HealthcareApisWorkspacePrivateEndpointConnectionResource healthcareApisWorkspacePrivateEndpointConnection = client.GetHealthcareApisWorkspacePrivateEndpointConnectionResource(healthcareApisWorkspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            HealthcareApisWorkspacePrivateEndpointConnectionResource result = await healthcareApisWorkspacePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_WorkspacePrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/privatelink/WorkspaceDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "WorkspacePrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating HealthcareApisWorkspacePrivateEndpointConnectionResource, please refer to the document of HealthcareApisWorkspacePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier healthcareApisWorkspacePrivateEndpointConnectionResourceId = HealthcareApisWorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            HealthcareApisWorkspacePrivateEndpointConnectionResource healthcareApisWorkspacePrivateEndpointConnection = client.GetHealthcareApisWorkspacePrivateEndpointConnectionResource(healthcareApisWorkspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            await healthcareApisWorkspacePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_WorkspacePrivateEndpointConnectionCreateOrUpdate()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/privatelink/WorkspaceCreatePrivateEndpointConnection.json
            // this example is just showing the usage of "WorkspacePrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating HealthcareApisWorkspacePrivateEndpointConnectionResource, please refer to the document of HealthcareApisWorkspacePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier healthcareApisWorkspacePrivateEndpointConnectionResourceId = HealthcareApisWorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            HealthcareApisWorkspacePrivateEndpointConnectionResource healthcareApisWorkspacePrivateEndpointConnection = client.GetHealthcareApisWorkspacePrivateEndpointConnectionResource(healthcareApisWorkspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            HealthcareApisPrivateEndpointConnectionData data = new HealthcareApisPrivateEndpointConnectionData
            {
                ConnectionState = new HealthcareApisPrivateLinkServiceConnectionState
                {
                    Status = HealthcareApisPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource> lro = await healthcareApisWorkspacePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            HealthcareApisWorkspacePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

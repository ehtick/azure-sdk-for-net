// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NewRelicObservability.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NewRelicObservability.Samples
{
    public partial class Sample_NewRelicObservabilityTagRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TagRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            NewRelicObservabilityTagRuleResource result = await newRelicObservabilityTagRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TagRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            NewRelicObservabilityTagRuleResource result = await newRelicObservabilityTagRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TagRulesDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            await newRelicObservabilityTagRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TagRulesDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            await newRelicObservabilityTagRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TagRulesUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            NewRelicObservabilityTagRulePatch patch = new NewRelicObservabilityTagRulePatch
            {
                LogRules = new NewRelicObservabilityLogRules
                {
                    SendAadLogs = NewRelicObservabilitySendAadLogsStatus.IsEnabled,
                    SendSubscriptionLogs = NewRelicObservabilitySendSubscriptionLogsStatus.IsEnabled,
                    SendActivityLogs = NewRelicObservabilitySendActivityLogsStatus.IsEnabled,
                    FilteringTags = {new NewRelicObservabilityFilteringTag
{
Name = "saokgpjvdlorciqbjmjxazpee",
Value = "sarxrqsxouhdjwsrqqicbeirdb",
Action = NewRelicObservabilityTagAction.Include,
}},
                },
                MetricRules = new NewRelicObservabilityMetricRules
                {
                    FilteringTags = {new NewRelicObservabilityFilteringTag
{
Name = "saokgpjvdlorciqbjmjxazpee",
Value = "sarxrqsxouhdjwsrqqicbeirdb",
Action = NewRelicObservabilityTagAction.Include,
}},
                    UserEmail = "test@testing.com",
                },
            };
            NewRelicObservabilityTagRuleResource result = await newRelicObservabilityTagRule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TagRulesUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2024-03-01/examples/TagRules_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicObservabilityTagRuleResource created on azure
            // for more information of creating NewRelicObservabilityTagRuleResource, please refer to the document of NewRelicObservabilityTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            ResourceIdentifier newRelicObservabilityTagRuleResourceId = NewRelicObservabilityTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            NewRelicObservabilityTagRuleResource newRelicObservabilityTagRule = client.GetNewRelicObservabilityTagRuleResource(newRelicObservabilityTagRuleResourceId);

            // invoke the operation
            NewRelicObservabilityTagRulePatch patch = new NewRelicObservabilityTagRulePatch();
            NewRelicObservabilityTagRuleResource result = await newRelicObservabilityTagRule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

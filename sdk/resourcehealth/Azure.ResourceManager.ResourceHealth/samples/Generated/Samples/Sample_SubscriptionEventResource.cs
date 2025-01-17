// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_SubscriptionEventResource
    {
        // ListSecurityAdvisoryImpactedResourcesBySubscriptionId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventId_ListSecurityAdvisoryImpactedResourcesBySubscriptionId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2022-10-01-preview/examples/SecurityAdvisoryImpactedResources_ListBySubscriptionId_ListByEventId.json
            // this example is just showing the usage of "SecurityAdvisoryImpactedResources_ListBySubscriptionIdAndEventId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionEventResource created on azure
            // for more information of creating SubscriptionEventResource, please refer to the document of SubscriptionEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "BC_1-FXZ";
            ResourceIdentifier subscriptionEventResourceId = SubscriptionEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            SubscriptionEventResource subscriptionEvent = client.GetSubscriptionEventResource(subscriptionEventResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventImpactedResourceData item in subscriptionEvent.GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventIdAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SecurityAdvisoriesEventBySubscriptionIdAndTrackingId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SecurityAdvisoriesEventBySubscriptionIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2022-10-01-preview/examples/Event_GetBySubscriptionIdAndTrackingId.json
            // this example is just showing the usage of "Event_GetBySubscriptionIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionEventResource created on azure
            // for more information of creating SubscriptionEventResource, please refer to the document of SubscriptionEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier subscriptionEventResourceId = SubscriptionEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            SubscriptionEventResource subscriptionEvent = client.GetSubscriptionEventResource(subscriptionEventResourceId);

            // invoke the operation
            string filter = "properties/status eq 'Active'";
            string queryStartTime = "7/10/2022";
            SubscriptionEventResource result = await subscriptionEvent.GetAsync(filter: filter, queryStartTime: queryStartTime);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // EventDetailsBySubscriptionIdAndTrackingId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task FetchDetailsBySubscriptionIdAndTrackingId_EventDetailsBySubscriptionIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2022-10-01-preview/examples/Event_fetchDetailsBySubscriptionIdAndTrackingId.json
            // this example is just showing the usage of "Event_fetchDetailsBySubscriptionIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionEventResource created on azure
            // for more information of creating SubscriptionEventResource, please refer to the document of SubscriptionEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier subscriptionEventResourceId = SubscriptionEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            SubscriptionEventResource subscriptionEvent = client.GetSubscriptionEventResource(subscriptionEventResourceId);

            // invoke the operation
            SubscriptionEventResource result = await subscriptionEvent.FetchDetailsBySubscriptionIdAndTrackingIdAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

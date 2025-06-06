// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SiteManager
{
    /// <summary>
    /// A class representing a collection of <see cref="EdgeSiteResource"/> and their operations.
    /// Each <see cref="EdgeSiteResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="EdgeSiteCollection"/> instance call the GetEdgeSites method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class EdgeSiteCollection : ArmCollection, IEnumerable<EdgeSiteResource>, IAsyncEnumerable<EdgeSiteResource>
    {
        private readonly ClientDiagnostics _edgeSiteSitesClientDiagnostics;
        private readonly SitesRestOperations _edgeSiteSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EdgeSiteCollection"/> class for mocking. </summary>
        protected EdgeSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EdgeSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EdgeSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _edgeSiteSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SiteManager", EdgeSiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EdgeSiteResource.ResourceType, out string edgeSiteSitesApiVersion);
            _edgeSiteSitesRestClient = new SitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, edgeSiteSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EdgeSiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string siteName, EdgeSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _edgeSiteSitesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, siteName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SiteManagerArmOperation<EdgeSiteResource>(new EdgeSiteOperationSource(Client), _edgeSiteSitesClientDiagnostics, Pipeline, _edgeSiteSitesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, siteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EdgeSiteResource> CreateOrUpdate(WaitUntil waitUntil, string siteName, EdgeSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _edgeSiteSitesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, siteName, data, cancellationToken);
                var operation = new SiteManagerArmOperation<EdgeSiteResource>(new EdgeSiteOperationSource(Client), _edgeSiteSitesClientDiagnostics, Pipeline, _edgeSiteSitesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, siteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<EdgeSiteResource>> GetAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _edgeSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<EdgeSiteResource> Get(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _edgeSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Site resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeSiteResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeSiteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _edgeSiteSitesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _edgeSiteSitesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EdgeSiteResource(Client, EdgeSiteData.DeserializeEdgeSiteData(e)), _edgeSiteSitesClientDiagnostics, Pipeline, "EdgeSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Site resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeSiteResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeSiteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _edgeSiteSitesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _edgeSiteSitesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EdgeSiteResource(Client, EdgeSiteData.DeserializeEdgeSiteData(e)), _edgeSiteSitesClientDiagnostics, Pipeline, "EdgeSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _edgeSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<bool> Exists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = _edgeSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<NullableResponse<EdgeSiteResource>> GetIfExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _edgeSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EdgeSiteResource>(response.GetRawResponse());
                return Response.FromValue(new EdgeSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Edge/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Site_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EdgeSiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> Name of Site resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual NullableResponse<EdgeSiteResource> GetIfExists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _edgeSiteSitesClientDiagnostics.CreateScope("EdgeSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _edgeSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, siteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EdgeSiteResource>(response.GetRawResponse());
                return Response.FromValue(new EdgeSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EdgeSiteResource> IEnumerable<EdgeSiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EdgeSiteResource> IAsyncEnumerable<EdgeSiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

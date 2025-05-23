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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementOpenIdConnectProviderResource"/> and their operations.
    /// Each <see cref="ApiManagementOpenIdConnectProviderResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementOpenIdConnectProviderCollection"/> instance call the GetApiManagementOpenIdConnectProviders method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementOpenIdConnectProviderCollection : ArmCollection, IEnumerable<ApiManagementOpenIdConnectProviderResource>, IAsyncEnumerable<ApiManagementOpenIdConnectProviderResource>
    {
        private readonly ClientDiagnostics _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics;
        private readonly OpenIdConnectProviderRestOperations _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementOpenIdConnectProviderCollection"/> class for mocking. </summary>
        protected ApiManagementOpenIdConnectProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementOpenIdConnectProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementOpenIdConnectProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementOpenIdConnectProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementOpenIdConnectProviderResource.ResourceType, out string apiManagementOpenIdConnectProviderOpenIdConnectProviderApiVersion);
            _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient = new OpenIdConnectProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementOpenIdConnectProviderOpenIdConnectProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the OpenID Connect Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementOpenIdConnectProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string openId, ApiManagementOpenIdConnectProviderData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementOpenIdConnectProviderResource>(Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates the OpenID Connect Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementOpenIdConnectProviderResource> CreateOrUpdate(WaitUntil waitUntil, string openId, ApiManagementOpenIdConnectProviderData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch, cancellationToken);
                var uri = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementOpenIdConnectProviderResource>(Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets specific OpenID Connect Provider without secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementOpenIdConnectProviderResource>> GetAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets specific OpenID Connect Provider without secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual Response<ApiManagementOpenIdConnectProviderResource> Get(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists of all the OpenId Connect Providers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementOpenIdConnectProviderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementOpenIdConnectProviderResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementOpenIdConnectProviderResource(Client, ApiManagementOpenIdConnectProviderData.DeserializeApiManagementOpenIdConnectProviderData(e)), _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics, Pipeline, "ApiManagementOpenIdConnectProviderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists of all the OpenId Connect Providers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementOpenIdConnectProviderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementOpenIdConnectProviderResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementOpenIdConnectProviderResource(Client, ApiManagementOpenIdConnectProviderData.DeserializeApiManagementOpenIdConnectProviderData(e)), _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics, Pipeline, "ApiManagementOpenIdConnectProviderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual Response<bool> Exists(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementOpenIdConnectProviderResource>> GetIfExistsAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementOpenIdConnectProviderResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OpenIdConnectProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementOpenIdConnectProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementOpenIdConnectProviderResource> GetIfExists(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementOpenIdConnectProviderResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementOpenIdConnectProviderResource> IEnumerable<ApiManagementOpenIdConnectProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementOpenIdConnectProviderResource> IAsyncEnumerable<ApiManagementOpenIdConnectProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

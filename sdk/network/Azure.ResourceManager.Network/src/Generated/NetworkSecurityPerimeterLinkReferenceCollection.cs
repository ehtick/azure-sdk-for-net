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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkSecurityPerimeterLinkReferenceResource"/> and their operations.
    /// Each <see cref="NetworkSecurityPerimeterLinkReferenceResource"/> in the collection will belong to the same instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// To get a <see cref="NetworkSecurityPerimeterLinkReferenceCollection"/> instance call the GetNetworkSecurityPerimeterLinkReferences method from an instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// </summary>
    public partial class NetworkSecurityPerimeterLinkReferenceCollection : ArmCollection, IEnumerable<NetworkSecurityPerimeterLinkReferenceResource>, IAsyncEnumerable<NetworkSecurityPerimeterLinkReferenceResource>
    {
        private readonly ClientDiagnostics _networkSecurityPerimeterLinkReferenceClientDiagnostics;
        private readonly NetworkSecurityPerimeterLinkReferencesRestOperations _networkSecurityPerimeterLinkReferenceRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterLinkReferenceCollection"/> class for mocking. </summary>
        protected NetworkSecurityPerimeterLinkReferenceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterLinkReferenceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityPerimeterLinkReferenceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityPerimeterLinkReferenceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkSecurityPerimeterLinkReferenceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkSecurityPerimeterLinkReferenceResource.ResourceType, out string networkSecurityPerimeterLinkReferenceApiVersion);
            _networkSecurityPerimeterLinkReferenceRestClient = new NetworkSecurityPerimeterLinkReferencesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityPerimeterLinkReferenceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityPerimeterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityPerimeterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified NSP linkReference resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityPerimeterLinkReferenceResource>> GetAsync(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkReferenceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkReferenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified NSP linkReference resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual Response<NetworkSecurityPerimeterLinkReferenceResource> Get(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkReferenceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkReferenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the NSP LinkReference resources in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityPerimeterLinkReferenceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityPerimeterLinkReferenceResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterLinkReferenceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterLinkReferenceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterLinkReferenceResource(Client, NetworkSecurityPerimeterLinkReferenceData.DeserializeNetworkSecurityPerimeterLinkReferenceData(e)), _networkSecurityPerimeterLinkReferenceClientDiagnostics, Pipeline, "NetworkSecurityPerimeterLinkReferenceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the NSP LinkReference resources in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityPerimeterLinkReferenceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityPerimeterLinkReferenceResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterLinkReferenceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterLinkReferenceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterLinkReferenceResource(Client, NetworkSecurityPerimeterLinkReferenceData.DeserializeNetworkSecurityPerimeterLinkReferenceData(e)), _networkSecurityPerimeterLinkReferenceClientDiagnostics, Pipeline, "NetworkSecurityPerimeterLinkReferenceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkReferenceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkReferenceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkSecurityPerimeterLinkReferenceResource>> GetIfExistsAsync(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterLinkReferenceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterLinkReferenceResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkReferenceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/linkReferences/{linkReferenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterLinkReferences_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterLinkReferenceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkReferenceName"> The name of the NSP linkReference. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkReferenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkReferenceName"/> is null. </exception>
        public virtual NullableResponse<NetworkSecurityPerimeterLinkReferenceResource> GetIfExists(string linkReferenceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkReferenceName, nameof(linkReferenceName));

            using var scope = _networkSecurityPerimeterLinkReferenceClientDiagnostics.CreateScope("NetworkSecurityPerimeterLinkReferenceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterLinkReferenceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkReferenceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterLinkReferenceResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterLinkReferenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityPerimeterLinkReferenceResource> IEnumerable<NetworkSecurityPerimeterLinkReferenceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityPerimeterLinkReferenceResource> IAsyncEnumerable<NetworkSecurityPerimeterLinkReferenceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

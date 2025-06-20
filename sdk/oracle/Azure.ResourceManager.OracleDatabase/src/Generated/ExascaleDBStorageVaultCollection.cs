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

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="ExascaleDBStorageVaultResource"/> and their operations.
    /// Each <see cref="ExascaleDBStorageVaultResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ExascaleDBStorageVaultCollection"/> instance call the GetExascaleDBStorageVaults method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ExascaleDBStorageVaultCollection : ArmCollection, IEnumerable<ExascaleDBStorageVaultResource>, IAsyncEnumerable<ExascaleDBStorageVaultResource>
    {
        private readonly ClientDiagnostics _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics;
        private readonly ExascaleDbStorageVaultsRestOperations _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExascaleDBStorageVaultCollection"/> class for mocking. </summary>
        protected ExascaleDBStorageVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExascaleDBStorageVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExascaleDBStorageVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ExascaleDBStorageVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExascaleDBStorageVaultResource.ResourceType, out string exascaleDBStorageVaultExascaleDbStorageVaultsApiVersion);
            _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient = new ExascaleDbStorageVaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, exascaleDBStorageVaultExascaleDbStorageVaultsApiVersion);
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
        /// Create a ExascaleDbStorageVault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExascaleDBStorageVaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string exascaleDbStorageVaultName, ExascaleDBStorageVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OracleDatabaseArmOperation<ExascaleDBStorageVaultResource>(new ExascaleDBStorageVaultOperationSource(Client), _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics, Pipeline, _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a ExascaleDbStorageVault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExascaleDBStorageVaultResource> CreateOrUpdate(WaitUntil waitUntil, string exascaleDbStorageVaultName, ExascaleDBStorageVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, data, cancellationToken);
                var operation = new OracleDatabaseArmOperation<ExascaleDBStorageVaultResource>(new ExascaleDBStorageVaultOperationSource(Client), _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics, Pipeline, _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a ExascaleDbStorageVault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual async Task<Response<ExascaleDBStorageVaultResource>> GetAsync(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBStorageVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ExascaleDbStorageVault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual Response<ExascaleDBStorageVaultResource> Get(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBStorageVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ExascaleDbStorageVault resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExascaleDBStorageVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExascaleDBStorageVaultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExascaleDBStorageVaultResource(Client, ExascaleDBStorageVaultData.DeserializeExascaleDBStorageVaultData(e)), _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics, Pipeline, "ExascaleDBStorageVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ExascaleDbStorageVault resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExascaleDBStorageVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExascaleDBStorageVaultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExascaleDBStorageVaultResource(Client, ExascaleDBStorageVaultData.DeserializeExascaleDBStorageVaultData(e)), _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics, Pipeline, "ExascaleDBStorageVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExascaleDBStorageVaultResource>> GetIfExistsAsync(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExascaleDBStorageVaultResource>(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBStorageVaultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exascaleDbStorageVaults/{exascaleDbStorageVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbStorageVault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBStorageVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbStorageVaultName"> The name of the ExascaleDbStorageVault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbStorageVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbStorageVaultName"/> is null. </exception>
        public virtual NullableResponse<ExascaleDBStorageVaultResource> GetIfExists(string exascaleDbStorageVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));

            using var scope = _exascaleDBStorageVaultExascaleDbStorageVaultsClientDiagnostics.CreateScope("ExascaleDBStorageVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _exascaleDBStorageVaultExascaleDbStorageVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exascaleDbStorageVaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExascaleDBStorageVaultResource>(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBStorageVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExascaleDBStorageVaultResource> IEnumerable<ExascaleDBStorageVaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExascaleDBStorageVaultResource> IAsyncEnumerable<ExascaleDBStorageVaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

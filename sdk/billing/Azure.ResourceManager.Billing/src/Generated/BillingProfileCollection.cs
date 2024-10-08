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
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingProfileResource"/> and their operations.
    /// Each <see cref="BillingProfileResource"/> in the collection will belong to the same instance of <see cref="BillingAccountResource"/>.
    /// To get a <see cref="BillingProfileCollection"/> instance call the GetBillingProfiles method from an instance of <see cref="BillingAccountResource"/>.
    /// </summary>
    public partial class BillingProfileCollection : ArmCollection, IEnumerable<BillingProfileResource>, IAsyncEnumerable<BillingProfileResource>
    {
        private readonly ClientDiagnostics _billingProfileClientDiagnostics;
        private readonly BillingProfilesRestOperations _billingProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingProfileCollection"/> class for mocking. </summary>
        protected BillingProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingProfileResource.ResourceType, out string billingProfileApiVersion);
            _billingProfileRestClient = new BillingProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a billing profile. The operation is supported for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement. If you are a MCA Individual (Pay-as-you-go) customer, then please use the Azure portal experience to create the billing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="data"> A billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string billingProfileName, BillingProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _billingProfileRestClient.CreateOrUpdateAsync(Id.Name, billingProfileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingProfileResource>(new BillingProfileOperationSource(Client), _billingProfileClientDiagnostics, Pipeline, _billingProfileRestClient.CreateCreateOrUpdateRequest(Id.Name, billingProfileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a billing profile. The operation is supported for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement. If you are a MCA Individual (Pay-as-you-go) customer, then please use the Azure portal experience to create the billing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="data"> A billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BillingProfileResource> CreateOrUpdate(WaitUntil waitUntil, string billingProfileName, BillingProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _billingProfileRestClient.CreateOrUpdate(Id.Name, billingProfileName, data, cancellationToken);
                var operation = new BillingArmOperation<BillingProfileResource>(new BillingProfileOperationSource(Client), _billingProfileClientDiagnostics, Pipeline, _billingProfileRestClient.CreateCreateOrUpdateRequest(Id.Name, billingProfileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a billing profile by its ID. The operation is supported for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual async Task<Response<BillingProfileResource>> GetAsync(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingProfileRestClient.GetAsync(Id.Name, billingProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a billing profile by its ID. The operation is supported for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual Response<BillingProfileResource> Get(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _billingProfileRestClient.Get(Id.Name, billingProfileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the billing profiles that a user has access to. The operation is supported for billing accounts with agreement of type Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingProfileResource> GetAllAsync(BillingProfileCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingProfileCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingProfileRestClient.CreateListByBillingAccountRequest(Id.Name, options.IncludeDeleted, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingProfileRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.IncludeDeleted, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingProfileResource(Client, BillingProfileData.DeserializeBillingProfileData(e)), _billingProfileClientDiagnostics, Pipeline, "BillingProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the billing profiles that a user has access to. The operation is supported for billing accounts with agreement of type Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingProfileResource> GetAll(BillingProfileCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingProfileCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingProfileRestClient.CreateListByBillingAccountRequest(Id.Name, options.IncludeDeleted, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingProfileRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.IncludeDeleted, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingProfileResource(Client, BillingProfileData.DeserializeBillingProfileData(e)), _billingProfileClientDiagnostics, Pipeline, "BillingProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingProfileRestClient.GetAsync(Id.Name, billingProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingProfileRestClient.Get(Id.Name, billingProfileName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingProfileResource>> GetIfExistsAsync(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingProfileRestClient.GetAsync(Id.Name, billingProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingProfileResource>(response.GetRawResponse());
                return Response.FromValue(new BillingProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingProfileName"/> is null. </exception>
        public virtual NullableResponse<BillingProfileResource> GetIfExists(string billingProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingProfileName, nameof(billingProfileName));

            using var scope = _billingProfileClientDiagnostics.CreateScope("BillingProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingProfileRestClient.Get(Id.Name, billingProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingProfileResource>(response.GetRawResponse());
                return Response.FromValue(new BillingProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingProfileResource> IEnumerable<BillingProfileResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<BillingProfileResource> IAsyncEnumerable<BillingProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

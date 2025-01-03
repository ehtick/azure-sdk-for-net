// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class Foos
    {
        private readonly Uri _endpoint;
        /// <summary> A credential used to authenticate to the service. </summary>
        private readonly TokenCredential _tokenCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "user_impersonation" };
        private readonly string _apiVersion;
        private readonly Guid _subscriptionId;

        /// <summary> Initializes a new instance of Foos for mocking. </summary>
        protected Foos()
        {
        }

        internal Foos(HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion, Guid subscriptionId)
        {
            _endpoint = endpoint;
            Pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _apiVersion = apiVersion;
            _subscriptionId = subscriptionId;
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public HttpPipeline Pipeline { get; }

        /// <summary>
        /// [Protocol Method] Create a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fooName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response CreateOrUpdate(string resourceGroupName, string fooName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));
            Argument.AssertNotNull(content, nameof(content));

            using HttpMessage message = CreateCreateOrUpdateRequest(resourceGroupName, fooName, content, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] Create a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fooName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string fooName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));
            Argument.AssertNotNull(content, nameof(content));

            using HttpMessage message = CreateCreateOrUpdateRequest(resourceGroupName, fooName, content, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Create a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="resource"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fooName"/> or <paramref name="resource"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<Foo> CreateOrUpdate(string resourceGroupName, string fooName, Foo resource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));
            Argument.AssertNotNull(resource, nameof(resource));

            Response result = CreateOrUpdate(resourceGroupName, fooName, resource, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue((Foo)result, result);
        }

        /// <summary> Create a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="resource"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="fooName"/> or <paramref name="resource"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<Foo>> CreateOrUpdateAsync(string resourceGroupName, string fooName, Foo resource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));
            Argument.AssertNotNull(resource, nameof(resource));

            Response result = await CreateOrUpdateAsync(resourceGroupName, fooName, resource, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue((Foo)result, result);
        }

        /// <summary>
        /// [Protocol Method] Get a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response Get(string resourceGroupName, string fooName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            using HttpMessage message = CreateGetRequest(resourceGroupName, fooName, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] Get a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> GetAsync(string resourceGroupName, string fooName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            using HttpMessage message = CreateGetRequest(resourceGroupName, fooName, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<Foo> Get(string resourceGroupName, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            Response result = Get(resourceGroupName, fooName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue((Foo)result, result);
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<Foo>> GetAsync(string resourceGroupName, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            Response result = await GetAsync(resourceGroupName, fooName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue((Foo)result, result);
        }

        /// <summary>
        /// [Protocol Method] Delete a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response Delete(string resourceGroupName, string fooName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            using HttpMessage message = CreateDeleteRequest(resourceGroupName, fooName, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] Delete a Foo
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string fooName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            using HttpMessage message = CreateDeleteRequest(resourceGroupName, fooName, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Delete a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response Delete(string resourceGroupName, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            return Delete(resourceGroupName, fooName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Delete a Foo. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(fooName, nameof(fooName));

            return await DeleteAsync(resourceGroupName, fooName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
        }

        /// <summary>
        /// [Protocol Method] List Foo resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response List(string resourceGroupName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            using HttpMessage message = CreateListRequest(resourceGroupName, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] List Foo resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> ListAsync(string resourceGroupName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            using HttpMessage message = CreateListRequest(resourceGroupName, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> List Foo resources by resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<FooListResult> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            Response result = List(resourceGroupName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue((FooListResult)result, result);
        }

        /// <summary> List Foo resources by resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<FooListResult>> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            Response result = await ListAsync(resourceGroupName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue((FooListResult)result, result);
        }
    }
}

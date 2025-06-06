// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    internal partial class ServiceConfigurationResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ServiceConfigurationResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ServiceConfigurationResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceUri, string endpointName, string serviceConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceUri, string endpointName, string serviceConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the details about the service to the resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/> or <paramref name="serviceConfigurationName"/> is null. </exception>
        public async Task<Response<HybridConnectivityServiceConfigurationData>> GetAsync(string resourceUri, string endpointName, string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));

            using var message = CreateGetRequest(resourceUri, endpointName, serviceConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridConnectivityServiceConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the details about the service to the resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/> or <paramref name="serviceConfigurationName"/> is null. </exception>
        public Response<HybridConnectivityServiceConfigurationData> Get(string resourceUri, string endpointName, string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));

            using var message = CreateGetRequest(resourceUri, endpointName, serviceConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridConnectivityServiceConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrupdateRequestUri(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrupdateRequest(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a service in serviceConfiguration for the endpoint resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="data"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/>, <paramref name="serviceConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response<HybridConnectivityServiceConfigurationData>> CreateOrupdateAsync(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrupdateRequest(resourceUri, endpointName, serviceConfigurationName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a service in serviceConfiguration for the endpoint resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="data"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/>, <paramref name="serviceConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public Response<HybridConnectivityServiceConfigurationData> CreateOrupdate(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrupdateRequest(resourceUri, endpointName, serviceConfigurationName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationPatch patch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update the service details in the service configurations of the target resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="patch"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/>, <paramref name="serviceConfigurationName"/> or <paramref name="patch"/> is null. </exception>
        public async Task<Response<HybridConnectivityServiceConfigurationData>> UpdateAsync(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(resourceUri, endpointName, serviceConfigurationName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update the service details in the service configurations of the target resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="patch"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/>, <paramref name="serviceConfigurationName"/> or <paramref name="patch"/> is null. </exception>
        public Response<HybridConnectivityServiceConfigurationData> Update(string resourceUri, string endpointName, string serviceConfigurationName, HybridConnectivityServiceConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(resourceUri, endpointName, serviceConfigurationName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridConnectivityServiceConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = HybridConnectivityServiceConfigurationData.DeserializeHybridConnectivityServiceConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceUri, string endpointName, string serviceConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceUri, string endpointName, string serviceConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations/", false);
            uri.AppendPath(serviceConfigurationName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the service details to the target resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/> or <paramref name="serviceConfigurationName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceUri, string endpointName, string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));

            using var message = CreateDeleteRequest(resourceUri, endpointName, serviceConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the service details to the target resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="endpointName"/> or <paramref name="serviceConfigurationName"/> is null. </exception>
        public Response Delete(string resourceUri, string endpointName, string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(serviceConfigurationName, nameof(serviceConfigurationName));

            using var message = CreateDeleteRequest(resourceUri, endpointName, serviceConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByEndpointResourceRequestUri(string resourceUri, string endpointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByEndpointResourceRequest(string resourceUri, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/serviceConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> API to enumerate registered services in service configurations under a Endpoint Resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<ServiceConfigurationList>> ListByEndpointResourceAsync(string resourceUri, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointResourceRequest(resourceUri, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceConfigurationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ServiceConfigurationList.DeserializeServiceConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> API to enumerate registered services in service configurations under a Endpoint Resource. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="endpointName"/> is null. </exception>
        public Response<ServiceConfigurationList> ListByEndpointResource(string resourceUri, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointResourceRequest(resourceUri, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceConfigurationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ServiceConfigurationList.DeserializeServiceConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByEndpointResourceNextPageRequestUri(string nextLink, string resourceUri, string endpointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByEndpointResourceNextPageRequest(string nextLink, string resourceUri, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> API to enumerate registered services in service configurations under a Endpoint Resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceUri"/> or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<ServiceConfigurationList>> ListByEndpointResourceNextPageAsync(string nextLink, string resourceUri, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointResourceNextPageRequest(nextLink, resourceUri, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceConfigurationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ServiceConfigurationList.DeserializeServiceConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> API to enumerate registered services in service configurations under a Endpoint Resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceUri"/> or <paramref name="endpointName"/> is null. </exception>
        public Response<ServiceConfigurationList> ListByEndpointResourceNextPage(string nextLink, string resourceUri, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointResourceNextPageRequest(nextLink, resourceUri, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceConfigurationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ServiceConfigurationList.DeserializeServiceConfigurationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

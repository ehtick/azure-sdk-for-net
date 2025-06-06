// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Diagnostics.CodeAnalysis;
using Azure.Core.Extensions;
using Azure.Developer.LoadTesting;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="LoadTestAdministrationClient"/>, <see cref="LoadTestRunClient"/> to client builder. </summary>
    public static partial class AzureLoadTestingClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="LoadTestAdministrationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<LoadTestAdministrationClient, LoadTestingClientOptions> AddLoadTestAdministrationClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<LoadTestAdministrationClient, LoadTestingClientOptions>((options, cred) => new LoadTestAdministrationClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="LoadTestRunClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<LoadTestRunClient, LoadTestingClientOptions> AddLoadTestRunClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<LoadTestRunClient, LoadTestingClientOptions>((options, cred) => new LoadTestRunClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="LoadTestAdministrationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        [RequiresUnreferencedCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        [RequiresDynamicCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static IAzureClientBuilder<LoadTestAdministrationClient, LoadTestingClientOptions> AddLoadTestAdministrationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<LoadTestAdministrationClient, LoadTestingClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="LoadTestRunClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        [RequiresUnreferencedCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        [RequiresDynamicCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static IAzureClientBuilder<LoadTestRunClient, LoadTestingClientOptions> AddLoadTestRunClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<LoadTestRunClient, LoadTestingClientOptions>(configuration);
        }
    }
}

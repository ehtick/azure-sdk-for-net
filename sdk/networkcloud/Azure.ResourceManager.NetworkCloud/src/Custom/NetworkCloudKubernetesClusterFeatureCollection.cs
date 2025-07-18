// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudKubernetesClusterFeatureResource"/> and their operations.
    /// Each <see cref="NetworkCloudKubernetesClusterFeatureResource"/> in the collection will belong to the same instance of <see cref="NetworkCloudKubernetesClusterResource"/>.
    /// To get a <see cref="NetworkCloudKubernetesClusterFeatureCollection"/> instance call the GetNetworkCloudKubernetesClusterFeatures method from an instance of <see cref="NetworkCloudKubernetesClusterResource"/>.
    /// </summary>
    public partial class NetworkCloudKubernetesClusterFeatureCollection : ArmCollection, IEnumerable<NetworkCloudKubernetesClusterFeatureResource>, IAsyncEnumerable<NetworkCloudKubernetesClusterFeatureResource>
    {
        /// <summary>
        /// Create a new Kubernetes cluster feature or update properties of the Kubernetes cluster feature if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusterFeatures_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="featureName"> The name of the feature. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudKubernetesClusterFeatureResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string featureName, NetworkCloudKubernetesClusterFeatureData data, CancellationToken cancellationToken)
            => await CreateOrUpdateAsync(waitUntil, featureName, data, null, null, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new Kubernetes cluster feature or update properties of the Kubernetes cluster feature if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusterFeatures_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="featureName"> The name of the feature. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudKubernetesClusterFeatureResource> CreateOrUpdate(WaitUntil waitUntil, string featureName, NetworkCloudKubernetesClusterFeatureData data, CancellationToken cancellationToken)
            => CreateOrUpdate(waitUntil, featureName, data, null, null, cancellationToken);
    }
}

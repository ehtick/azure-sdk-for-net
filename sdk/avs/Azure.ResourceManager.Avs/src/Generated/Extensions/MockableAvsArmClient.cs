// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Avs.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAvsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAvsArmClient"/> class for mocking. </summary>
        protected MockableAvsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAvsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAvsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAvsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkResource.CreateResourceIdentifier(string,string,string)" /> to create a <see cref="WorkloadNetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkResource"/> object. </returns>
        public virtual WorkloadNetworkResource GetWorkloadNetworkResource(ResourceIdentifier id)
        {
            WorkloadNetworkResource.ValidateResourceId(id);
            return new WorkloadNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkDhcpResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkDhcpResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkDhcpResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkDhcpResource"/> object. </returns>
        public virtual WorkloadNetworkDhcpResource GetWorkloadNetworkDhcpResource(ResourceIdentifier id)
        {
            WorkloadNetworkDhcpResource.ValidateResourceId(id);
            return new WorkloadNetworkDhcpResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkDnsServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkDnsServiceResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkDnsServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkDnsServiceResource"/> object. </returns>
        public virtual WorkloadNetworkDnsServiceResource GetWorkloadNetworkDnsServiceResource(ResourceIdentifier id)
        {
            WorkloadNetworkDnsServiceResource.ValidateResourceId(id);
            return new WorkloadNetworkDnsServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkDnsZoneResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkDnsZoneResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkDnsZoneResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkDnsZoneResource"/> object. </returns>
        public virtual WorkloadNetworkDnsZoneResource GetWorkloadNetworkDnsZoneResource(ResourceIdentifier id)
        {
            WorkloadNetworkDnsZoneResource.ValidateResourceId(id);
            return new WorkloadNetworkDnsZoneResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkGatewayResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkGatewayResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkGatewayResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkGatewayResource"/> object. </returns>
        public virtual WorkloadNetworkGatewayResource GetWorkloadNetworkGatewayResource(ResourceIdentifier id)
        {
            WorkloadNetworkGatewayResource.ValidateResourceId(id);
            return new WorkloadNetworkGatewayResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkPortMirroringProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkPortMirroringProfileResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkPortMirroringProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkPortMirroringProfileResource"/> object. </returns>
        public virtual WorkloadNetworkPortMirroringProfileResource GetWorkloadNetworkPortMirroringProfileResource(ResourceIdentifier id)
        {
            WorkloadNetworkPortMirroringProfileResource.ValidateResourceId(id);
            return new WorkloadNetworkPortMirroringProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkPublicIPResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkPublicIPResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkPublicIPResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkPublicIPResource"/> object. </returns>
        public virtual WorkloadNetworkPublicIPResource GetWorkloadNetworkPublicIPResource(ResourceIdentifier id)
        {
            WorkloadNetworkPublicIPResource.ValidateResourceId(id);
            return new WorkloadNetworkPublicIPResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkSegmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkSegmentResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkSegmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkSegmentResource"/> object. </returns>
        public virtual WorkloadNetworkSegmentResource GetWorkloadNetworkSegmentResource(ResourceIdentifier id)
        {
            WorkloadNetworkSegmentResource.ValidateResourceId(id);
            return new WorkloadNetworkSegmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkVirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkVirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkVirtualMachineResource"/> object. </returns>
        public virtual WorkloadNetworkVirtualMachineResource GetWorkloadNetworkVirtualMachineResource(ResourceIdentifier id)
        {
            WorkloadNetworkVirtualMachineResource.ValidateResourceId(id);
            return new WorkloadNetworkVirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadNetworkVmGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadNetworkVmGroupResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadNetworkVmGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadNetworkVmGroupResource"/> object. </returns>
        public virtual WorkloadNetworkVmGroupResource GetWorkloadNetworkVmGroupResource(ResourceIdentifier id)
        {
            WorkloadNetworkVmGroupResource.ValidateResourceId(id);
            return new WorkloadNetworkVmGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPrivateCloudResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPrivateCloudResource.CreateResourceIdentifier" /> to create an <see cref="AvsPrivateCloudResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPrivateCloudResource"/> object. </returns>
        public virtual AvsPrivateCloudResource GetAvsPrivateCloudResource(ResourceIdentifier id)
        {
            AvsPrivateCloudResource.ValidateResourceId(id);
            return new AvsPrivateCloudResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPrivateCloudClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPrivateCloudClusterResource.CreateResourceIdentifier" /> to create an <see cref="AvsPrivateCloudClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPrivateCloudClusterResource"/> object. </returns>
        public virtual AvsPrivateCloudClusterResource GetAvsPrivateCloudClusterResource(ResourceIdentifier id)
        {
            AvsPrivateCloudClusterResource.ValidateResourceId(id);
            return new AvsPrivateCloudClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPrivateCloudDatastoreResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPrivateCloudDatastoreResource.CreateResourceIdentifier" /> to create an <see cref="AvsPrivateCloudDatastoreResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPrivateCloudDatastoreResource"/> object. </returns>
        public virtual AvsPrivateCloudDatastoreResource GetAvsPrivateCloudDatastoreResource(ResourceIdentifier id)
        {
            AvsPrivateCloudDatastoreResource.ValidateResourceId(id);
            return new AvsPrivateCloudDatastoreResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HcxEnterpriseSiteResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HcxEnterpriseSiteResource.CreateResourceIdentifier" /> to create a <see cref="HcxEnterpriseSiteResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HcxEnterpriseSiteResource"/> object. </returns>
        public virtual HcxEnterpriseSiteResource GetHcxEnterpriseSiteResource(ResourceIdentifier id)
        {
            HcxEnterpriseSiteResource.ValidateResourceId(id);
            return new HcxEnterpriseSiteResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExpressRouteAuthorizationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExpressRouteAuthorizationResource.CreateResourceIdentifier" /> to create an <see cref="ExpressRouteAuthorizationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExpressRouteAuthorizationResource"/> object. </returns>
        public virtual ExpressRouteAuthorizationResource GetExpressRouteAuthorizationResource(ResourceIdentifier id)
        {
            ExpressRouteAuthorizationResource.ValidateResourceId(id);
            return new ExpressRouteAuthorizationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GlobalReachConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GlobalReachConnectionResource.CreateResourceIdentifier" /> to create a <see cref="GlobalReachConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GlobalReachConnectionResource"/> object. </returns>
        public virtual GlobalReachConnectionResource GetGlobalReachConnectionResource(ResourceIdentifier id)
        {
            GlobalReachConnectionResource.ValidateResourceId(id);
            return new GlobalReachConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsCloudLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsCloudLinkResource.CreateResourceIdentifier" /> to create an <see cref="AvsCloudLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsCloudLinkResource"/> object. </returns>
        public virtual AvsCloudLinkResource GetAvsCloudLinkResource(ResourceIdentifier id)
        {
            AvsCloudLinkResource.ValidateResourceId(id);
            return new AvsCloudLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPrivateCloudAddonResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPrivateCloudAddonResource.CreateResourceIdentifier" /> to create an <see cref="AvsPrivateCloudAddonResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPrivateCloudAddonResource"/> object. </returns>
        public virtual AvsPrivateCloudAddonResource GetAvsPrivateCloudAddonResource(ResourceIdentifier id)
        {
            AvsPrivateCloudAddonResource.ValidateResourceId(id);
            return new AvsPrivateCloudAddonResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPrivateCloudClusterVirtualMachineResource.CreateResourceIdentifier" /> to create an <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> object. </returns>
        public virtual AvsPrivateCloudClusterVirtualMachineResource GetAvsPrivateCloudClusterVirtualMachineResource(ResourceIdentifier id)
        {
            AvsPrivateCloudClusterVirtualMachineResource.ValidateResourceId(id);
            return new AvsPrivateCloudClusterVirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlacementPolicyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlacementPolicyResource.CreateResourceIdentifier" /> to create a <see cref="PlacementPolicyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PlacementPolicyResource"/> object. </returns>
        public virtual PlacementPolicyResource GetPlacementPolicyResource(ResourceIdentifier id)
        {
            PlacementPolicyResource.ValidateResourceId(id);
            return new PlacementPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ScriptPackageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScriptPackageResource.CreateResourceIdentifier" /> to create a <see cref="ScriptPackageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScriptPackageResource"/> object. </returns>
        public virtual ScriptPackageResource GetScriptPackageResource(ResourceIdentifier id)
        {
            ScriptPackageResource.ValidateResourceId(id);
            return new ScriptPackageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ScriptCmdletResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScriptCmdletResource.CreateResourceIdentifier" /> to create a <see cref="ScriptCmdletResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScriptCmdletResource"/> object. </returns>
        public virtual ScriptCmdletResource GetScriptCmdletResource(ResourceIdentifier id)
        {
            ScriptCmdletResource.ValidateResourceId(id);
            return new ScriptCmdletResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ScriptExecutionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScriptExecutionResource.CreateResourceIdentifier" /> to create a <see cref="ScriptExecutionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScriptExecutionResource"/> object. </returns>
        public virtual ScriptExecutionResource GetScriptExecutionResource(ResourceIdentifier id)
        {
            ScriptExecutionResource.ValidateResourceId(id);
            return new ScriptExecutionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IscsiPathResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IscsiPathResource.CreateResourceIdentifier" /> to create an <see cref="IscsiPathResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IscsiPathResource"/> object. </returns>
        public virtual IscsiPathResource GetIscsiPathResource(ResourceIdentifier id)
        {
            IscsiPathResource.ValidateResourceId(id);
            return new IscsiPathResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsHostResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsHostResource.CreateResourceIdentifier" /> to create an <see cref="AvsHostResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsHostResource"/> object. </returns>
        public virtual AvsHostResource GetAvsHostResource(ResourceIdentifier id)
        {
            AvsHostResource.ValidateResourceId(id);
            return new AvsHostResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsProvisionedNetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsProvisionedNetworkResource.CreateResourceIdentifier" /> to create an <see cref="AvsProvisionedNetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsProvisionedNetworkResource"/> object. </returns>
        public virtual AvsProvisionedNetworkResource GetAvsProvisionedNetworkResource(ResourceIdentifier id)
        {
            AvsProvisionedNetworkResource.ValidateResourceId(id);
            return new AvsProvisionedNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvsPureStoragePolicyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvsPureStoragePolicyResource.CreateResourceIdentifier" /> to create an <see cref="AvsPureStoragePolicyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvsPureStoragePolicyResource"/> object. </returns>
        public virtual AvsPureStoragePolicyResource GetAvsPureStoragePolicyResource(ResourceIdentifier id)
        {
            AvsPureStoragePolicyResource.ValidateResourceId(id);
            return new AvsPureStoragePolicyResource(Client, id);
        }
    }
}

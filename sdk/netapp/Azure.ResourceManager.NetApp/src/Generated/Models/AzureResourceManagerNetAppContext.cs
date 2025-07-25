// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(AvailabilityZoneMapping))]
    [ModelReaderWriterBuildable(typeof(BackupPoliciesList))]
    [ModelReaderWriterBuildable(typeof(BackupsList))]
    [ModelReaderWriterBuildable(typeof(BackupsMigrationContent))]
    [ModelReaderWriterBuildable(typeof(BackupVaultsList))]
    [ModelReaderWriterBuildable(typeof(CapacityPoolData))]
    [ModelReaderWriterBuildable(typeof(CapacityPoolList))]
    [ModelReaderWriterBuildable(typeof(CapacityPoolPatch))]
    [ModelReaderWriterBuildable(typeof(CapacityPoolResource))]
    [ModelReaderWriterBuildable(typeof(ClusterPeerCommandResult))]
    [ModelReaderWriterBuildable(typeof(GetGroupIdListForLdapUserContent))]
    [ModelReaderWriterBuildable(typeof(GetGroupIdListForLdapUserResult))]
    [ModelReaderWriterBuildable(typeof(ListReplications))]
    [ModelReaderWriterBuildable(typeof(ManagedServiceIdentity))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountActiveDirectory))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountData))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountEncryption))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountList))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountPatch))]
    [ModelReaderWriterBuildable(typeof(NetAppAccountResource))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupData))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupPolicyData))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupPolicyPatch))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupPolicyResource))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupVaultBackupPatch))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupVaultBackupResource))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupVaultData))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupVaultPatch))]
    [ModelReaderWriterBuildable(typeof(NetAppBackupVaultResource))]
    [ModelReaderWriterBuildable(typeof(NetAppChangeKeyVault))]
    [ModelReaderWriterBuildable(typeof(NetAppCheckAvailabilityResult))]
    [ModelReaderWriterBuildable(typeof(NetAppDestinationReplication))]
    [ModelReaderWriterBuildable(typeof(NetAppEncryptionIdentity))]
    [ModelReaderWriterBuildable(typeof(NetAppEncryptionTransitionContent))]
    [ModelReaderWriterBuildable(typeof(NetAppFilePathAvailabilityContent))]
    [ModelReaderWriterBuildable(typeof(NetAppKeyVaultPrivateEndpoint))]
    [ModelReaderWriterBuildable(typeof(NetAppKeyVaultProperties))]
    [ModelReaderWriterBuildable(typeof(NetAppKeyVaultStatusResult))]
    [ModelReaderWriterBuildable(typeof(NetAppLdapSearchScopeConfiguration))]
    [ModelReaderWriterBuildable(typeof(NetAppNameAvailabilityContent))]
    [ModelReaderWriterBuildable(typeof(NetAppQuotaAvailabilityContent))]
    [ModelReaderWriterBuildable(typeof(NetAppRegionInfo))]
    [ModelReaderWriterBuildable(typeof(NetAppReplicationObject))]
    [ModelReaderWriterBuildable(typeof(NetAppRestoreStatus))]
    [ModelReaderWriterBuildable(typeof(NetAppSubscriptionQuotaItem))]
    [ModelReaderWriterBuildable(typeof(NetAppSubvolumeInfoData))]
    [ModelReaderWriterBuildable(typeof(NetAppSubvolumeInfoPatch))]
    [ModelReaderWriterBuildable(typeof(NetAppSubvolumeInfoResource))]
    [ModelReaderWriterBuildable(typeof(NetAppSubvolumeMetadata))]
    [ModelReaderWriterBuildable(typeof(NetAppUsageName))]
    [ModelReaderWriterBuildable(typeof(NetAppUsageResult))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeAuthorizeReplicationContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBackupBackupRestoreFilesContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBackupConfiguration))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBackupDetail))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBackupStatus))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBreakFileLocksContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeBreakReplicationContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeData))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeDataProtection))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeExportPolicyRule))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeGroupData))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeGroupMetadata))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeGroupResource))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeGroupResult))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeGroupVolume))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeMountTarget))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumePatch))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumePatchDataProtection))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumePlacementRule))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumePoolChangeContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeQuotaRuleData))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeQuotaRulePatch))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeQuotaRuleResource))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeReestablishReplicationContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeRelocationProperties))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeReplication))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeReplicationStatus))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeResource))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeRevertContent))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeSnapshotData))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeSnapshotResource))]
    [ModelReaderWriterBuildable(typeof(NetAppVolumeSnapshotRestoreFilesContent))]
    [ModelReaderWriterBuildable(typeof(NetworkSiblingSet))]
    [ModelReaderWriterBuildable(typeof(NicInfo))]
    [ModelReaderWriterBuildable(typeof(PeerClusterForVolumeMigrationContent))]
    [ModelReaderWriterBuildable(typeof(QueryNetworkSiblingSetContent))]
    [ModelReaderWriterBuildable(typeof(RegionInfoResource))]
    [ModelReaderWriterBuildable(typeof(RegionInfoResourceData))]
    [ModelReaderWriterBuildable(typeof(RegionInfosList))]
    [ModelReaderWriterBuildable(typeof(RelocateVolumeContent))]
    [ModelReaderWriterBuildable(typeof(RemotePath))]
    [ModelReaderWriterBuildable(typeof(ResponseError))]
    [ModelReaderWriterBuildable(typeof(SnapshotPoliciesList))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyDailySchedule))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyData))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyHourlySchedule))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyMonthlySchedule))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyPatch))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyResource))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyVolumeList))]
    [ModelReaderWriterBuildable(typeof(SnapshotPolicyWeeklySchedule))]
    [ModelReaderWriterBuildable(typeof(SnapshotsList))]
    [ModelReaderWriterBuildable(typeof(SubscriptionQuotaItemList))]
    [ModelReaderWriterBuildable(typeof(SubvolumesList))]
    [ModelReaderWriterBuildable(typeof(SvmPeerCommandResult))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(UpdateNetworkSiblingSetContent))]
    [ModelReaderWriterBuildable(typeof(UsagesListResult))]
    [ModelReaderWriterBuildable(typeof(UserAssignedIdentity))]
    [ModelReaderWriterBuildable(typeof(VolumeGroupList))]
    [ModelReaderWriterBuildable(typeof(VolumeList))]
    [ModelReaderWriterBuildable(typeof(VolumePatchPropertiesExportPolicy))]
    [ModelReaderWriterBuildable(typeof(VolumePropertiesExportPolicy))]
    [ModelReaderWriterBuildable(typeof(VolumeQuotaRulesList))]
    [ModelReaderWriterBuildable(typeof(VolumeSnapshotProperties))]
    public partial class AzureResourceManagerNetAppContext : ModelReaderWriterContext
    {
    }
}

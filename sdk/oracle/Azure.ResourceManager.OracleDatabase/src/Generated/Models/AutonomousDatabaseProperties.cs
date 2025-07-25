// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Autonomous Database resource model. </summary>
    public partial class AutonomousDatabaseProperties : AutonomousDatabaseBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseProperties"/>. </summary>
        public AutonomousDatabaseProperties()
        {
            DataBaseType = OracleDataBaseType.Regular;
        }

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseProperties"/>. </summary>
        /// <param name="adminPassword"> Admin password. </param>
        /// <param name="dataBaseType"> Database type to be created. </param>
        /// <param name="autonomousMaintenanceScheduleType"> The maintenance schedule type of the Autonomous Database Serverless. </param>
        /// <param name="characterSet"> The character set for the autonomous database. </param>
        /// <param name="computeCount"> The compute amount (CPUs) available to the database. </param>
        /// <param name="databaseComputeModel"> The compute model of the Autonomous Database. </param>
        /// <param name="cpuCoreCount"> The number of CPU cores to be made available to the database. </param>
        /// <param name="customerContacts"> Customer Contacts. </param>
        /// <param name="dataStorageSizeInTbs"> The quantity of data in the database, in terabytes. </param>
        /// <param name="dataStorageSizeInGbs"> The size, in gigabytes, of the data volume that will be created and attached to the database. </param>
        /// <param name="dbVersion"> A valid Oracle Database version for Autonomous Database. </param>
        /// <param name="dbWorkload"> The Autonomous Database workload type. </param>
        /// <param name="displayName"> The user-friendly name for the Autonomous Database. </param>
        /// <param name="isAutoScalingEnabled"> Indicates if auto scaling is enabled for the Autonomous Database CPU core count. </param>
        /// <param name="isAutoScalingForStorageEnabled"> Indicates if auto scaling is enabled for the Autonomous Database storage. </param>
        /// <param name="peerDBIds"> The list of Azure resource IDs of standby databases located in Autonomous Data Guard remote regions that are associated with the source database. Note that for Autonomous Database Serverless instances, standby databases located in the same region as the source primary database do not have Azure IDs. </param>
        /// <param name="peerDBId"> The Azure resource ID of the Disaster Recovery peer database, which is located in a different region from the current peer database. </param>
        /// <param name="isLocalDataGuardEnabled"> Indicates whether the Autonomous Database has local or called in-region Data Guard enabled. </param>
        /// <param name="isRemoteDataGuardEnabled"> Indicates whether the Autonomous Database has Cross Region Data Guard enabled. </param>
        /// <param name="localDisasterRecoveryType"> Indicates the local disaster recovery (DR) type of the Autonomous Database Serverless instance.Autonomous Data Guard (ADG) DR type provides business critical DR with a faster recovery time objective (RTO) during failover or switchover.Backup-based DR type provides lower cost DR with a slower RTO during failover or switchover. </param>
        /// <param name="disasterRecoveryRoleChangedOn"> The date and time the Disaster Recovery role was switched for the standby Autonomous Database. </param>
        /// <param name="remoteDisasterRecoveryConfiguration"> Indicates remote disaster recovery configuration. </param>
        /// <param name="localStandbyDB"> Local Autonomous Disaster Recovery standby database details. </param>
        /// <param name="failedDataRecoveryInSeconds"> Indicates the number of seconds of data loss for a Data Guard failover. </param>
        /// <param name="isMtlsConnectionRequired"> Specifies if the Autonomous Database requires mTLS connections. </param>
        /// <param name="isPreviewVersionWithServiceTermsAccepted"> Specifies if the Autonomous Database preview version is being provisioned. </param>
        /// <param name="licenseModel"> The Oracle license model that applies to the Oracle Autonomous Database. The default is LICENSE_INCLUDED. </param>
        /// <param name="ncharacterSet"> The character set for the Autonomous Database. </param>
        /// <param name="lifecycleDetails"> Additional information about the current lifecycle state. </param>
        /// <param name="provisioningState"> Azure resource provisioning state. </param>
        /// <param name="lifecycleState"> Views lifecycleState. </param>
        /// <param name="scheduledOperations"> The list of scheduled operations. </param>
        /// <param name="privateEndpointIP"> The private endpoint Ip address for the resource. </param>
        /// <param name="privateEndpointLabel"> The resource's private endpoint label. </param>
        /// <param name="ociUri"> HTTPS link to OCI resources exposed to Azure Customer via Azure Interface. </param>
        /// <param name="subnetId"> Client subnet. </param>
        /// <param name="vnetId"> VNET for network connectivity. </param>
        /// <param name="createdOn"> The date and time that the database was created. </param>
        /// <param name="maintenanceBeginOn"> The date and time when maintenance will begin. </param>
        /// <param name="maintenanceEndOn"> The date and time when maintenance will end. </param>
        /// <param name="actualUsedDataStorageSizeInTbs"> The current amount of storage in use for user and system data, in terabytes (TB). </param>
        /// <param name="allocatedStorageSizeInTbs"> The amount of storage currently allocated for the database tables and billed for, rounded up. </param>
        /// <param name="apexDetails"> Information about Oracle APEX Application Development. </param>
        /// <param name="availableUpgradeVersions"> List of Oracle Database versions available for a database upgrade. If there are no version upgrades available, this list is empty. </param>
        /// <param name="connectionStrings"> The connection string used to connect to the Autonomous Database. </param>
        /// <param name="connectionUrls"> The URLs for accessing Oracle Application Express (APEX) and SQL Developer Web with a browser from a Compute instance within your VCN or that has a direct connection to your VCN. </param>
        /// <param name="dataSafeStatus"> Status of the Data Safe registration for this Autonomous Database. </param>
        /// <param name="databaseEdition"> The Oracle Database Edition that applies to the Autonomous databases. </param>
        /// <param name="autonomousDatabaseId"> Autonomous Database ID. </param>
        /// <param name="inMemoryAreaInGbs"> The area assigned to In-Memory tables in Autonomous Database. </param>
        /// <param name="nextLongTermBackupCreatedOn"> The date and time when the next long-term backup would be created. </param>
        /// <param name="longTermBackupSchedule"> Details for the long-term backup schedule. </param>
        /// <param name="isPreview"> Indicates if the Autonomous Database version is a preview version. </param>
        /// <param name="localAdgAutoFailoverMaxDataLossLimit"> Parameter that allows users to select an acceptable maximum data loss limit in seconds, up to which Automatic Failover will be triggered when necessary for a Local Autonomous Data Guard. </param>
        /// <param name="memoryPerOracleComputeUnitInGbs"> The amount of memory (in GBs) enabled per ECPU or OCPU. </param>
        /// <param name="openMode"> Indicates the Autonomous Database mode. </param>
        /// <param name="operationsInsightsStatus"> Status of Operations Insights for this Autonomous Database. </param>
        /// <param name="permissionLevel"> The Autonomous Database permission level. </param>
        /// <param name="privateEndpoint"> The private endpoint for the resource. </param>
        /// <param name="provisionableCpus"> An array of CPU values that an Autonomous Database can be scaled to. </param>
        /// <param name="role"> The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled. </param>
        /// <param name="serviceConsoleUri"> The URL of the Service Console for the Autonomous Database. </param>
        /// <param name="sqlWebDeveloperUri"> The SQL Web Developer URL for the Oracle Autonomous Database. </param>
        /// <param name="supportedRegionsToCloneTo"> The list of regions that support the creation of an Autonomous Database clone or an Autonomous Data Guard standby database. </param>
        /// <param name="dataGuardRoleChangedOn"> The date and time the Autonomous Data Guard role was switched for the Autonomous Database. </param>
        /// <param name="freeAutonomousDatabaseDeletedOn"> The date and time the Always Free database will be automatically deleted because of inactivity. </param>
        /// <param name="timeLocalDataGuardEnabled"> The date and time that Autonomous Data Guard was enabled for an Autonomous Database where the standby was provisioned in the same region as the primary database. </param>
        /// <param name="lastFailoverHappenedOn"> The timestamp of the last failover operation. </param>
        /// <param name="lastRefreshHappenedOn"> The date and time when last refresh happened. </param>
        /// <param name="lastRefreshPointTimestamp"> The refresh point timestamp (UTC). </param>
        /// <param name="lastSwitchoverHappenedOn"> The timestamp of the last switchover operation for the Autonomous Database. </param>
        /// <param name="freeAutonomousDatabaseStoppedOn"> The date and time the Always Free database will be stopped because of inactivity. </param>
        /// <param name="usedDataStorageSizeInGbs"> The storage space consumed by Autonomous Database in GBs. </param>
        /// <param name="usedDataStorageSizeInTbs"> The amount of storage that has been used, in terabytes. </param>
        /// <param name="databaseOcid"> Database ocid. </param>
        /// <param name="backupRetentionPeriodInDays"> Retention period, in days, for long-term backups. </param>
        /// <param name="whitelistedIPs"> The client IP access control list (ACL). This is an array of CIDR notations and/or IP addresses. Values should be separate strings, separated by commas. Example: ['1.1.1.1','1.1.1.0/24','1.1.2.25']. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutonomousDatabaseProperties(string adminPassword, OracleDataBaseType dataBaseType, AutonomousMaintenanceScheduleType? autonomousMaintenanceScheduleType, string characterSet, float? computeCount, OracleDatabaseComputeModel? databaseComputeModel, int? cpuCoreCount, IList<OracleCustomerContact> customerContacts, int? dataStorageSizeInTbs, int? dataStorageSizeInGbs, string dbVersion, AutonomousDatabaseWorkloadType? dbWorkload, string displayName, bool? isAutoScalingEnabled, bool? isAutoScalingForStorageEnabled, IReadOnlyList<string> peerDBIds, string peerDBId, bool? isLocalDataGuardEnabled, bool? isRemoteDataGuardEnabled, DisasterRecoveryType? localDisasterRecoveryType, DateTimeOffset? disasterRecoveryRoleChangedOn, DisasterRecoveryConfigurationDetails remoteDisasterRecoveryConfiguration, AutonomousDatabaseStandbySummary localStandbyDB, int? failedDataRecoveryInSeconds, bool? isMtlsConnectionRequired, bool? isPreviewVersionWithServiceTermsAccepted, OracleLicenseModel? licenseModel, string ncharacterSet, string lifecycleDetails, OracleDatabaseProvisioningState? provisioningState, AutonomousDatabaseLifecycleState? lifecycleState, ScheduledOperationsType scheduledOperations, string privateEndpointIP, string privateEndpointLabel, Uri ociUri, ResourceIdentifier subnetId, ResourceIdentifier vnetId, DateTimeOffset? createdOn, DateTimeOffset? maintenanceBeginOn, DateTimeOffset? maintenanceEndOn, double? actualUsedDataStorageSizeInTbs, double? allocatedStorageSizeInTbs, OracleApexDetailsType apexDetails, IReadOnlyList<string> availableUpgradeVersions, AutonomousDatabaseConnectionStrings connectionStrings, AutonomousDatabaseConnectionUrls connectionUrls, DataSafeStatusType? dataSafeStatus, OracleDatabaseEditionType? databaseEdition, ResourceIdentifier autonomousDatabaseId, int? inMemoryAreaInGbs, DateTimeOffset? nextLongTermBackupCreatedOn, LongTermBackUpScheduleDetails longTermBackupSchedule, bool? isPreview, int? localAdgAutoFailoverMaxDataLossLimit, int? memoryPerOracleComputeUnitInGbs, AutonomousDatabaseModeType? openMode, OperationsInsightsStatusType? operationsInsightsStatus, AutonomousDatabasePermissionLevelType? permissionLevel, string privateEndpoint, IReadOnlyList<int> provisionableCpus, DataGuardRoleType? role, Uri serviceConsoleUri, Uri sqlWebDeveloperUri, IReadOnlyList<string> supportedRegionsToCloneTo, DateTimeOffset? dataGuardRoleChangedOn, DateTimeOffset? freeAutonomousDatabaseDeletedOn, string timeLocalDataGuardEnabled, DateTimeOffset? lastFailoverHappenedOn, DateTimeOffset? lastRefreshHappenedOn, DateTimeOffset? lastRefreshPointTimestamp, DateTimeOffset? lastSwitchoverHappenedOn, DateTimeOffset? freeAutonomousDatabaseStoppedOn, int? usedDataStorageSizeInGbs, int? usedDataStorageSizeInTbs, string databaseOcid, int? backupRetentionPeriodInDays, IList<string> whitelistedIPs, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(adminPassword, dataBaseType, autonomousMaintenanceScheduleType, characterSet, computeCount, databaseComputeModel, cpuCoreCount, customerContacts, dataStorageSizeInTbs, dataStorageSizeInGbs, dbVersion, dbWorkload, displayName, isAutoScalingEnabled, isAutoScalingForStorageEnabled, peerDBIds, peerDBId, isLocalDataGuardEnabled, isRemoteDataGuardEnabled, localDisasterRecoveryType, disasterRecoveryRoleChangedOn, remoteDisasterRecoveryConfiguration, localStandbyDB, failedDataRecoveryInSeconds, isMtlsConnectionRequired, isPreviewVersionWithServiceTermsAccepted, licenseModel, ncharacterSet, lifecycleDetails, provisioningState, lifecycleState, scheduledOperations, privateEndpointIP, privateEndpointLabel, ociUri, subnetId, vnetId, createdOn, maintenanceBeginOn, maintenanceEndOn, actualUsedDataStorageSizeInTbs, allocatedStorageSizeInTbs, apexDetails, availableUpgradeVersions, connectionStrings, connectionUrls, dataSafeStatus, databaseEdition, autonomousDatabaseId, inMemoryAreaInGbs, nextLongTermBackupCreatedOn, longTermBackupSchedule, isPreview, localAdgAutoFailoverMaxDataLossLimit, memoryPerOracleComputeUnitInGbs, openMode, operationsInsightsStatus, permissionLevel, privateEndpoint, provisionableCpus, role, serviceConsoleUri, sqlWebDeveloperUri, supportedRegionsToCloneTo, dataGuardRoleChangedOn, freeAutonomousDatabaseDeletedOn, timeLocalDataGuardEnabled, lastFailoverHappenedOn, lastRefreshHappenedOn, lastRefreshPointTimestamp, lastSwitchoverHappenedOn, freeAutonomousDatabaseStoppedOn, usedDataStorageSizeInGbs, usedDataStorageSizeInTbs, databaseOcid, backupRetentionPeriodInDays, whitelistedIPs, serializedAdditionalRawData)
        {
            DataBaseType = dataBaseType;
        }
    }
}

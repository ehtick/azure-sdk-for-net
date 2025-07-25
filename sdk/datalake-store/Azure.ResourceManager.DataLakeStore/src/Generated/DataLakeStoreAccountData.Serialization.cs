// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class DataLakeStoreAccountData : IUtf8JsonSerializable, IJsonModel<DataLakeStoreAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreAccountData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeStoreAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultGroup))
            {
                writer.WritePropertyName("defaultGroup"u8);
                writer.WriteStringValue(DefaultGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(EncryptionConfig))
            {
                writer.WritePropertyName("encryptionConfig"u8);
                writer.WriteObjectValue(EncryptionConfig, options);
            }
            if (options.Format != "W" && Optional.IsDefined(EncryptionState))
            {
                writer.WritePropertyName("encryptionState"u8);
                writer.WriteStringValue(EncryptionState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(EncryptionProvisioningState))
            {
                writer.WritePropertyName("encryptionProvisioningState"u8);
                writer.WriteStringValue(EncryptionProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TrustedIdProviders))
            {
                writer.WritePropertyName("trustedIdProviders"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedIdProviders)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TrustedIdProviderState))
            {
                writer.WritePropertyName("trustedIdProviderState"u8);
                writer.WriteStringValue(TrustedIdProviderState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentTier))
            {
                writer.WritePropertyName("currentTier"u8);
                writer.WriteStringValue(CurrentTier.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        DataLakeStoreAccountData IJsonModel<DataLakeStoreAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountData(document.RootElement, options);
        }

        internal static DataLakeStoreAccountData DeserializeDataLakeStoreAccountData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            AzureLocation? location = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? accountId = default;
            DataLakeStoreAccountStatus? provisioningState = default;
            DataLakeStoreAccountState? state = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastModifiedTime = default;
            string endpoint = default;
            string defaultGroup = default;
            DataLakeStoreAccountEncryptionConfig encryptionConfig = default;
            DataLakeStoreEncryptionState? encryptionState = default;
            DataLakeStoreEncryptionProvisioningState? encryptionProvisioningState = default;
            IReadOnlyList<DataLakeStoreFirewallRuleData> firewallRules = default;
            IReadOnlyList<DataLakeStoreVirtualNetworkRuleData> virtualNetworkRules = default;
            DataLakeStoreFirewallState? firewallState = default;
            DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs = default;
            IReadOnlyList<DataLakeStoreTrustedIdProviderData> trustedIdProviders = default;
            DataLakeStoreTrustedIdProviderState? trustedIdProviderState = default;
            DataLakeStoreCommitmentTierType? newTier = default;
            DataLakeStoreCommitmentTierType? currentTier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerDataLakeStoreContext.Default);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataLakeStoreContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToDataLakeStoreAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToDataLakeStoreAccountState();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroup"u8))
                        {
                            defaultGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionConfig = DataLakeStoreAccountEncryptionConfig.DeserializeDataLakeStoreAccountEncryptionConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryptionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionState = property0.Value.GetString().ToDataLakeStoreEncryptionState();
                            continue;
                        }
                        if (property0.NameEquals("encryptionProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProvisioningState = property0.Value.GetString().ToDataLakeStoreEncryptionProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreFirewallRuleData> array = new List<DataLakeStoreFirewallRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreFirewallRuleData.DeserializeDataLakeStoreFirewallRuleData(item, options));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreVirtualNetworkRuleData> array = new List<DataLakeStoreVirtualNetworkRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreVirtualNetworkRuleData.DeserializeDataLakeStoreVirtualNetworkRuleData(item, options));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeStoreFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeStoreFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreTrustedIdProviderData> array = new List<DataLakeStoreTrustedIdProviderData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(item, options));
                            }
                            trustedIdProviders = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviderState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedIdProviderState = property0.Value.GetString().ToDataLakeStoreTrustedIdProviderState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("currentTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataLakeStoreAccountData(
                id,
                name,
                type,
                systemData,
                identity,
                accountId,
                provisioningState,
                state,
                creationTime,
                lastModifiedTime,
                endpoint,
                defaultGroup,
                encryptionConfig,
                encryptionState,
                encryptionProvisioningState,
                firewallRules ?? new ChangeTrackingList<DataLakeStoreFirewallRuleData>(),
                virtualNetworkRules ?? new ChangeTrackingList<DataLakeStoreVirtualNetworkRuleData>(),
                firewallState,
                firewallAllowAzureIPs,
                trustedIdProviders ?? new ChangeTrackingList<DataLakeStoreTrustedIdProviderData>(),
                trustedIdProviderState,
                newTier,
                currentTier,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreAccountData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataLakeStoreContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountData)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeStoreAccountData IPersistableModel<DataLakeStoreAccountData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataLakeStoreAccountData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

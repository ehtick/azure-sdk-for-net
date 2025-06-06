// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupResourceEncryptionConfig : IUtf8JsonSerializable, IJsonModel<BackupResourceEncryptionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceEncryptionConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupResourceEncryptionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EncryptionAtRestType))
            {
                writer.WritePropertyName("encryptionAtRestType"u8);
                writer.WriteStringValue(EncryptionAtRestType.Value.ToString());
            }
            if (Optional.IsDefined(KeyUri))
            {
                writer.WritePropertyName("keyUri"u8);
                writer.WriteStringValue(KeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(LastUpdateStatus))
            {
                writer.WritePropertyName("lastUpdateStatus"u8);
                writer.WriteStringValue(LastUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryptionState))
            {
                writer.WritePropertyName("infrastructureEncryptionState"u8);
                writer.WriteStringValue(InfrastructureEncryptionState.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BackupResourceEncryptionConfig IJsonModel<BackupResourceEncryptionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceEncryptionConfig(document.RootElement, options);
        }

        internal static BackupResourceEncryptionConfig DeserializeBackupResourceEncryptionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupEncryptionAtRestType? encryptionAtRestType = default;
            Uri keyUri = default;
            string subscriptionId = default;
            LastUpdateStatus? lastUpdateStatus = default;
            InfrastructureEncryptionState? infrastructureEncryptionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptionAtRestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtRestType = new BackupEncryptionAtRestType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateStatus = new LastUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryptionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryptionState = new InfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupResourceEncryptionConfig(
                encryptionAtRestType,
                keyUri,
                subscriptionId,
                lastUpdateStatus,
                infrastructureEncryptionState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupResourceEncryptionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support writing '{options.Format}' format.");
            }
        }

        BackupResourceEncryptionConfig IPersistableModel<BackupResourceEncryptionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackupResourceEncryptionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceEncryptionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

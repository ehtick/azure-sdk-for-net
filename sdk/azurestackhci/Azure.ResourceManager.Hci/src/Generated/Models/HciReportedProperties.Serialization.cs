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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciReportedProperties : IUtf8JsonSerializable, IJsonModel<HciReportedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciReportedProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciReportedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciReportedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciReportedProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(SbeDeploymentPackageInfo))
            {
                writer.WritePropertyName("sbeDeploymentPackageInfo"u8);
                writer.WriteObjectValue(SbeDeploymentPackageInfo, options);
            }
        }

        HciReportedProperties IJsonModel<HciReportedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciReportedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciReportedProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciReportedProperties(document.RootElement, options);
        }

        internal static HciReportedProperties DeserializeHciReportedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HciNetworkProfile networkProfile = default;
            HciOSProfile osProfile = default;
            SbeDeploymentPackageInfo sbeDeploymentPackageInfo = default;
            HciEdgeDeviceState? deviceState = default;
            HciEdgeDeviceExtensionProfile extensionProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = HciNetworkProfile.DeserializeHciNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = HciOSProfile.DeserializeHciOSProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sbeDeploymentPackageInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sbeDeploymentPackageInfo = SbeDeploymentPackageInfo.DeserializeSbeDeploymentPackageInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deviceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceState = new HciEdgeDeviceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extensionProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionProfile = HciEdgeDeviceExtensionProfile.DeserializeHciEdgeDeviceExtensionProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciReportedProperties(
                deviceState,
                extensionProfile,
                serializedAdditionalRawData,
                networkProfile,
                osProfile,
                sbeDeploymentPackageInfo);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkProfile))
                {
                    builder.Append("  networkProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkProfile, options, 2, false, "  networkProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OSProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  osProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OSProfile))
                {
                    builder.Append("  osProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OSProfile, options, 2, false, "  osProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SbeDeploymentPackageInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sbeDeploymentPackageInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SbeDeploymentPackageInfo))
                {
                    builder.Append("  sbeDeploymentPackageInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SbeDeploymentPackageInfo, options, 2, false, "  sbeDeploymentPackageInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeviceState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deviceState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeviceState))
                {
                    builder.Append("  deviceState: ");
                    builder.AppendLine($"'{DeviceState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("Extensions", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  extensionProfile: ");
                builder.AppendLine("{");
                builder.Append("    extensions: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(ExtensionProfile))
                {
                    builder.Append("  extensionProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ExtensionProfile, options, 2, false, "  extensionProfile: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciReportedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciReportedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHciContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciReportedProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HciReportedProperties IPersistableModel<HciReportedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciReportedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHciReportedProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciReportedProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciReportedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

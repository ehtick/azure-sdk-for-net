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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotRole : IUtf8JsonSerializable, IJsonModel<EdgeIotRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeIotRole>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeIotRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotRole)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HostPlatform))
            {
                writer.WritePropertyName("hostPlatform"u8);
                writer.WriteStringValue(HostPlatform.Value.ToString());
            }
            if (Optional.IsDefined(IotDeviceDetails))
            {
                writer.WritePropertyName("ioTDeviceDetails"u8);
                writer.WriteObjectValue(IotDeviceDetails, options);
            }
            if (Optional.IsDefined(IotEdgeDeviceDetails))
            {
                writer.WritePropertyName("ioTEdgeDeviceDetails"u8);
                writer.WriteObjectValue(IotEdgeDeviceDetails, options);
            }
            if (Optional.IsCollectionDefined(ShareMappings))
            {
                writer.WritePropertyName("shareMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ShareMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IotEdgeAgentInfo))
            {
                writer.WritePropertyName("ioTEdgeAgentInfo"u8);
                writer.WriteObjectValue(IotEdgeAgentInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(HostPlatformType))
            {
                writer.WritePropertyName("hostPlatformType"u8);
                writer.WriteStringValue(HostPlatformType.Value.ToString());
            }
            if (Optional.IsDefined(ComputeResource))
            {
                writer.WritePropertyName("computeResource"u8);
                writer.WriteObjectValue(ComputeResource, options);
            }
            if (Optional.IsDefined(RoleStatus))
            {
                writer.WritePropertyName("roleStatus"u8);
                writer.WriteStringValue(RoleStatus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        EdgeIotRole IJsonModel<EdgeIotRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotRole)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeIotRole(document.RootElement, options);
        }

        internal static EdgeIotRole DeserializeEdgeIotRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeRoleType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DataBoxEdgeOSPlatformType? hostPlatform = default;
            EdgeIotDeviceInfo iotDeviceDetails = default;
            EdgeIotDeviceInfo iotEdgeDeviceDetails = default;
            IList<DataBoxEdgeMountPointMap> shareMappings = default;
            IotEdgeAgentInfo iotEdgeAgentInfo = default;
            HostPlatformType? hostPlatformType = default;
            EdgeComputeResourceInfo computeResource = default;
            DataBoxEdgeRoleStatus? roleStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataBoxEdgeRoleType(property.Value.GetString());
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataBoxEdgeContext.Default);
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
                        if (property0.NameEquals("hostPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatform = new DataBoxEdgeOSPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ioTDeviceDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeDeviceDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotEdgeDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("shareMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeMountPointMap> array = new List<DataBoxEdgeMountPointMap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeMountPointMap.DeserializeDataBoxEdgeMountPointMap(item, options));
                            }
                            shareMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeAgentInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotEdgeAgentInfo = IotEdgeAgentInfo.DeserializeIotEdgeAgentInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hostPlatformType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatformType = new HostPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("computeResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeResource = EdgeComputeResourceInfo.DeserializeEdgeComputeResourceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("roleStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleStatus = new DataBoxEdgeRoleStatus(property0.Value.GetString());
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
            return new EdgeIotRole(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                hostPlatform,
                iotDeviceDetails,
                iotEdgeDeviceDetails,
                shareMappings ?? new ChangeTrackingList<DataBoxEdgeMountPointMap>(),
                iotEdgeAgentInfo,
                hostPlatformType,
                computeResource,
                roleStatus);
        }

        BinaryData IPersistableModel<EdgeIotRole>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeIotRole)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeIotRole IPersistableModel<EdgeIotRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeIotRole(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeIotRole)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeIotRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

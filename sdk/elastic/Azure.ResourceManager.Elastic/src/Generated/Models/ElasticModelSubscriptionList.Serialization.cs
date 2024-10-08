// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticModelSubscriptionList : IUtf8JsonSerializable, IJsonModel<ElasticModelSubscriptionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticModelSubscriptionList>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticModelSubscriptionList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticModelSubscriptionList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticModelSubscriptionList)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MonitoredSubscriptionList))
            {
                writer.WritePropertyName("monitoredSubscriptionList"u8);
                writer.WriteStartArray();
                foreach (var item in MonitoredSubscriptionList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ElasticModelSubscriptionList IJsonModel<ElasticModelSubscriptionList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticModelSubscriptionList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticModelSubscriptionList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticModelSubscriptionList(document.RootElement, options);
        }

        internal static ElasticModelSubscriptionList DeserializeElasticModelSubscriptionList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ElasticModelOperation? operation = default;
            IList<MonitoredSubscription> monitoredSubscriptionList = default;
            ProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operation = new ElasticModelOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoredSubscriptionList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitoredSubscription> array = new List<MonitoredSubscription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoredSubscription.DeserializeMonitoredSubscription(item, options));
                    }
                    monitoredSubscriptionList = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ElasticModelSubscriptionList(operation, monitoredSubscriptionList ?? new ChangeTrackingList<MonitoredSubscription>(), provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticModelSubscriptionList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticModelSubscriptionList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticModelSubscriptionList)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticModelSubscriptionList IPersistableModel<ElasticModelSubscriptionList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticModelSubscriptionList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticModelSubscriptionList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticModelSubscriptionList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticModelSubscriptionList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

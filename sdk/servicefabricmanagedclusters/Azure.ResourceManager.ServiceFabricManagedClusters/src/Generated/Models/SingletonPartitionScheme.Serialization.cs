// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class SingletonPartitionScheme : IUtf8JsonSerializable, IJsonModel<SingletonPartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingletonPartitionScheme>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SingletonPartitionScheme>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        SingletonPartitionScheme IJsonModel<SingletonPartitionScheme>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingletonPartitionScheme(document.RootElement, options);
        }

        internal static SingletonPartitionScheme DeserializeSingletonPartitionScheme(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SingletonPartitionScheme(partitionScheme, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SingletonPartitionScheme>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support writing '{options.Format}' format.");
            }
        }

        SingletonPartitionScheme IPersistableModel<SingletonPartitionScheme>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSingletonPartitionScheme(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionScheme)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingletonPartitionScheme>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

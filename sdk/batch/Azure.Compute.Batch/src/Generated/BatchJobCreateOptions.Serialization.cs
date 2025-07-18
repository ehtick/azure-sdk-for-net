// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchJobCreateOptions : IUtf8JsonSerializable, IJsonModel<BatchJobCreateOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchJobCreateOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchJobCreateOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobCreateOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobCreateOptions)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(UsesTaskDependencies))
            {
                writer.WritePropertyName("usesTaskDependencies"u8);
                writer.WriteBooleanValue(UsesTaskDependencies.Value);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(AllowTaskPreemption))
            {
                writer.WritePropertyName("allowTaskPreemption"u8);
                writer.WriteBooleanValue(AllowTaskPreemption.Value);
            }
            if (Optional.IsDefined(MaxParallelTasks))
            {
                writer.WritePropertyName("maxParallelTasks"u8);
                writer.WriteNumberValue(MaxParallelTasks.Value);
            }
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteObjectValue(Constraints, options);
            }
            if (Optional.IsDefined(JobManagerTask))
            {
                writer.WritePropertyName("jobManagerTask"u8);
                writer.WriteObjectValue(JobManagerTask, options);
            }
            if (Optional.IsDefined(JobPreparationTask))
            {
                writer.WritePropertyName("jobPreparationTask"u8);
                writer.WriteObjectValue(JobPreparationTask, options);
            }
            if (Optional.IsDefined(JobReleaseTask))
            {
                writer.WritePropertyName("jobReleaseTask"u8);
                writer.WriteObjectValue(JobReleaseTask, options);
            }
            if (Optional.IsCollectionDefined(CommonEnvironmentSettings))
            {
                writer.WritePropertyName("commonEnvironmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in CommonEnvironmentSettings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("poolInfo"u8);
            writer.WriteObjectValue(PoolInfo, options);
            if (Optional.IsDefined(AllTasksCompleteMode))
            {
                writer.WritePropertyName("onAllTasksComplete"u8);
                writer.WriteStringValue(AllTasksCompleteMode.Value.ToString());
            }
            if (Optional.IsDefined(TaskFailureMode))
            {
                writer.WritePropertyName("onTaskFailure"u8);
                writer.WriteStringValue(TaskFailureMode.Value.ToString());
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration, options);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        BatchJobCreateOptions IJsonModel<BatchJobCreateOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobCreateOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobCreateOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchJobCreateOptions(document.RootElement, options);
        }

        internal static BatchJobCreateOptions DeserializeBatchJobCreateOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string displayName = default;
            bool? usesTaskDependencies = default;
            int? priority = default;
            bool? allowTaskPreemption = default;
            int? maxParallelTasks = default;
            BatchJobConstraints constraints = default;
            BatchJobManagerTask jobManagerTask = default;
            BatchJobPreparationTask jobPreparationTask = default;
            BatchJobReleaseTask jobReleaseTask = default;
            IList<EnvironmentSetting> commonEnvironmentSettings = default;
            BatchPoolInfo poolInfo = default;
            BatchAllTasksCompleteMode? onAllTasksComplete = default;
            BatchTaskFailureMode? onTaskFailure = default;
            BatchJobNetworkConfiguration networkConfiguration = default;
            IList<BatchMetadataItem> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usesTaskDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usesTaskDependencies = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowTaskPreemption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowTaskPreemption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxParallelTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelTasks = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("constraints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constraints = BatchJobConstraints.DeserializeBatchJobConstraints(property.Value, options);
                    continue;
                }
                if (property.NameEquals("jobManagerTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobManagerTask = BatchJobManagerTask.DeserializeBatchJobManagerTask(property.Value, options);
                    continue;
                }
                if (property.NameEquals("jobPreparationTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobPreparationTask = BatchJobPreparationTask.DeserializeBatchJobPreparationTask(property.Value, options);
                    continue;
                }
                if (property.NameEquals("jobReleaseTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobReleaseTask = BatchJobReleaseTask.DeserializeBatchJobReleaseTask(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commonEnvironmentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EnvironmentSetting> array = new List<EnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnvironmentSetting.DeserializeEnvironmentSetting(item, options));
                    }
                    commonEnvironmentSettings = array;
                    continue;
                }
                if (property.NameEquals("poolInfo"u8))
                {
                    poolInfo = BatchPoolInfo.DeserializeBatchPoolInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("onAllTasksComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onAllTasksComplete = new BatchAllTasksCompleteMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onTaskFailure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onTaskFailure = new BatchTaskFailureMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = BatchJobNetworkConfiguration.DeserializeBatchJobNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchMetadataItem> array = new List<BatchMetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchMetadataItem.DeserializeBatchMetadataItem(item, options));
                    }
                    metadata = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchJobCreateOptions(
                id,
                displayName,
                usesTaskDependencies,
                priority,
                allowTaskPreemption,
                maxParallelTasks,
                constraints,
                jobManagerTask,
                jobPreparationTask,
                jobReleaseTask,
                commonEnvironmentSettings ?? new ChangeTrackingList<EnvironmentSetting>(),
                poolInfo,
                onAllTasksComplete,
                onTaskFailure,
                networkConfiguration,
                metadata ?? new ChangeTrackingList<BatchMetadataItem>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchJobCreateOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobCreateOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureComputeBatchContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BatchJobCreateOptions)} does not support writing '{options.Format}' format.");
            }
        }

        BatchJobCreateOptions IPersistableModel<BatchJobCreateOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobCreateOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchJobCreateOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchJobCreateOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchJobCreateOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchJobCreateOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBatchJobCreateOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

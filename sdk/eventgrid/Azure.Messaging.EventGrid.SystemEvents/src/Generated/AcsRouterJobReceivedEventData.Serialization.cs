// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterJobReceivedEventDataConverter))]
    public partial class AcsRouterJobReceivedEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterJobReceivedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterJobReceivedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsRouterJobReceivedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterJobReceivedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("jobStatus"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId"u8);
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("requestedWorkerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequestedWorkerSelectors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ScheduledOn))
            {
                writer.WritePropertyName("scheduledOn"u8);
                writer.WriteStringValue(ScheduledOn.Value, "O");
            }
            writer.WritePropertyName("unavailableForMatching"u8);
            writer.WriteBooleanValue(UnavailableForMatching);
        }

        AcsRouterJobReceivedEventData IJsonModel<AcsRouterJobReceivedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterJobReceivedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterJobReceivedEventData(document.RootElement, options);
        }

        internal static AcsRouterJobReceivedEventData DeserializeAcsRouterJobReceivedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AcsRouterJobStatus? jobStatus = default;
            string classificationPolicyId = default;
            int? priority = default;
            IReadOnlyList<AcsRouterWorkerSelector> requestedWorkerSelectors = default;
            DateTimeOffset? scheduledOn = default;
            bool unavailableForMatching = default;
            string queueId = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobStatus = new AcsRouterJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
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
                if (property.NameEquals("requestedWorkerSelectors"u8))
                {
                    List<AcsRouterWorkerSelector> array = new List<AcsRouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterWorkerSelector.DeserializeAcsRouterWorkerSelector(item, options));
                    }
                    requestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("scheduledOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("unavailableForMatching"u8))
                {
                    unavailableForMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsRouterJobReceivedEventData(
                jobId,
                channelReference,
                channelId,
                serializedAdditionalRawData,
                queueId,
                labels,
                tags,
                jobStatus,
                classificationPolicyId,
                priority,
                requestedWorkerSelectors,
                scheduledOn,
                unavailableForMatching);
        }

        BinaryData IPersistableModel<AcsRouterJobReceivedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureMessagingEventGridSystemEventsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AcsRouterJobReceivedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AcsRouterJobReceivedEventData IPersistableModel<AcsRouterJobReceivedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAcsRouterJobReceivedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsRouterJobReceivedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterJobReceivedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterJobReceivedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterJobReceivedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }

        internal partial class AcsRouterJobReceivedEventDataConverter : JsonConverter<AcsRouterJobReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobReceivedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model, ModelSerializationExtensions.WireOptions);
            }

            public override AcsRouterJobReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobReceivedEventData(document.RootElement);
            }
        }
    }
}

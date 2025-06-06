// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactProtocolSettings : IUtf8JsonSerializable, IJsonModel<EdifactProtocolSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactProtocolSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdifactProtocolSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactProtocolSettings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("validationSettings"u8);
            writer.WriteObjectValue(ValidationSettings, options);
            writer.WritePropertyName("framingSettings"u8);
            writer.WriteObjectValue(FramingSettings, options);
            writer.WritePropertyName("envelopeSettings"u8);
            writer.WriteObjectValue(EnvelopeSettings, options);
            writer.WritePropertyName("acknowledgementSettings"u8);
            writer.WriteObjectValue(AcknowledgementSettings, options);
            writer.WritePropertyName("messageFilter"u8);
            writer.WriteObjectValue(MessageFilter, options);
            writer.WritePropertyName("processingSettings"u8);
            writer.WriteObjectValue(ProcessingSettings, options);
            if (Optional.IsCollectionDefined(EnvelopeOverrides))
            {
                writer.WritePropertyName("envelopeOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in EnvelopeOverrides)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MessageFilterList))
            {
                writer.WritePropertyName("messageFilterList"u8);
                writer.WriteStartArray();
                foreach (var item in MessageFilterList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("schemaReferences"u8);
            writer.WriteStartArray();
            foreach (var item in SchemaReferences)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ValidationOverrides))
            {
                writer.WritePropertyName("validationOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationOverrides)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EdifactDelimiterOverrides))
            {
                writer.WritePropertyName("edifactDelimiterOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in EdifactDelimiterOverrides)
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

        EdifactProtocolSettings IJsonModel<EdifactProtocolSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactProtocolSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactProtocolSettings(document.RootElement, options);
        }

        internal static EdifactProtocolSettings DeserializeEdifactProtocolSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdifactValidationSettings validationSettings = default;
            EdifactFramingSettings framingSettings = default;
            EdifactEnvelopeSettings envelopeSettings = default;
            EdifactAcknowledgementSettings acknowledgementSettings = default;
            EdifactMessageFilter messageFilter = default;
            EdifactProcessingSettings processingSettings = default;
            IList<EdifactEnvelopeOverride> envelopeOverrides = default;
            IList<EdifactMessageIdentifier> messageFilterList = default;
            IList<EdifactSchemaReference> schemaReferences = default;
            IList<EdifactValidationOverride> validationOverrides = default;
            IList<EdifactDelimiterOverride> edifactDelimiterOverrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationSettings"u8))
                {
                    validationSettings = EdifactValidationSettings.DeserializeEdifactValidationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("framingSettings"u8))
                {
                    framingSettings = EdifactFramingSettings.DeserializeEdifactFramingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("envelopeSettings"u8))
                {
                    envelopeSettings = EdifactEnvelopeSettings.DeserializeEdifactEnvelopeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("acknowledgementSettings"u8))
                {
                    acknowledgementSettings = EdifactAcknowledgementSettings.DeserializeEdifactAcknowledgementSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("messageFilter"u8))
                {
                    messageFilter = EdifactMessageFilter.DeserializeEdifactMessageFilter(property.Value, options);
                    continue;
                }
                if (property.NameEquals("processingSettings"u8))
                {
                    processingSettings = EdifactProcessingSettings.DeserializeEdifactProcessingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("envelopeOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdifactEnvelopeOverride> array = new List<EdifactEnvelopeOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdifactEnvelopeOverride.DeserializeEdifactEnvelopeOverride(item, options));
                    }
                    envelopeOverrides = array;
                    continue;
                }
                if (property.NameEquals("messageFilterList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdifactMessageIdentifier> array = new List<EdifactMessageIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdifactMessageIdentifier.DeserializeEdifactMessageIdentifier(item, options));
                    }
                    messageFilterList = array;
                    continue;
                }
                if (property.NameEquals("schemaReferences"u8))
                {
                    List<EdifactSchemaReference> array = new List<EdifactSchemaReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdifactSchemaReference.DeserializeEdifactSchemaReference(item, options));
                    }
                    schemaReferences = array;
                    continue;
                }
                if (property.NameEquals("validationOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdifactValidationOverride> array = new List<EdifactValidationOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdifactValidationOverride.DeserializeEdifactValidationOverride(item, options));
                    }
                    validationOverrides = array;
                    continue;
                }
                if (property.NameEquals("edifactDelimiterOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdifactDelimiterOverride> array = new List<EdifactDelimiterOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdifactDelimiterOverride.DeserializeEdifactDelimiterOverride(item, options));
                    }
                    edifactDelimiterOverrides = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdifactProtocolSettings(
                validationSettings,
                framingSettings,
                envelopeSettings,
                acknowledgementSettings,
                messageFilter,
                processingSettings,
                envelopeOverrides ?? new ChangeTrackingList<EdifactEnvelopeOverride>(),
                messageFilterList ?? new ChangeTrackingList<EdifactMessageIdentifier>(),
                schemaReferences,
                validationOverrides ?? new ChangeTrackingList<EdifactValidationOverride>(),
                edifactDelimiterOverrides ?? new ChangeTrackingList<EdifactDelimiterOverride>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactProtocolSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdifactProtocolSettings)} does not support writing '{options.Format}' format.");
            }
        }

        EdifactProtocolSettings IPersistableModel<EdifactProtocolSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdifactProtocolSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdifactProtocolSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdifactProtocolSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

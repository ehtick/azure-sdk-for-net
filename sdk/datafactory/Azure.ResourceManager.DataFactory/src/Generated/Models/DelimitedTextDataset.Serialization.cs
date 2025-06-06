// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DelimitedTextDataset : IUtf8JsonSerializable, IJsonModel<DelimitedTextDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DelimitedTextDataset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DelimitedTextDataset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DataLocation))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(DataLocation, options);
            }
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                JsonSerializer.Serialize(writer, ColumnDelimiter);
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter"u8);
                JsonSerializer.Serialize(writer, RowDelimiter);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                JsonSerializer.Serialize(writer, EncodingName);
            }
            if (Optional.IsDefined(CompressionCodec))
            {
                writer.WritePropertyName("compressionCodec"u8);
                JsonSerializer.Serialize(writer, CompressionCodec);
            }
            if (Optional.IsDefined(CompressionLevel))
            {
                writer.WritePropertyName("compressionLevel"u8);
                JsonSerializer.Serialize(writer, CompressionLevel);
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar"u8);
                JsonSerializer.Serialize(writer, QuoteChar);
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar"u8);
                JsonSerializer.Serialize(writer, EscapeChar);
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader"u8);
                JsonSerializer.Serialize(writer, FirstRowAsHeader);
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue"u8);
                JsonSerializer.Serialize(writer, NullValue);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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

        DelimitedTextDataset IJsonModel<DelimitedTextDataset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDelimitedTextDataset(document.RootElement, options);
        }

        internal static DelimitedTextDataset DeserializeDelimitedTextDataset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string description = default;
            DataFactoryElement<IList<DatasetDataElement>> structure = default;
            DataFactoryElement<IList<DatasetSchemaDataElement>> schema = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DatasetFolder folder = default;
            DatasetLocation location = default;
            DataFactoryElement<string> columnDelimiter = default;
            DataFactoryElement<string> rowDelimiter = default;
            DataFactoryElement<string> encodingName = default;
            DataFactoryElement<string> compressionCodec = default;
            DataFactoryElement<string> compressionLevel = default;
            DataFactoryElement<string> quoteChar = default;
            DataFactoryElement<string> escapeChar = default;
            DataFactoryElement<bool> firstRowAsHeader = default;
            DataFactoryElement<string> nullValue = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetSchemaDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value, options);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("columnDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            columnDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("rowDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rowDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encodingName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encodingName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionCodec"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionCodec = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("quoteChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quoteChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("escapeChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            escapeChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firstRowAsHeader"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstRowAsHeader = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("nullValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nullValue = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextDataset(
                type,
                description,
                structure,
                schema,
                linkedServiceName,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                folder,
                additionalProperties,
                location,
                columnDelimiter,
                rowDelimiter,
                encodingName,
                compressionCodec,
                compressionLevel,
                quoteChar,
                escapeChar,
                firstRowAsHeader,
                nullValue);
        }

        BinaryData IPersistableModel<DelimitedTextDataset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support writing '{options.Format}' format.");
            }
        }

        DelimitedTextDataset IPersistableModel<DelimitedTextDataset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDelimitedTextDataset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextDataset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DelimitedTextDataset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

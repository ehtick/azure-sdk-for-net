// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DelimitedTextDatasetConverter))]
    public partial class DelimitedTextDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure"u8);
                writer.WriteObjectValue<object>(Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue<object>(Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(Location);
            }
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                writer.WriteObjectValue<object>(ColumnDelimiter);
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter"u8);
                writer.WriteObjectValue<object>(RowDelimiter);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                writer.WriteObjectValue<object>(EncodingName);
            }
            if (Optional.IsDefined(CompressionCodec))
            {
                writer.WritePropertyName("compressionCodec"u8);
                writer.WriteObjectValue<object>(CompressionCodec);
            }
            if (Optional.IsDefined(CompressionLevel))
            {
                writer.WritePropertyName("compressionLevel"u8);
                writer.WriteObjectValue<object>(CompressionLevel);
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar"u8);
                writer.WriteObjectValue<object>(QuoteChar);
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar"u8);
                writer.WriteObjectValue<object>(EscapeChar);
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader"u8);
                writer.WriteObjectValue<object>(FirstRowAsHeader);
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue"u8);
                writer.WriteObjectValue<object>(NullValue);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextDataset DeserializeDelimitedTextDataset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string description = default;
            object structure = default;
            object schema = default;
            LinkedServiceReference linkedServiceName = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            DatasetFolder folder = default;
            DatasetLocation location = default;
            object columnDelimiter = default;
            object rowDelimiter = default;
            object encodingName = default;
            object compressionCodec = default;
            object compressionLevel = default;
            object quoteChar = default;
            object escapeChar = default;
            object firstRowAsHeader = default;
            object nullValue = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
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
                    structure = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
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
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
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
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
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
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("columnDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            columnDelimiter = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("rowDelimiter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rowDelimiter = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encodingName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encodingName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("compressionCodec"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionCodec = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("compressionLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compressionLevel = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("quoteChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quoteChar = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("escapeChar"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            escapeChar = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("firstRowAsHeader"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstRowAsHeader = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("nullValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nullValue = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextDataset(
                type,
                description,
                structure,
                schema,
                linkedServiceName,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
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

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DelimitedTextDataset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDelimitedTextDataset(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class DelimitedTextDatasetConverter : JsonConverter<DelimitedTextDataset>
        {
            public override void Write(Utf8JsonWriter writer, DelimitedTextDataset model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DelimitedTextDataset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDelimitedTextDataset(document.RootElement);
            }
        }
    }
}

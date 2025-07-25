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
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    public partial class ResourceRecommendationBaseData : IUtf8JsonSerializable, IJsonModel<ResourceRecommendationBaseData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceRecommendationBaseData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceRecommendationBaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceRecommendationBaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceRecommendationBaseData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Impact))
            {
                writer.WritePropertyName("impact"u8);
                writer.WriteStringValue(Impact.Value.ToString());
            }
            if (Optional.IsDefined(ImpactedField))
            {
                writer.WritePropertyName("impactedField"u8);
                writer.WriteStringValue(ImpactedField);
            }
            if (Optional.IsDefined(ImpactedValue))
            {
                writer.WritePropertyName("impactedValue"u8);
                writer.WriteStringValue(ImpactedValue);
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated.Value, "O");
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecommendationTypeId))
            {
                writer.WritePropertyName("recommendationTypeId"u8);
                writer.WriteStringValue(RecommendationTypeId);
            }
            if (Optional.IsDefined(Risk))
            {
                writer.WritePropertyName("risk"u8);
                writer.WriteStringValue(Risk.Value.ToString());
            }
            if (Optional.IsDefined(ShortDescription))
            {
                writer.WritePropertyName("shortDescription"u8);
                writer.WriteObjectValue(ShortDescription, options);
            }
            if (Optional.IsCollectionDefined(SuppressionIds))
            {
                writer.WritePropertyName("suppressionIds"u8);
                writer.WriteStartArray();
                foreach (var item in SuppressionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ResourceMetadata))
            {
                writer.WritePropertyName("resourceMetadata"u8);
                writer.WriteObjectValue(ResourceMetadata, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(LearnMoreLink))
            {
                writer.WritePropertyName("learnMoreLink"u8);
                writer.WriteStringValue(LearnMoreLink);
            }
            if (Optional.IsDefined(PotentialBenefits))
            {
                writer.WritePropertyName("potentialBenefits"u8);
                writer.WriteStringValue(PotentialBenefits);
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item)
                    {
                        writer.WritePropertyName(item0.Key);
                        if (item0.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item0.Value, ModelSerializationExtensions.JsonDocumentOptions))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Remediation))
            {
                writer.WritePropertyName("remediation"u8);
                writer.WriteStartObject();
                foreach (var item in Remediation)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ExposedMetadataProperties))
            {
                writer.WritePropertyName("exposedMetadataProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExposedMetadataProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        ResourceRecommendationBaseData IJsonModel<ResourceRecommendationBaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceRecommendationBaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceRecommendationBaseData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceRecommendationBaseData(document.RootElement, options);
        }

        internal static ResourceRecommendationBaseData DeserializeResourceRecommendationBaseData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Category? category = default;
            Impact? impact = default;
            string impactedField = default;
            string impactedValue = default;
            DateTimeOffset? lastUpdated = default;
            IDictionary<string, BinaryData> metadata = default;
            string recommendationTypeId = default;
            Risk? risk = default;
            ShortDescription shortDescription = default;
            IList<Guid> suppressionIds = default;
            IDictionary<string, string> extendedProperties = default;
            ResourceMetadata resourceMetadata = default;
            string description = default;
            string label = default;
            string learnMoreLink = default;
            string potentialBenefits = default;
            IList<IDictionary<string, BinaryData>> actions = default;
            IDictionary<string, BinaryData> remediation = default;
            IDictionary<string, BinaryData> exposedMetadataProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAdvisorContext.Default);
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
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new Category(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("impact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            impact = new Impact(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("impactedField"u8))
                        {
                            impactedField = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("impactedValue"u8))
                        {
                            impactedValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("recommendationTypeId"u8))
                        {
                            recommendationTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("risk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            risk = new Risk(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shortDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shortDescription = ShortDescription.DeserializeShortDescription(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("suppressionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            suppressionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("resourceMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceMetadata = ResourceMetadata.DeserializeResourceMetadata(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("label"u8))
                        {
                            label = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("learnMoreLink"u8))
                        {
                            learnMoreLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("potentialBenefits"u8))
                        {
                            potentialBenefits = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IDictionary<string, BinaryData>> array = new List<IDictionary<string, BinaryData>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                                    foreach (var property1 in item.EnumerateObject())
                                    {
                                        if (property1.Value.ValueKind == JsonValueKind.Null)
                                        {
                                            dictionary.Add(property1.Name, null);
                                        }
                                        else
                                        {
                                            dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                        }
                                    }
                                    array.Add(dictionary);
                                }
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("remediation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            remediation = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("exposedMetadataProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            exposedMetadataProperties = dictionary;
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
            return new ResourceRecommendationBaseData(
                id,
                name,
                type,
                systemData,
                category,
                impact,
                impactedField,
                impactedValue,
                lastUpdated,
                metadata ?? new ChangeTrackingDictionary<string, BinaryData>(),
                recommendationTypeId,
                risk,
                shortDescription,
                suppressionIds ?? new ChangeTrackingList<Guid>(),
                extendedProperties ?? new ChangeTrackingDictionary<string, string>(),
                resourceMetadata,
                description,
                label,
                learnMoreLink,
                potentialBenefits,
                actions ?? new ChangeTrackingList<IDictionary<string, BinaryData>>(),
                remediation ?? new ChangeTrackingDictionary<string, BinaryData>(),
                exposedMetadataProperties ?? new ChangeTrackingDictionary<string, BinaryData>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceRecommendationBaseData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceRecommendationBaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAdvisorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ResourceRecommendationBaseData)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceRecommendationBaseData IPersistableModel<ResourceRecommendationBaseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceRecommendationBaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceRecommendationBaseData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceRecommendationBaseData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceRecommendationBaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

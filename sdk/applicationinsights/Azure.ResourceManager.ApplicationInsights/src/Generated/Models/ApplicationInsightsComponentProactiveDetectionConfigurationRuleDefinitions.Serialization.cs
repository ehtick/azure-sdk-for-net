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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("DisplayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("Description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(HelpUri))
            {
                writer.WritePropertyName("HelpUrl"u8);
                writer.WriteStringValue(HelpUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("IsHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (Optional.IsDefined(IsEnabledByDefault))
            {
                writer.WritePropertyName("IsEnabledByDefault"u8);
                writer.WriteBooleanValue(IsEnabledByDefault.Value);
            }
            if (Optional.IsDefined(IsInPreview))
            {
                writer.WritePropertyName("IsInPreview"u8);
                writer.WriteBooleanValue(IsInPreview.Value);
            }
            if (Optional.IsDefined(IsEmailNotificationsSupported))
            {
                writer.WritePropertyName("SupportsEmailNotifications"u8);
                writer.WriteBooleanValue(IsEmailNotificationsSupported.Value);
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

        ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions IJsonModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions DeserializeApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string displayName = default;
            string description = default;
            Uri helpUrl = default;
            bool? isHidden = default;
            bool? isEnabledByDefault = default;
            bool? isInPreview = default;
            bool? supportsEmailNotifications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DisplayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("HelpUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    helpUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("IsHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsEnabledByDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabledByDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsInPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SupportsEmailNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportsEmailNotifications = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(
                name,
                displayName,
                description,
                helpUrl,
                isHidden,
                isEnabledByDefault,
                isInPreview,
                supportsEmailNotifications,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  Name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  DisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  DisplayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  Description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HelpUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  HelpUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HelpUri))
                {
                    builder.Append("  HelpUrl: ");
                    builder.AppendLine($"'{HelpUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsHidden), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  IsHidden: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsHidden))
                {
                    builder.Append("  IsHidden: ");
                    var boolValue = IsHidden.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabledByDefault), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  IsEnabledByDefault: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabledByDefault))
                {
                    builder.Append("  IsEnabledByDefault: ");
                    var boolValue = IsEnabledByDefault.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsInPreview), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  IsInPreview: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsInPreview))
                {
                    builder.Append("  IsInPreview: ");
                    var boolValue = IsInPreview.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEmailNotificationsSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  SupportsEmailNotifications: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEmailNotificationsSupported))
                {
                    builder.Append("  SupportsEmailNotifications: ");
                    var boolValue = IsEmailNotificationsSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApplicationInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

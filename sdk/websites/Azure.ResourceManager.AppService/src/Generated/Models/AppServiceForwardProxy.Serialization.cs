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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceForwardProxy : IUtf8JsonSerializable, IJsonModel<AppServiceForwardProxy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceForwardProxy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppServiceForwardProxy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceForwardProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceForwardProxy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Convention))
            {
                writer.WritePropertyName("convention"u8);
                writer.WriteStringValue(Convention.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomHostHeaderName))
            {
                writer.WritePropertyName("customHostHeaderName"u8);
                writer.WriteStringValue(CustomHostHeaderName);
            }
            if (Optional.IsDefined(CustomProtoHeaderName))
            {
                writer.WritePropertyName("customProtoHeaderName"u8);
                writer.WriteStringValue(CustomProtoHeaderName);
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

        AppServiceForwardProxy IJsonModel<AppServiceForwardProxy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceForwardProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceForwardProxy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceForwardProxy(document.RootElement, options);
        }

        internal static AppServiceForwardProxy DeserializeAppServiceForwardProxy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ForwardProxyConvention? convention = default;
            string customHostHeaderName = default;
            string customProtoHeaderName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("convention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    convention = property.Value.GetString().ToForwardProxyConvention();
                    continue;
                }
                if (property.NameEquals("customHostHeaderName"u8))
                {
                    customHostHeaderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customProtoHeaderName"u8))
                {
                    customProtoHeaderName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppServiceForwardProxy(convention, customHostHeaderName, customProtoHeaderName, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Convention), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  convention: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Convention))
                {
                    builder.Append("  convention: ");
                    builder.AppendLine($"'{Convention.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomHostHeaderName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customHostHeaderName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomHostHeaderName))
                {
                    builder.Append("  customHostHeaderName: ");
                    if (CustomHostHeaderName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CustomHostHeaderName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CustomHostHeaderName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomProtoHeaderName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customProtoHeaderName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomProtoHeaderName))
                {
                    builder.Append("  customProtoHeaderName: ");
                    if (CustomProtoHeaderName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CustomProtoHeaderName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CustomProtoHeaderName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppServiceForwardProxy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceForwardProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceForwardProxy)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceForwardProxy IPersistableModel<AppServiceForwardProxy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceForwardProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppServiceForwardProxy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceForwardProxy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceForwardProxy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

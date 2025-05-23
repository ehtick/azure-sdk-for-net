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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsClientInfo : IUtf8JsonSerializable, IJsonModel<SecurityInsightsClientInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsClientInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsClientInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsClientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsClientInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            if (Optional.IsDefined(UserPrincipalName))
            {
                writer.WritePropertyName("userPrincipalName"u8);
                writer.WriteStringValue(UserPrincipalName);
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

        SecurityInsightsClientInfo IJsonModel<SecurityInsightsClientInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsClientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsClientInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsClientInfo(document.RootElement, options);
        }

        internal static SecurityInsightsClientInfo DeserializeSecurityInsightsClientInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string email = default;
            string name = default;
            Guid? objectId = default;
            string userPrincipalName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("userPrincipalName"u8))
                {
                    userPrincipalName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityInsightsClientInfo(email, name, objectId, userPrincipalName, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Email), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  email: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Email))
                {
                    builder.Append("  email: ");
                    if (Email.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Email}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Email}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  objectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ObjectId))
                {
                    builder.Append("  objectId: ");
                    builder.AppendLine($"'{ObjectId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserPrincipalName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userPrincipalName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserPrincipalName))
                {
                    builder.Append("  userPrincipalName: ");
                    if (UserPrincipalName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserPrincipalName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserPrincipalName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsClientInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsClientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsClientInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsClientInfo IPersistableModel<SecurityInsightsClientInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsClientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityInsightsClientInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsClientInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsClientInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomEntityAlias : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(CaseSensitive))
            {
                if (CaseSensitive != null)
                {
                    writer.WritePropertyName("caseSensitive"u8);
                    writer.WriteBooleanValue(CaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("caseSensitive");
                }
            }
            if (Optional.IsDefined(AccentSensitive))
            {
                if (AccentSensitive != null)
                {
                    writer.WritePropertyName("accentSensitive"u8);
                    writer.WriteBooleanValue(AccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("accentSensitive");
                }
            }
            if (Optional.IsDefined(FuzzyEditDistance))
            {
                if (FuzzyEditDistance != null)
                {
                    writer.WritePropertyName("fuzzyEditDistance"u8);
                    writer.WriteNumberValue(FuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("fuzzyEditDistance");
                }
            }
            writer.WriteEndObject();
        }

        internal static CustomEntityAlias DeserializeCustomEntityAlias(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            bool? caseSensitive = default;
            bool? accentSensitive = default;
            int? fuzzyEditDistance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        caseSensitive = null;
                        continue;
                    }
                    caseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("accentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accentSensitive = null;
                        continue;
                    }
                    accentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fuzzyEditDistance = null;
                        continue;
                    }
                    fuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
            }
            return new CustomEntityAlias(text, caseSensitive, accentSensitive, fuzzyEditDistance);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CustomEntityAlias FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCustomEntityAlias(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

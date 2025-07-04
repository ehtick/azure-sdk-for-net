// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace BasicTypeSpec
{
    /// <summary> The ListWithStringNextLinkResponse. </summary>
    internal partial class ListWithStringNextLinkResponse : IJsonModel<ListWithStringNextLinkResponse>
    {
        /// <summary> Initializes a new instance of <see cref="ListWithStringNextLinkResponse"/> for deserialization. </summary>
        internal ListWithStringNextLinkResponse()
        {
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<ListWithStringNextLinkResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ListWithStringNextLinkResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListWithStringNextLinkResponse)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("things"u8);
            writer.WriteStartArray();
            foreach (ThingModel item in Things)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Next))
            {
                writer.WritePropertyName("next"u8);
                writer.WriteStringValue(Next);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        ListWithStringNextLinkResponse IJsonModel<ListWithStringNextLinkResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ListWithStringNextLinkResponse JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ListWithStringNextLinkResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListWithStringNextLinkResponse)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListWithStringNextLinkResponse(document.RootElement, options);
        }

        /// <param name="element"> The JSON element to deserialize. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        internal static ListWithStringNextLinkResponse DeserializeListWithStringNextLinkResponse(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ThingModel> things = default;
            string next = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("things"u8))
                {
                    List<ThingModel> array = new List<ThingModel>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ThingModel.DeserializeThingModel(item, options));
                    }
                    things = array;
                    continue;
                }
                if (prop.NameEquals("next"u8))
                {
                    next = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ListWithStringNextLinkResponse(things, next, additionalBinaryDataProperties);
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<ListWithStringNextLinkResponse>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ListWithStringNextLinkResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, BasicTypeSpecContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ListWithStringNextLinkResponse)} does not support writing '{options.Format}' format.");
            }
        }

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        ListWithStringNextLinkResponse IPersistableModel<ListWithStringNextLinkResponse>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ListWithStringNextLinkResponse PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ListWithStringNextLinkResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeListWithStringNextLinkResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ListWithStringNextLinkResponse)} does not support reading '{options.Format}' format.");
            }
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<ListWithStringNextLinkResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="result"> The <see cref="Response"/> to deserialize the <see cref="ListWithStringNextLinkResponse"/> from. </param>
        public static explicit operator ListWithStringNextLinkResponse(Response result)
        {
            using Response response = result;
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeListWithStringNextLinkResponse(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}

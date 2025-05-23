// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties
{
    public partial class ExtendsUnknownAdditionalProperties : IJsonModel<ExtendsUnknownAdditionalProperties>
    {
        internal ExtendsUnknownAdditionalProperties() => throw null;

        void IJsonModel<ExtendsUnknownAdditionalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        ExtendsUnknownAdditionalProperties IJsonModel<ExtendsUnknownAdditionalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual ExtendsUnknownAdditionalProperties JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<ExtendsUnknownAdditionalProperties>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        ExtendsUnknownAdditionalProperties IPersistableModel<ExtendsUnknownAdditionalProperties>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual ExtendsUnknownAdditionalProperties PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<ExtendsUnknownAdditionalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="extendsUnknownAdditionalProperties"> The <see cref="ExtendsUnknownAdditionalProperties"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(ExtendsUnknownAdditionalProperties extendsUnknownAdditionalProperties) => throw null;

        public static explicit operator ExtendsUnknownAdditionalProperties(Response result) => throw null;
    }
}

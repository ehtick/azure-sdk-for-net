// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Specs_.Azure.ClientGenerator.Core.FlattenProperty
{
    public partial class ChildModel : IJsonModel<ChildModel>
    {
        internal ChildModel() => throw null;

        void IJsonModel<ChildModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        ChildModel IJsonModel<ChildModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual ChildModel JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<ChildModel>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        ChildModel IPersistableModel<ChildModel>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual ChildModel PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<ChildModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;
    }
}

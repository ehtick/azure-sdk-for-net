// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceEncryptionProtectorResource : IJsonModel<ManagedInstanceEncryptionProtectorData>
    {
        private static ManagedInstanceEncryptionProtectorData s_dataDeserializationInstance;
        private static ManagedInstanceEncryptionProtectorData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ManagedInstanceEncryptionProtectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedInstanceEncryptionProtectorData>)Data).Write(writer, options);

        ManagedInstanceEncryptionProtectorData IJsonModel<ManagedInstanceEncryptionProtectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedInstanceEncryptionProtectorData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedInstanceEncryptionProtectorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ManagedInstanceEncryptionProtectorData>(Data, options, AzureResourceManagerSqlContext.Default);

        ManagedInstanceEncryptionProtectorData IPersistableModel<ManagedInstanceEncryptionProtectorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedInstanceEncryptionProtectorData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<ManagedInstanceEncryptionProtectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedInstanceEncryptionProtectorData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

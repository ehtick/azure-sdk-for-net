// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class RestorableDroppedDatabaseResource : IJsonModel<RestorableDroppedDatabaseData>
    {
        private static RestorableDroppedDatabaseData s_dataDeserializationInstance;
        private static RestorableDroppedDatabaseData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<RestorableDroppedDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RestorableDroppedDatabaseData>)Data).Write(writer, options);

        RestorableDroppedDatabaseData IJsonModel<RestorableDroppedDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RestorableDroppedDatabaseData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<RestorableDroppedDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RestorableDroppedDatabaseData>(Data, options, AzureResourceManagerSqlContext.Default);

        RestorableDroppedDatabaseData IPersistableModel<RestorableDroppedDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RestorableDroppedDatabaseData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<RestorableDroppedDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RestorableDroppedDatabaseData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareDataSetMappingResource : IJsonModel<ShareDataSetMappingData>
    {
        private static ShareDataSetMappingData s_dataDeserializationInstance;
        private static ShareDataSetMappingData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ShareDataSetMappingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ShareDataSetMappingData>)Data).Write(writer, options);

        ShareDataSetMappingData IJsonModel<ShareDataSetMappingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ShareDataSetMappingData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ShareDataSetMappingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ShareDataSetMappingData>(Data, options, AzureResourceManagerDataShareContext.Default);

        ShareDataSetMappingData IPersistableModel<ShareDataSetMappingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ShareDataSetMappingData>(data, options, AzureResourceManagerDataShareContext.Default);

        string IPersistableModel<ShareDataSetMappingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ShareDataSetMappingData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

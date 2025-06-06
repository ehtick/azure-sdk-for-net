// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridNetwork
{
    public partial class ConfigurationGroupValueResource : IJsonModel<ConfigurationGroupValueData>
    {
        private static ConfigurationGroupValueData s_dataDeserializationInstance;
        private static ConfigurationGroupValueData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ConfigurationGroupValueData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ConfigurationGroupValueData>)Data).Write(writer, options);

        ConfigurationGroupValueData IJsonModel<ConfigurationGroupValueData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ConfigurationGroupValueData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ConfigurationGroupValueData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ConfigurationGroupValueData>(Data, options, AzureResourceManagerHybridNetworkContext.Default);

        ConfigurationGroupValueData IPersistableModel<ConfigurationGroupValueData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ConfigurationGroupValueData>(data, options, AzureResourceManagerHybridNetworkContext.Default);

        string IPersistableModel<ConfigurationGroupValueData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ConfigurationGroupValueData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

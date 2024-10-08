// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Pipeline Info. </summary>
    public partial class PipelineGroupServicePipeline
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PipelineGroupServicePipeline"/>. </summary>
        /// <param name="name"> Name of the pipeline. </param>
        /// <param name="pipelineType"> The type of pipeline. </param>
        /// <param name="receivers"> Reference to receivers configured for the pipeline. </param>
        /// <param name="exporters"> Reference to exporters configured for the pipeline. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="receivers"/> or <paramref name="exporters"/> is null. </exception>
        public PipelineGroupServicePipeline(string name, PipelineGroupServicePipelineType pipelineType, IEnumerable<string> receivers, IEnumerable<string> exporters)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(receivers, nameof(receivers));
            Argument.AssertNotNull(exporters, nameof(exporters));

            Name = name;
            PipelineType = pipelineType;
            Receivers = receivers.ToList();
            Processors = new ChangeTrackingList<string>();
            Exporters = exporters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PipelineGroupServicePipeline"/>. </summary>
        /// <param name="name"> Name of the pipeline. </param>
        /// <param name="pipelineType"> The type of pipeline. </param>
        /// <param name="receivers"> Reference to receivers configured for the pipeline. </param>
        /// <param name="processors"> Reference to processors configured for the pipeline. </param>
        /// <param name="exporters"> Reference to exporters configured for the pipeline. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineGroupServicePipeline(string name, PipelineGroupServicePipelineType pipelineType, IList<string> receivers, IList<string> processors, IList<string> exporters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            PipelineType = pipelineType;
            Receivers = receivers;
            Processors = processors;
            Exporters = exporters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineGroupServicePipeline"/> for deserialization. </summary>
        internal PipelineGroupServicePipeline()
        {
        }

        /// <summary> Name of the pipeline. </summary>
        public string Name { get; set; }
        /// <summary> The type of pipeline. </summary>
        public PipelineGroupServicePipelineType PipelineType { get; set; }
        /// <summary> Reference to receivers configured for the pipeline. </summary>
        public IList<string> Receivers { get; }
        /// <summary> Reference to processors configured for the pipeline. </summary>
        public IList<string> Processors { get; }
        /// <summary> Reference to exporters configured for the pipeline. </summary>
        public IList<string> Exporters { get; }
    }
}

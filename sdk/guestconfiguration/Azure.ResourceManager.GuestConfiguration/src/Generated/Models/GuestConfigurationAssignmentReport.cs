// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Report for the guest configuration assignment. Report contains information such as compliance status, reason, and more. </summary>
    public partial class GuestConfigurationAssignmentReport
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

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReport"/>. </summary>
        internal GuestConfigurationAssignmentReport()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReport"/>. </summary>
        /// <param name="id"> ARM resource id of the report for the guest configuration assignment. </param>
        /// <param name="name"> GUID that identifies the guest configuration assignment report under a subscription, resource group. </param>
        /// <param name="properties"> Properties of the guest configuration report. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationAssignmentReport(ResourceIdentifier id, string name, GuestConfigurationAssignmentReportProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ARM resource id of the report for the guest configuration assignment. </summary>
        [WirePath("id")]
        public ResourceIdentifier Id { get; }
        /// <summary> GUID that identifies the guest configuration assignment report under a subscription, resource group. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Properties of the guest configuration report. </summary>
        [WirePath("properties")]
        public GuestConfigurationAssignmentReportProperties Properties { get; }
    }
}

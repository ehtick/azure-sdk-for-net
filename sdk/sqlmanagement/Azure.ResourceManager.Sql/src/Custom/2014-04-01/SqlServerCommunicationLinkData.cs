﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerCommunicationLink data model.
    /// Server communication link.
    /// </summary>
    [Obsolete("This class is deprecated and will be removed in a future release.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class SqlServerCommunicationLinkData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlServerCommunicationLinkData"/>. </summary>
        public SqlServerCommunicationLinkData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerCommunicationLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Communication link location. </param>
        /// <param name="kind"> Communication link kind.  This property is used for Azure Portal metadata. </param>
        /// <param name="state"> The state. </param>
        /// <param name="partnerServer"> The name of the partner server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerCommunicationLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, string state, string partnerServer, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            State = state;
            PartnerServer = partnerServer;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Communication link location. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; }
        /// <summary> Communication link kind.  This property is used for Azure Portal metadata. </summary>
        [WirePath("kind")]
        public string Kind { get; }
        /// <summary> The state. </summary>
        [WirePath("properties.state")]
        public string State { get; }
        /// <summary> The name of the partner server. </summary>
        [WirePath("properties.partnerServer")]
        public string PartnerServer { get; set; }
    }
}

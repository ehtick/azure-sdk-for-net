// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary>
    /// Properties of a time series database connection resource.
    /// Please note <see cref="TimeSeriesDatabaseConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataExplorerConnectionProperties"/>.
    /// </summary>
    public abstract partial class TimeSeriesDatabaseConnectionProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesDatabaseConnectionProperties"/>. </summary>
        protected TimeSeriesDatabaseConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesDatabaseConnectionProperties"/>. </summary>
        /// <param name="connectionType"> The type of time series connection resource. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="identity"> Managed identity properties for the time series database connection resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TimeSeriesDatabaseConnectionProperties(ConnectionType connectionType, TimeSeriesDatabaseConnectionState? provisioningState, DigitalTwinsManagedIdentityReference identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionType = connectionType;
            ProvisioningState = provisioningState;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of time series connection resource. </summary>
        internal ConnectionType ConnectionType { get; set; }
        /// <summary> The provisioning state. </summary>
        public TimeSeriesDatabaseConnectionState? ProvisioningState { get; }
        /// <summary> Managed identity properties for the time series database connection resource. </summary>
        public DigitalTwinsManagedIdentityReference Identity { get; set; }
    }
}

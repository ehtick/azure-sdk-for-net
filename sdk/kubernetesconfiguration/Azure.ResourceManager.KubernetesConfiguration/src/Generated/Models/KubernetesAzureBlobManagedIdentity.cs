// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to authenticate using a Managed Identity. </summary>
    internal partial class KubernetesAzureBlobManagedIdentity
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

        /// <summary> Initializes a new instance of <see cref="KubernetesAzureBlobManagedIdentity"/>. </summary>
        public KubernetesAzureBlobManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesAzureBlobManagedIdentity"/>. </summary>
        /// <param name="clientId"> The client Id for authenticating a Managed Identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesAzureBlobManagedIdentity(Guid? clientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClientId = clientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The client Id for authenticating a Managed Identity. </summary>
        [WirePath("clientId")]
        public Guid? ClientId { get; set; }
    }
}

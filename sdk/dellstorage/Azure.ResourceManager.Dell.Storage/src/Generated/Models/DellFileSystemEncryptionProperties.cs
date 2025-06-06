// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dell.Storage.Models
{
    /// <summary> EncryptionProperties of Dell FileSystem resource. </summary>
    public partial class DellFileSystemEncryptionProperties
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

        /// <summary> Initializes a new instance of <see cref="DellFileSystemEncryptionProperties"/>. </summary>
        /// <param name="encryptionType"> Encryption Type - MMK/CMK. </param>
        public DellFileSystemEncryptionProperties(DellFileSystemEncryptionType encryptionType)
        {
            EncryptionType = encryptionType;
        }

        /// <summary> Initializes a new instance of <see cref="DellFileSystemEncryptionProperties"/>. </summary>
        /// <param name="encryptionType"> Encryption Type - MMK/CMK. </param>
        /// <param name="keyUri"> Versioned Encryption Key Url - Only when user opts for CMK and hence optional. </param>
        /// <param name="encryptionIdentityProperties"> Identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault - Only when user opts for CMK and hence optional. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DellFileSystemEncryptionProperties(DellFileSystemEncryptionType encryptionType, string keyUri, DellFileSystemEncryptionIdentityProperties encryptionIdentityProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EncryptionType = encryptionType;
            KeyUri = keyUri;
            EncryptionIdentityProperties = encryptionIdentityProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DellFileSystemEncryptionProperties"/> for deserialization. </summary>
        internal DellFileSystemEncryptionProperties()
        {
        }

        /// <summary> Encryption Type - MMK/CMK. </summary>
        public DellFileSystemEncryptionType EncryptionType { get; set; }
        /// <summary> Versioned Encryption Key Url - Only when user opts for CMK and hence optional. </summary>
        public string KeyUri { get; set; }
        /// <summary> Identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault - Only when user opts for CMK and hence optional. </summary>
        public DellFileSystemEncryptionIdentityProperties EncryptionIdentityProperties { get; set; }
    }
}

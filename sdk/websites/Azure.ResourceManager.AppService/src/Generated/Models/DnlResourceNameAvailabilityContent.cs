// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The DnlResourceNameAvailabilityContent. </summary>
    public partial class DnlResourceNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="DnlResourceNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DnlResourceNameAvailabilityContent(string name, CheckNameResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="DnlResourceNameAvailabilityContent"/>. </summary>
        /// <param name="resourceGroupName"> Resource group name. </param>
        /// <param name="autoGeneratedDomainNameLabelScope">
        /// Indicates the endpoint name reuse scope.The default value is TenantReuse.
        /// Supported values are TenantReuse, SubscriptionReuse, ResourceGroupReuse, NoReuse
        /// </param>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnlResourceNameAvailabilityContent(string resourceGroupName, string autoGeneratedDomainNameLabelScope, string name, CheckNameResourceType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceGroupName = resourceGroupName;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DnlResourceNameAvailabilityContent"/> for deserialization. </summary>
        internal DnlResourceNameAvailabilityContent()
        {
        }

        /// <summary> Resource group name. </summary>
        [WirePath("resourceGroupName")]
        public string ResourceGroupName { get; set; }
        /// <summary>
        /// Indicates the endpoint name reuse scope.The default value is TenantReuse.
        /// Supported values are TenantReuse, SubscriptionReuse, ResourceGroupReuse, NoReuse
        /// </summary>
        [WirePath("autoGeneratedDomainNameLabelScope")]
        public string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary> Resource name to verify. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        [WirePath("type")]
        public CheckNameResourceType ResourceType { get; }
    }
}

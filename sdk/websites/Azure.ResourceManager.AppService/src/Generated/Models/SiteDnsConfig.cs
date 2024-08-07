// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The SiteDnsConfig. </summary>
    public partial class SiteDnsConfig
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

        /// <summary> Initializes a new instance of <see cref="SiteDnsConfig"/>. </summary>
        public SiteDnsConfig()
        {
            DnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteDnsConfig"/>. </summary>
        /// <param name="dnsServers"> List of custom DNS servers to be used by an app for lookups. Maximum 5 dns servers can be set. </param>
        /// <param name="dnsAltServer"> Alternate DNS server to be used by apps. This property replicates the WEBSITE_DNS_ALT_SERVER app setting. </param>
        /// <param name="dnsRetryAttemptTimeout"> Timeout for a single dns lookup in seconds. Allowed range: 1-30. Default is 3. </param>
        /// <param name="dnsRetryAttemptCount"> Total number of retries for dns lookup. Allowed range: 1-5. Default is 3. </param>
        /// <param name="dnsMaxCacheTimeout"> Custom time for DNS to be cached in seconds. Allowed range: 0-60. Default is 30 seconds. 0 means caching disabled. </param>
        /// <param name="dnsLegacySortOrder"> Indicates that sites using Virtual network custom DNS servers are still sorting the list of DNS servers. Read-Only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteDnsConfig(IList<string> dnsServers, string dnsAltServer, int? dnsRetryAttemptTimeout, int? dnsRetryAttemptCount, int? dnsMaxCacheTimeout, bool? dnsLegacySortOrder, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DnsServers = dnsServers;
            DnsAltServer = dnsAltServer;
            DnsRetryAttemptTimeout = dnsRetryAttemptTimeout;
            DnsRetryAttemptCount = dnsRetryAttemptCount;
            DnsMaxCacheTimeout = dnsMaxCacheTimeout;
            DnsLegacySortOrder = dnsLegacySortOrder;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of custom DNS servers to be used by an app for lookups. Maximum 5 dns servers can be set. </summary>
        [WirePath("dnsServers")]
        public IList<string> DnsServers { get; }
        /// <summary> Alternate DNS server to be used by apps. This property replicates the WEBSITE_DNS_ALT_SERVER app setting. </summary>
        [WirePath("dnsAltServer")]
        public string DnsAltServer { get; set; }
        /// <summary> Timeout for a single dns lookup in seconds. Allowed range: 1-30. Default is 3. </summary>
        [WirePath("dnsRetryAttemptTimeout")]
        public int? DnsRetryAttemptTimeout { get; set; }
        /// <summary> Total number of retries for dns lookup. Allowed range: 1-5. Default is 3. </summary>
        [WirePath("dnsRetryAttemptCount")]
        public int? DnsRetryAttemptCount { get; set; }
        /// <summary> Custom time for DNS to be cached in seconds. Allowed range: 0-60. Default is 30 seconds. 0 means caching disabled. </summary>
        [WirePath("dnsMaxCacheTimeout")]
        public int? DnsMaxCacheTimeout { get; set; }
        /// <summary> Indicates that sites using Virtual network custom DNS servers are still sorting the list of DNS servers. Read-Only. </summary>
        [WirePath("dnsLegacySortOrder")]
        public bool? DnsLegacySortOrder { get; }
    }
}

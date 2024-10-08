// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The insight table query. </summary>
    public partial class InsightQueryItemPropertiesTableQuery
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

        /// <summary> Initializes a new instance of <see cref="InsightQueryItemPropertiesTableQuery"/>. </summary>
        internal InsightQueryItemPropertiesTableQuery()
        {
            ColumnsDefinitions = new ChangeTrackingList<InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem>();
            QueriesDefinitions = new ChangeTrackingList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="InsightQueryItemPropertiesTableQuery"/>. </summary>
        /// <param name="columnsDefinitions"> List of insight column definitions. </param>
        /// <param name="queriesDefinitions"> List of insight queries definitions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InsightQueryItemPropertiesTableQuery(IReadOnlyList<InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem> columnsDefinitions, IReadOnlyList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem> queriesDefinitions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ColumnsDefinitions = columnsDefinitions;
            QueriesDefinitions = queriesDefinitions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of insight column definitions. </summary>
        [WirePath("columnsDefinitions")]
        public IReadOnlyList<InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem> ColumnsDefinitions { get; }
        /// <summary> List of insight queries definitions. </summary>
        [WirePath("queriesDefinitions")]
        public IReadOnlyList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem> QueriesDefinitions { get; }
    }
}

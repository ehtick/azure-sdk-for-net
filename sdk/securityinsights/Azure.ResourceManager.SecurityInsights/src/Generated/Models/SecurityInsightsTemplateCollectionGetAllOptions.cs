// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The SecurityInsightsTemplateCollectionGetAllOptions. </summary>
    public partial class SecurityInsightsTemplateCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsTemplateCollectionGetAllOptions"/>. </summary>
        public SecurityInsightsTemplateCollectionGetAllOptions()
        {
        }

        /// <summary> Filters the results, based on a Boolean condition. Optional. </summary>
        [WirePath("filter")]
        public string Filter { get; set; }
        /// <summary> Sorts the results. Optional. </summary>
        [WirePath("orderBy")]
        public string OrderBy { get; set; }
        /// <summary> Expands the object with optional fiends that are not included by default. Optional. </summary>
        [WirePath("expand")]
        public string Expand { get; set; }
        /// <summary> Searches for a substring in the response. Optional. </summary>
        [WirePath("search")]
        public string Search { get; set; }
        /// <summary> Instructs the server to return only object count without actual body. Optional. </summary>
        [WirePath("count")]
        public bool? Count { get; set; }
        /// <summary> Returns only the first n results. Optional. </summary>
        [WirePath("top")]
        public int? Top { get; set; }
        /// <summary> Used to skip n elements in the OData query (offset). Returns a nextLink to the next page of results if there are any left. </summary>
        [WirePath("skip")]
        public int? Skip { get; set; }
        /// <summary> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </summary>
        [WirePath("skipToken")]
        public string SkipToken { get; set; }
    }
}

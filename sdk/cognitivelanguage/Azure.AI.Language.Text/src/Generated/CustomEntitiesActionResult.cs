// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the list of detected custom entities result for the documents along with detected language. </summary>
    public partial class CustomEntitiesActionResult
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

        /// <summary> Initializes a new instance of <see cref="CustomEntitiesActionResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="documents"> Enumeration of the document results with detected language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="projectName"/>, <paramref name="deploymentName"/> or <paramref name="documents"/> is null. </exception>
        internal CustomEntitiesActionResult(IEnumerable<DocumentError> errors, string projectName, string deploymentName, IEnumerable<EntityActionResult> documents)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(documents, nameof(documents));

            Errors = errors.ToList();
            ProjectName = projectName;
            DeploymentName = deploymentName;
            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntitiesActionResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="documents"> Enumeration of the document results with detected language. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomEntitiesActionResult(IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string projectName, string deploymentName, IReadOnlyList<EntityActionResult> documents, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Errors = errors;
            Statistics = statistics;
            ProjectName = projectName;
            DeploymentName = deploymentName;
            Documents = documents;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntitiesActionResult"/> for deserialization. </summary>
        internal CustomEntitiesActionResult()
        {
        }

        /// <summary> Errors by document id. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> This field indicates the project name for the model. </summary>
        public string ProjectName { get; }
        /// <summary> This field indicates the deployment name for the model. </summary>
        public string DeploymentName { get; }
        /// <summary> Enumeration of the document results with detected language. </summary>
        public IReadOnlyList<EntityActionResult> Documents { get; }
    }
}

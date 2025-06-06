// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Client options for <see cref="EventGridSenderClient"/>. </summary>
    public partial class EventGridSenderClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2024_06_01;

        /// <summary> Initializes a new instance of EventGridSenderClientOptions. </summary>
        /// <param name="version"> The service version. </param>
        public EventGridSenderClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_11_01 => "2023-11-01",
                ServiceVersion.V2024_06_01 => "2024-06-01",
                _ => throw new NotSupportedException()
            };
        }

        /// <summary> Gets the Version. </summary>
        internal string Version { get; }

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> V2023_11_01. </summary>
            V2023_11_01 = 1,
            /// <summary> V2024_06_01. </summary>
            V2024_06_01 = 2
        }
    }
}

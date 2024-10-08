// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Type of managed service identity (where both SystemAssigned and
/// UserAssigned types are allowed).
/// </summary>
public enum ManagedServiceIdentityType
{
    /// <summary>
    /// None.
    /// </summary>
    None,

    /// <summary>
    /// SystemAssigned.
    /// </summary>
    SystemAssigned,

    /// <summary>
    /// UserAssigned.
    /// </summary>
    UserAssigned,

    /// <summary>
    /// SystemAssigned, UserAssigned.
    /// </summary>
    [DataMember(Name = "SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
}

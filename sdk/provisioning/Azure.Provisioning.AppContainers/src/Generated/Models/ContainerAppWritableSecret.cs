// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Secret definition.
/// </summary>
public partial class ContainerAppWritableSecret : ProvisionableConstruct
{
    /// <summary>
    /// Secret Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Secret Value.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Resource ID of a managed identity to authenticate with Azure Key Vault,
    /// or System to use a system-assigned identity.
    /// </summary>
    public BicepValue<string> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<string> _identity;

    /// <summary>
    /// Azure Key Vault URL pointing to the secret referenced by the container
    /// app.
    /// </summary>
    public BicepValue<Uri> KeyVaultUri { get => _keyVaultUri; set => _keyVaultUri.Assign(value); }
    private readonly BicepValue<Uri> _keyVaultUri;

    /// <summary>
    /// Creates a new ContainerAppWritableSecret.
    /// </summary>
    public ContainerAppWritableSecret()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
        _identity = BicepValue<string>.DefineProperty(this, "Identity", ["identity"]);
        _keyVaultUri = BicepValue<Uri>.DefineProperty(this, "KeyVaultUri", ["keyVaultUrl"]);
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The key vault properties.
/// </summary>
public partial class OperationalInsightsKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// The Key Vault uri which holds they key associated with the Log
    /// Analytics cluster.
    /// </summary>
    public BicepValue<Uri> KeyVaultUri 
    {
        get { Initialize(); return _keyVaultUri!; }
        set { Initialize(); _keyVaultUri!.Assign(value); }
    }
    private BicepValue<Uri>? _keyVaultUri;

    /// <summary>
    /// The name of the key associated with the Log Analytics cluster.
    /// </summary>
    public BicepValue<string> KeyName 
    {
        get { Initialize(); return _keyName!; }
        set { Initialize(); _keyName!.Assign(value); }
    }
    private BicepValue<string>? _keyName;

    /// <summary>
    /// The version of the key associated with the Log Analytics cluster.
    /// </summary>
    public BicepValue<string> KeyVersion 
    {
        get { Initialize(); return _keyVersion!; }
        set { Initialize(); _keyVersion!.Assign(value); }
    }
    private BicepValue<string>? _keyVersion;

    /// <summary>
    /// Selected key minimum required size.
    /// </summary>
    public BicepValue<int> KeyRsaSize 
    {
        get { Initialize(); return _keyRsaSize!; }
        set { Initialize(); _keyRsaSize!.Assign(value); }
    }
    private BicepValue<int>? _keyRsaSize;

    /// <summary>
    /// Creates a new OperationalInsightsKeyVaultProperties.
    /// </summary>
    public OperationalInsightsKeyVaultProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// OperationalInsightsKeyVaultProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _keyVaultUri = DefineProperty<Uri>("KeyVaultUri", ["keyVaultUri"]);
        _keyName = DefineProperty<string>("KeyName", ["keyName"]);
        _keyVersion = DefineProperty<string>("KeyVersion", ["keyVersion"]);
        _keyRsaSize = DefineProperty<int>("KeyRsaSize", ["keyRsaSize"]);
    }
}

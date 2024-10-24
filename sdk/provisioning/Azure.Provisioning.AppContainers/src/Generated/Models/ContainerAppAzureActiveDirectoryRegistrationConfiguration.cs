// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the Azure Active Directory app registration.
/// </summary>
public partial class ContainerAppAzureActiveDirectoryRegistrationConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues
    /// access tokens for this application.             When using Azure
    /// Active Directory, this value is the URI of the directory tenant, e.g.
    /// https://login.microsoftonline.com/v2.0/{tenant-guid}/.
    /// This URI is a case-sensitive identifier for the token
    /// issuer.             More information on OpenID Connect Discovery:
    /// http://openid.net/specs/openid-connect-discovery-1_0.html
    /// </summary>
    public BicepValue<string> OpenIdIssuer { get => _openIdIssuer; set => _openIdIssuer.Assign(value); }
    private readonly BicepValue<string> _openIdIssuer;

    /// <summary>
    /// The Client ID of this relying party application, known as the
    /// client_id.             This setting is required for enabling OpenID
    /// Connection authentication with Azure Active Directory or
    /// other 3rd party OpenID Connect providers.             More
    /// information on OpenID Connect:
    /// http://openid.net/specs/openid-connect-core-1_0.html
    /// </summary>
    public BicepValue<string> ClientId { get => _clientId; set => _clientId.Assign(value); }
    private readonly BicepValue<string> _clientId;

    /// <summary>
    /// The app setting name that contains the client secret of the relying
    /// party application.
    /// </summary>
    public BicepValue<string> ClientSecretSettingName { get => _clientSecretSettingName; set => _clientSecretSettingName.Assign(value); }
    private readonly BicepValue<string> _clientSecretSettingName;

    /// <summary>
    /// An alternative to the client secret, that is the thumbprint of a
    /// certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateThumbprint { get => _clientSecretCertificateThumbprint; set => _clientSecretCertificateThumbprint.Assign(value); }
    private readonly BicepValue<string> _clientSecretCertificateThumbprint;

    /// <summary>
    /// An alternative to the client secret thumbprint, that is the subject
    /// alternative name of a certificate used for signing purposes. This
    /// property acts as             a replacement for the Client Secret
    /// Certificate Thumbprint. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateSubjectAlternativeName { get => _clientSecretCertificateSubjectAlternativeName; set => _clientSecretCertificateSubjectAlternativeName.Assign(value); }
    private readonly BicepValue<string> _clientSecretCertificateSubjectAlternativeName;

    /// <summary>
    /// An alternative to the client secret thumbprint, that is the issuer of a
    /// certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate
    /// Thumbprint. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateIssuer { get => _clientSecretCertificateIssuer; set => _clientSecretCertificateIssuer.Assign(value); }
    private readonly BicepValue<string> _clientSecretCertificateIssuer;

    /// <summary>
    /// Creates a new ContainerAppAzureActiveDirectoryRegistrationConfiguration.
    /// </summary>
    public ContainerAppAzureActiveDirectoryRegistrationConfiguration()
    {
        _openIdIssuer = BicepValue<string>.DefineProperty(this, "OpenIdIssuer", ["openIdIssuer"]);
        _clientId = BicepValue<string>.DefineProperty(this, "ClientId", ["clientId"]);
        _clientSecretSettingName = BicepValue<string>.DefineProperty(this, "ClientSecretSettingName", ["clientSecretSettingName"]);
        _clientSecretCertificateThumbprint = BicepValue<string>.DefineProperty(this, "ClientSecretCertificateThumbprint", ["clientSecretCertificateThumbprint"]);
        _clientSecretCertificateSubjectAlternativeName = BicepValue<string>.DefineProperty(this, "ClientSecretCertificateSubjectAlternativeName", ["clientSecretCertificateSubjectAlternativeName"]);
        _clientSecretCertificateIssuer = BicepValue<string>.DefineProperty(this, "ClientSecretCertificateIssuer", ["clientSecretCertificateIssuer"]);
    }
}

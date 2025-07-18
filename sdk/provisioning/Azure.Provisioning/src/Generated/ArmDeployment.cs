// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ArmDeployment.
/// </summary>
public partial class ArmDeployment : ProvisionableResource
{
    /// <summary>
    /// The name of the deployment.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// the location of the deployment.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public ArmDeploymentPropertiesExtended Properties 
    {
        get { Initialize(); return _properties!; }
    }
    private ArmDeploymentPropertiesExtended? _properties;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Deployment tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Creates a new ArmDeployment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ArmDeployment resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmDeployment.</param>
    public ArmDeployment(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Resources/deployments", resourceVersion ?? "2023-07-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ArmDeployment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _properties = DefineModelProperty<ArmDeploymentPropertiesExtended>("Properties", ["properties"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"], isOutput: true);
    }

    /// <summary>
    /// Supported ArmDeployment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-03-01.
        /// </summary>
        public static readonly string V2019_03_01 = "2019-03-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-09-01.
        /// </summary>
        public static readonly string V2018_09_01 = "2018-09-01";

        /// <summary>
        /// 2018-08-01.
        /// </summary>
        public static readonly string V2018_08_01 = "2018-08-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-05-01.
        /// </summary>
        public static readonly string V2018_05_01 = "2018-05-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2018-01-01.
        /// </summary>
        public static readonly string V2018_01_01 = "2018-01-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2017-05-10.
        /// </summary>
        public static readonly string V2017_05_10 = "2017-05-10";

        /// <summary>
        /// 2017-05-01.
        /// </summary>
        public static readonly string V2017_05_01 = "2017-05-01";

        /// <summary>
        /// 2017-03-01.
        /// </summary>
        public static readonly string V2017_03_01 = "2017-03-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-07-01.
        /// </summary>
        public static readonly string V2016_07_01 = "2016-07-01";

        /// <summary>
        /// 2016-06-01.
        /// </summary>
        public static readonly string V2016_06_01 = "2016-06-01";

        /// <summary>
        /// 2016-02-01.
        /// </summary>
        public static readonly string V2016_02_01 = "2016-02-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing ArmDeployment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ArmDeployment resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmDeployment.</param>
    /// <returns>The existing ArmDeployment resource.</returns>
    public static ArmDeployment FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ArmDeployment resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 64, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}

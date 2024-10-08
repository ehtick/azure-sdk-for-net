// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The request for reservation patch. </summary>
    public partial class BillingReservationPatch
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

        /// <summary> Initializes a new instance of <see cref="BillingReservationPatch"/>. </summary>
        public BillingReservationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingReservationPatch"/>. </summary>
        /// <param name="sku"> The sku information associated to this reservation. </param>
        /// <param name="tags"> Tags for this reservation. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </param>
        /// <param name="instanceFlexibility"> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </param>
        /// <param name="displayName"> Display name of the reservation. </param>
        /// <param name="isRenewed"> Setting this to true will automatically purchase a new benefit on the expiration date time. </param>
        /// <param name="reviewOn"> This is the date-time when the Azure hybrid benefit needs to be reviewed. </param>
        /// <param name="purchaseProperties"> The request for reservation purchase. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingReservationPatch(ReservationSkuProperty sku, IDictionary<string, string> tags, BillingAppliedScopeType? appliedScopeType, ReservationAppliedScopeProperties appliedScopeProperties, InstanceFlexibility? instanceFlexibility, string displayName, bool? isRenewed, DateTimeOffset? reviewOn, ReservationPurchaseRequest purchaseProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Tags = tags;
            AppliedScopeType = appliedScopeType;
            AppliedScopeProperties = appliedScopeProperties;
            InstanceFlexibility = instanceFlexibility;
            DisplayName = displayName;
            IsRenewed = isRenewed;
            ReviewOn = reviewOn;
            PurchaseProperties = purchaseProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sku information associated to this reservation. </summary>
        internal ReservationSkuProperty Sku { get; set; }
        /// <summary> The name of the reservation sku. </summary>
        [WirePath("sku.name")]
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
        }

        /// <summary> Tags for this reservation. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> Type of the Applied Scope. </summary>
        [WirePath("properties.appliedScopeType")]
        public BillingAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </summary>
        [WirePath("properties.appliedScopeProperties")]
        public ReservationAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </summary>
        [WirePath("properties.instanceFlexibility")]
        public InstanceFlexibility? InstanceFlexibility { get; set; }
        /// <summary> Display name of the reservation. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        [WirePath("properties.renew")]
        public bool? IsRenewed { get; set; }
        /// <summary> This is the date-time when the Azure hybrid benefit needs to be reviewed. </summary>
        [WirePath("properties.reviewDateTime")]
        public DateTimeOffset? ReviewOn { get; set; }
        /// <summary> The request for reservation purchase. </summary>
        [WirePath("properties.purchaseProperties")]
        public ReservationPurchaseRequest PurchaseProperties { get; set; }
    }
}

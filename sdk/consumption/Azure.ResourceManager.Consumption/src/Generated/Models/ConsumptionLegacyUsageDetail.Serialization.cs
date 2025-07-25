// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionLegacyUsageDetail : IUtf8JsonSerializable, IJsonModel<ConsumptionLegacyUsageDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionLegacyUsageDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionLegacyUsageDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyUsageDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLegacyUsageDetail)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BillingAccountId))
            {
                writer.WritePropertyName("billingAccountId"u8);
                writer.WriteStringValue(BillingAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingAccountName))
            {
                writer.WritePropertyName("billingAccountName"u8);
                writer.WriteStringValue(BillingAccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingPeriodStartOn))
            {
                writer.WritePropertyName("billingPeriodStartDate"u8);
                writer.WriteStringValue(BillingPeriodStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(BillingPeriodEndOn))
            {
                writer.WritePropertyName("billingPeriodEndDate"u8);
                writer.WriteStringValue(BillingPeriodEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileName))
            {
                writer.WritePropertyName("billingProfileName"u8);
                writer.WriteStringValue(BillingProfileName);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountOwnerId))
            {
                writer.WritePropertyName("accountOwnerId"u8);
                writer.WriteStringValue(AccountOwnerId);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
            }
            if (options.Format != "W" && Optional.IsDefined(On))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(On.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (options.Format != "W" && Optional.IsDefined(PartNumber))
            {
                writer.WritePropertyName("partNumber"u8);
                writer.WriteStringValue(PartNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("meterId"u8);
                writer.WriteStringValue(MeterId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterDetails))
            {
                writer.WritePropertyName("meterDetails"u8);
                writer.WriteObjectValue(MeterDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EffectivePrice))
            {
                writer.WritePropertyName("effectivePrice"u8);
                writer.WriteNumberValue(EffectivePrice.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Cost))
            {
                writer.WritePropertyName("cost"u8);
                writer.WriteNumberValue(Cost.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UnitPrice))
            {
                writer.WritePropertyName("unitPrice"u8);
                writer.WriteNumberValue(UnitPrice.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingCurrency))
            {
                writer.WritePropertyName("billingCurrency"u8);
                writer.WriteStringValue(BillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ConsumedService))
            {
                writer.WritePropertyName("consumedService"u8);
                writer.WriteStringValue(ConsumedService);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceInfo1))
            {
                writer.WritePropertyName("serviceInfo1"u8);
                writer.WriteStringValue(ServiceInfo1);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceInfo2))
            {
                writer.WritePropertyName("serviceInfo2"u8);
                writer.WriteStringValue(ServiceInfo2);
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalInfo))
            {
                writer.WritePropertyName("additionalInfo"u8);
                writer.WriteStringValue(AdditionalInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSection))
            {
                writer.WritePropertyName("invoiceSection"u8);
                writer.WriteStringValue(InvoiceSection);
            }
            if (options.Format != "W" && Optional.IsDefined(CostCenter))
            {
                writer.WritePropertyName("costCenter"u8);
                writer.WriteStringValue(CostCenter);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationId))
            {
                writer.WritePropertyName("reservationId"u8);
                writer.WriteStringValue(ReservationId);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationName))
            {
                writer.WritePropertyName("reservationName"u8);
                writer.WriteStringValue(ReservationName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductOrderId))
            {
                writer.WritePropertyName("productOrderId"u8);
                writer.WriteStringValue(ProductOrderId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductOrderName))
            {
                writer.WritePropertyName("productOrderName"u8);
                writer.WriteStringValue(ProductOrderName);
            }
            if (options.Format != "W" && Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsAzureCreditEligible))
            {
                writer.WritePropertyName("isAzureCreditEligible"u8);
                writer.WriteBooleanValue(IsAzureCreditEligible.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherType))
            {
                writer.WritePropertyName("publisherType"u8);
                writer.WriteStringValue(PublisherType);
            }
            if (options.Format != "W" && Optional.IsDefined(PlanName))
            {
                writer.WritePropertyName("planName"u8);
                writer.WriteStringValue(PlanName);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargeType))
            {
                writer.WritePropertyName("chargeType"u8);
                writer.WriteStringValue(ChargeType);
            }
            if (options.Format != "W" && Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency);
            }
            if (options.Format != "W" && Optional.IsDefined(PayGPrice))
            {
                writer.WritePropertyName("payGPrice"u8);
                writer.WriteNumberValue(PayGPrice.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitId))
            {
                writer.WritePropertyName("benefitId"u8);
                writer.WriteStringValue(BenefitId);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitName))
            {
                writer.WritePropertyName("benefitName"u8);
                writer.WriteStringValue(BenefitName);
            }
            if (options.Format != "W" && Optional.IsDefined(PricingModel))
            {
                writer.WritePropertyName("pricingModel"u8);
                writer.WriteStringValue(PricingModel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ConsumptionLegacyUsageDetail IJsonModel<ConsumptionLegacyUsageDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyUsageDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLegacyUsageDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionLegacyUsageDetail(document.RootElement, options);
        }

        internal static ConsumptionLegacyUsageDetail DeserializeConsumptionLegacyUsageDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UsageDetailsKind kind = default;
            ETag? etag = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string billingAccountId = default;
            string billingAccountName = default;
            DateTimeOffset? billingPeriodStartDate = default;
            DateTimeOffset? billingPeriodEndDate = default;
            string billingProfileId = default;
            string billingProfileName = default;
            string accountOwnerId = default;
            string accountName = default;
            string subscriptionId = default;
            string subscriptionName = default;
            DateTimeOffset? date = default;
            string product = default;
            string partNumber = default;
            Guid? meterId = default;
            ConsumptionMeterDetailsInfo meterDetails = default;
            decimal? quantity = default;
            decimal? effectivePrice = default;
            decimal? cost = default;
            decimal? unitPrice = default;
            string billingCurrency = default;
            string resourceLocation = default;
            string consumedService = default;
            string resourceId = default;
            string resourceName = default;
            string serviceInfo1 = default;
            string serviceInfo2 = default;
            string additionalInfo = default;
            string invoiceSection = default;
            string costCenter = default;
            string resourceGroup = default;
            string reservationId = default;
            string reservationName = default;
            string productOrderId = default;
            string productOrderName = default;
            string offerId = default;
            bool? isAzureCreditEligible = default;
            string term = default;
            string publisherName = default;
            string publisherType = default;
            string planName = default;
            string chargeType = default;
            string frequency = default;
            decimal? payGPrice = default;
            string benefitId = default;
            string benefitName = default;
            ConsumptionPricingModelType? pricingModel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new UsageDetailsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConsumptionContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            billingAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingAccountName"u8))
                        {
                            billingAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            billingPeriodStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            billingPeriodEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerId"u8))
                        {
                            accountOwnerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionName"u8))
                        {
                            subscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("date"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            date = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partNumber"u8))
                        {
                            partNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("meterDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            meterDetails = ConsumptionMeterDetailsInfo.DeserializeConsumptionMeterDetailsInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("effectivePrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            effectivePrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("cost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cost = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("unitPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unitPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceLocation"u8))
                        {
                            resourceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumedService"u8))
                        {
                            consumedService = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceName"u8))
                        {
                            resourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo1"u8))
                        {
                            serviceInfo1 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo2"u8))
                        {
                            serviceInfo2 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalInfo"u8))
                        {
                            additionalInfo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSection"u8))
                        {
                            invoiceSection = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"u8))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"u8))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationName"u8))
                        {
                            reservationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderId"u8))
                        {
                            productOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderName"u8))
                        {
                            productOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAzureCreditEligible"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureCreditEligible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"u8))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherType"u8))
                        {
                            publisherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("planName"u8))
                        {
                            planName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("chargeType"u8))
                        {
                            chargeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("payGPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            payGPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("benefitId"u8))
                        {
                            benefitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitName"u8))
                        {
                            benefitName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pricingModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pricingModel = new ConsumptionPricingModelType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsumptionLegacyUsageDetail(
                id,
                name,
                type,
                systemData,
                kind,
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                billingAccountId,
                billingAccountName,
                billingPeriodStartDate,
                billingPeriodEndDate,
                billingProfileId,
                billingProfileName,
                accountOwnerId,
                accountName,
                subscriptionId,
                subscriptionName,
                date,
                product,
                partNumber,
                meterId,
                meterDetails,
                quantity,
                effectivePrice,
                cost,
                unitPrice,
                billingCurrency,
                resourceLocation,
                consumedService,
                resourceId,
                resourceName,
                serviceInfo1,
                serviceInfo2,
                additionalInfo,
                invoiceSection,
                costCenter,
                resourceGroup,
                reservationId,
                reservationName,
                productOrderId,
                productOrderName,
                offerId,
                isAzureCreditEligible,
                term,
                publisherName,
                publisherType,
                planName,
                chargeType,
                frequency,
                payGPrice,
                benefitId,
                benefitName,
                pricingModel);
        }

        BinaryData IPersistableModel<ConsumptionLegacyUsageDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyUsageDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConsumptionContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLegacyUsageDetail)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionLegacyUsageDetail IPersistableModel<ConsumptionLegacyUsageDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyUsageDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConsumptionLegacyUsageDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLegacyUsageDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionLegacyUsageDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

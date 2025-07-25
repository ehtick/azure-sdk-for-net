// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(AlertPropertiesDefinition))]
    [ModelReaderWriterBuildable(typeof(AlertPropertiesDetails))]
    [ModelReaderWriterBuildable(typeof(AllSavingsBenefitDetails))]
    [ModelReaderWriterBuildable(typeof(AllSavingsList))]
    [ModelReaderWriterBuildable(typeof(AsyncOperationStatusProperties))]
    [ModelReaderWriterBuildable(typeof(BenefitRecommendationModel))]
    [ModelReaderWriterBuildable(typeof(BenefitRecommendationProperties))]
    [ModelReaderWriterBuildable(typeof(BenefitRecommendationsListResult))]
    [ModelReaderWriterBuildable(typeof(BenefitUtilizationSummariesContent))]
    [ModelReaderWriterBuildable(typeof(BenefitUtilizationSummariesListResult))]
    [ModelReaderWriterBuildable(typeof(BenefitUtilizationSummariesOperationStatus))]
    [ModelReaderWriterBuildable(typeof(BenefitUtilizationSummary))]
    [ModelReaderWriterBuildable(typeof(CommonExportProperties))]
    [ModelReaderWriterBuildable(typeof(CostManagementAlertData))]
    [ModelReaderWriterBuildable(typeof(CostManagementAlertPatch))]
    [ModelReaderWriterBuildable(typeof(CostManagementAlertResource))]
    [ModelReaderWriterBuildable(typeof(CostManagementAlertsResult))]
    [ModelReaderWriterBuildable(typeof(CostManagementDimension))]
    [ModelReaderWriterBuildable(typeof(CostManagementDimensionsListResult))]
    [ModelReaderWriterBuildable(typeof(CostManagementExportData))]
    [ModelReaderWriterBuildable(typeof(CostManagementExportResource))]
    [ModelReaderWriterBuildable(typeof(CostManagementNameAvailabilityContent))]
    [ModelReaderWriterBuildable(typeof(CostManagementNameAvailabilityResult))]
    [ModelReaderWriterBuildable(typeof(CostManagementViewData))]
    [ModelReaderWriterBuildable(typeof(CostManagementViewsResource))]
    [ModelReaderWriterBuildable(typeof(DownloadURL))]
    [ModelReaderWriterBuildable(typeof(ExportDataset))]
    [ModelReaderWriterBuildable(typeof(ExportDatasetConfiguration))]
    [ModelReaderWriterBuildable(typeof(ExportDefinition))]
    [ModelReaderWriterBuildable(typeof(ExportDeliveryDestination))]
    [ModelReaderWriterBuildable(typeof(ExportDeliveryInfo))]
    [ModelReaderWriterBuildable(typeof(ExportExecutionListResult))]
    [ModelReaderWriterBuildable(typeof(ExportListResult))]
    [ModelReaderWriterBuildable(typeof(ExportRecurrencePeriod))]
    [ModelReaderWriterBuildable(typeof(ExportRun))]
    [ModelReaderWriterBuildable(typeof(ExportRunErrorDetails))]
    [ModelReaderWriterBuildable(typeof(ExportSchedule))]
    [ModelReaderWriterBuildable(typeof(ExportTimePeriod))]
    [ModelReaderWriterBuildable(typeof(FileDestination))]
    [ModelReaderWriterBuildable(typeof(ForecastAggregation))]
    [ModelReaderWriterBuildable(typeof(ForecastColumn))]
    [ModelReaderWriterBuildable(typeof(ForecastComparisonExpression))]
    [ModelReaderWriterBuildable(typeof(ForecastDataset))]
    [ModelReaderWriterBuildable(typeof(ForecastDatasetConfiguration))]
    [ModelReaderWriterBuildable(typeof(ForecastDefinition))]
    [ModelReaderWriterBuildable(typeof(ForecastFilter))]
    [ModelReaderWriterBuildable(typeof(ForecastResult))]
    [ModelReaderWriterBuildable(typeof(ForecastTimePeriod))]
    [ModelReaderWriterBuildable(typeof(IncludedQuantityUtilizationSummary))]
    [ModelReaderWriterBuildable(typeof(NotificationProperties))]
    [ModelReaderWriterBuildable(typeof(OperationStatus))]
    [ModelReaderWriterBuildable(typeof(QueryAggregation))]
    [ModelReaderWriterBuildable(typeof(QueryColumn))]
    [ModelReaderWriterBuildable(typeof(QueryComparisonExpression))]
    [ModelReaderWriterBuildable(typeof(QueryDataset))]
    [ModelReaderWriterBuildable(typeof(QueryDatasetConfiguration))]
    [ModelReaderWriterBuildable(typeof(QueryDefinition))]
    [ModelReaderWriterBuildable(typeof(QueryFilter))]
    [ModelReaderWriterBuildable(typeof(QueryGrouping))]
    [ModelReaderWriterBuildable(typeof(QueryResult))]
    [ModelReaderWriterBuildable(typeof(QueryTimePeriod))]
    [ModelReaderWriterBuildable(typeof(RecommendationUsageDetails))]
    [ModelReaderWriterBuildable(typeof(ReportConfigAggregation))]
    [ModelReaderWriterBuildable(typeof(ReportConfigComparisonExpression))]
    [ModelReaderWriterBuildable(typeof(ReportConfigDataset))]
    [ModelReaderWriterBuildable(typeof(ReportConfigDatasetConfiguration))]
    [ModelReaderWriterBuildable(typeof(ReportConfigFilter))]
    [ModelReaderWriterBuildable(typeof(ReportConfigGrouping))]
    [ModelReaderWriterBuildable(typeof(ReportConfigSorting))]
    [ModelReaderWriterBuildable(typeof(ReportConfigTimePeriod))]
    [ModelReaderWriterBuildable(typeof(ResponseError))]
    [ModelReaderWriterBuildable(typeof(SavingsPlanUtilizationSummary))]
    [ModelReaderWriterBuildable(typeof(ScheduledActionData))]
    [ModelReaderWriterBuildable(typeof(ScheduledActionListResult))]
    [ModelReaderWriterBuildable(typeof(ScheduledActionResource))]
    [ModelReaderWriterBuildable(typeof(ScheduleProperties))]
    [ModelReaderWriterBuildable(typeof(SharedScopeBenefitRecommendationProperties))]
    [ModelReaderWriterBuildable(typeof(SingleScopeBenefitRecommendationProperties))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(TenantResourceByExternalCloudProviderTypeDimensionsOptions))]
    [ModelReaderWriterBuildable(typeof(TenantScheduledActionResource))]
    [ModelReaderWriterBuildable(typeof(TenantsCostManagementViewsResource))]
    [ModelReaderWriterBuildable(typeof(UnknownBenefitRecommendationProperties))]
    [ModelReaderWriterBuildable(typeof(UnknownBenefitUtilizationSummary))]
    [ModelReaderWriterBuildable(typeof(ViewKpiProperties))]
    [ModelReaderWriterBuildable(typeof(ViewListResult))]
    [ModelReaderWriterBuildable(typeof(ViewPivotProperties))]
    public partial class AzureResourceManagerCostManagementContext : ModelReaderWriterContext
    {
    }
}

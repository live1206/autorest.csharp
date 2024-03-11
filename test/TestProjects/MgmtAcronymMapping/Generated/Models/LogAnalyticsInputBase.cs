// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using MgmtAcronymMapping;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// Api input base class for LogAnalytics Api.
    /// Serialized Name: LogAnalyticsInputBase
    /// </summary>
    public partial class LogAnalyticsInputBase
    {
        /// <summary> Initializes a new instance of <see cref="LogAnalyticsInputBase"/>. </summary>
        /// <param name="blobContainerSasUri">
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// Serialized Name: LogAnalyticsInputBase.blobContainerSasUri
        /// </param>
        /// <param name="fromTime">
        /// From time of the query
        /// Serialized Name: LogAnalyticsInputBase.fromTime
        /// </param>
        /// <param name="toTime">
        /// To time of the query
        /// Serialized Name: LogAnalyticsInputBase.toTime
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainerSasUri"/> is null. </exception>
        public LogAnalyticsInputBase(Uri blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime)
        {
            Argument.AssertNotNull(blobContainerSasUri, nameof(blobContainerSasUri));

            BlobContainerSasUri = blobContainerSasUri;
            FromTime = fromTime;
            ToTime = toTime;
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsInputBase"/>. </summary>
        /// <param name="blobContainerSasUri">
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// Serialized Name: LogAnalyticsInputBase.blobContainerSasUri
        /// </param>
        /// <param name="fromTime">
        /// From time of the query
        /// Serialized Name: LogAnalyticsInputBase.fromTime
        /// </param>
        /// <param name="toTime">
        /// To time of the query
        /// Serialized Name: LogAnalyticsInputBase.toTime
        /// </param>
        /// <param name="groupByThrottlePolicy">
        /// Group query result by Throttle Policy applied.
        /// Serialized Name: LogAnalyticsInputBase.groupByThrottlePolicy
        /// </param>
        /// <param name="groupByOperationName">
        /// Group query result by Operation Name.
        /// Serialized Name: LogAnalyticsInputBase.groupByOperationName
        /// </param>
        /// <param name="groupByResourceName">
        /// Group query result by Resource Name.
        /// Serialized Name: LogAnalyticsInputBase.groupByResourceName
        /// </param>
        internal LogAnalyticsInputBase(Uri blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime, bool? groupByThrottlePolicy, bool? groupByOperationName, bool? groupByResourceName)
        {
            BlobContainerSasUri = blobContainerSasUri;
            FromTime = fromTime;
            ToTime = toTime;
            GroupByThrottlePolicy = groupByThrottlePolicy;
            GroupByOperationName = groupByOperationName;
            GroupByResourceName = groupByResourceName;
        }

        /// <summary>
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// Serialized Name: LogAnalyticsInputBase.blobContainerSasUri
        /// </summary>
        public Uri BlobContainerSasUri { get; }
        /// <summary>
        /// From time of the query
        /// Serialized Name: LogAnalyticsInputBase.fromTime
        /// </summary>
        public DateTimeOffset FromTime { get; }
        /// <summary>
        /// To time of the query
        /// Serialized Name: LogAnalyticsInputBase.toTime
        /// </summary>
        public DateTimeOffset ToTime { get; }
        /// <summary>
        /// Group query result by Throttle Policy applied.
        /// Serialized Name: LogAnalyticsInputBase.groupByThrottlePolicy
        /// </summary>
        public bool? GroupByThrottlePolicy { get; set; }
        /// <summary>
        /// Group query result by Operation Name.
        /// Serialized Name: LogAnalyticsInputBase.groupByOperationName
        /// </summary>
        public bool? GroupByOperationName { get; set; }
        /// <summary>
        /// Group query result by Resource Name.
        /// Serialized Name: LogAnalyticsInputBase.groupByResourceName
        /// </summary>
        public bool? GroupByResourceName { get; set; }
    }
}

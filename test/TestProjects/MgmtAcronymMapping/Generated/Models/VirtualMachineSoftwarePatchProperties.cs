// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// Describes the properties of a Virtual Machine software patch.
    /// Serialized Name: VirtualMachineSoftwarePatchProperties
    /// </summary>
    public partial class VirtualMachineSoftwarePatchProperties
    {
        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        internal VirtualMachineSoftwarePatchProperties()
        {
            Classifications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        /// <param name="patchId">
        /// A unique identifier for the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.patchId
        /// </param>
        /// <param name="name">
        /// The friendly name of the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.name
        /// </param>
        /// <param name="version">
        /// The version number of the patch. This property applies only to Linux patches.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.version
        /// </param>
        /// <param name="kbid">
        /// The KBID of the patch. Only applies to Windows patches.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.kbid
        /// </param>
        /// <param name="classifications">
        /// The classification(s) of the patch as provided by the patch publisher.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.classifications
        /// </param>
        /// <param name="rebootBehavior">
        /// Describes the reboot requirements of the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.rebootBehavior
        /// </param>
        /// <param name="activityId">
        /// The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.activityId
        /// </param>
        /// <param name="publishedOn">
        /// The UTC timestamp when the repository published this patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.publishedDate
        /// </param>
        /// <param name="lastModifiedOn">
        /// The UTC timestamp of the last update to this patch record.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.lastModifiedDateTime
        /// </param>
        /// <param name="assessmentState">
        /// Describes the outcome of an install operation for a given patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.assessmentState
        /// </param>
        internal VirtualMachineSoftwarePatchProperties(string patchId, string name, string version, string kbid, IReadOnlyList<string> classifications, SoftwareUpdateRebootBehavior? rebootBehavior, string activityId, DateTimeOffset? publishedOn, DateTimeOffset? lastModifiedOn, PatchAssessmentState? assessmentState)
        {
            PatchId = patchId;
            Name = name;
            Version = version;
            Kbid = kbid;
            Classifications = classifications;
            RebootBehavior = rebootBehavior;
            ActivityId = activityId;
            PublishedOn = publishedOn;
            LastModifiedOn = lastModifiedOn;
            AssessmentState = assessmentState;
        }

        /// <summary>
        /// A unique identifier for the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.patchId
        /// </summary>
        public string PatchId { get; }
        /// <summary>
        /// The friendly name of the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The version number of the patch. This property applies only to Linux patches.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.version
        /// </summary>
        public string Version { get; }
        /// <summary>
        /// The KBID of the patch. Only applies to Windows patches.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.kbid
        /// </summary>
        public string Kbid { get; }
        /// <summary>
        /// The classification(s) of the patch as provided by the patch publisher.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.classifications
        /// </summary>
        public IReadOnlyList<string> Classifications { get; }
        /// <summary>
        /// Describes the reboot requirements of the patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.rebootBehavior
        /// </summary>
        public SoftwareUpdateRebootBehavior? RebootBehavior { get; }
        /// <summary>
        /// The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.activityId
        /// </summary>
        public string ActivityId { get; }
        /// <summary>
        /// The UTC timestamp when the repository published this patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.publishedDate
        /// </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary>
        /// The UTC timestamp of the last update to this patch record.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.lastModifiedDateTime
        /// </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary>
        /// Describes the outcome of an install operation for a given patch.
        /// Serialized Name: VirtualMachineSoftwarePatchProperties.assessmentState
        /// </summary>
        public PatchAssessmentState? AssessmentState { get; }
    }
}
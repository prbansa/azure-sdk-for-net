// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobResult
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class JobResultEnumExtension
    {
        internal static string ToSerializedValue(this JobResult? value)  =>
            value == null ? null : ((JobResult)value).ToSerializedValue();

        internal static string ToSerializedValue(this JobResult value)
        {
            switch( value )
            {
                case JobResult.None:
                    return "None";
                case JobResult.Succeeded:
                    return "Succeeded";
                case JobResult.Cancelled:
                    return "Cancelled";
                case JobResult.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static JobResult? ParseJobResult(this string value)
        {
            switch( value )
            {
                case "None":
                    return JobResult.None;
                case "Succeeded":
                    return JobResult.Succeeded;
                case "Cancelled":
                    return JobResult.Cancelled;
                case "Failed":
                    return JobResult.Failed;
            }
            return null;
        }
    }
}

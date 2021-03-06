// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Task execution information.
    /// </summary>
    public partial class TaskExecutionInformation : IPropertyMetadata
    {
        private readonly DateTime? endTime;
        private readonly int? exitCode;
        private readonly TaskFailureInformation failureInformation;
        private readonly DateTime? lastRequeueTime;
        private readonly DateTime? lastRetryTime;
        private readonly int requeueCount;
        private readonly Common.TaskExecutionResult? result;
        private readonly int retryCount;
        private readonly DateTime? startTime;

        #region Constructors

        internal TaskExecutionInformation(Models.TaskExecutionInformation protocolObject)
        {
            this.endTime = protocolObject.EndTime;
            this.exitCode = protocolObject.ExitCode;
            this.failureInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.FailureInfo, o => new TaskFailureInformation(o).Freeze());
            this.lastRequeueTime = protocolObject.LastRequeueTime;
            this.lastRetryTime = protocolObject.LastRetryTime;
            this.requeueCount = protocolObject.RequeueCount;
            this.result = UtilitiesInternal.MapNullableEnum<Models.TaskExecutionResult, Common.TaskExecutionResult>(protocolObject.Result);
            this.retryCount = protocolObject.RetryCount;
            this.startTime = protocolObject.StartTime;
        }

        #endregion Constructors

        #region TaskExecutionInformation

        /// <summary>
        /// Gets the time at which the task completed.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the exit code of the program specified on the task command line.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the task is in the <see cref="Common.TaskState.Completed"/> state. The exit 
        /// code for a process reflects the specific convention implemented by the application developer for that process. 
        /// If you use the exit code value to make decisions in your code, be sure that you know the exit code convention 
        /// used by the application process. Note that the exit code may also be generated by the compute node operating 
        /// system, such as when a process is forcibly terminated.
        /// </remarks>
        public int? ExitCode
        {
            get { return this.exitCode; }
        }

        /// <summary>
        /// Gets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the <see cref="Common.TaskState.Completed"/> state and encountered 
        /// a failure.
        /// </remarks>
        public TaskFailureInformation FailureInformation
        {
            get { return this.failureInformation; }
        }

        /// <summary>
        /// Gets the most recent time at which this task's execution was re-queued by the Batch service per user request.
        /// </summary>
        public DateTime? LastRequeueTime
        {
            get { return this.lastRequeueTime; }
        }

        /// <summary>
        /// Gets the most recent time at which this task's execution was retried by the Batch service.
        /// </summary>
        public DateTime? LastRetryTime
        {
            get { return this.lastRetryTime; }
        }

        /// <summary>
        /// Gets the number of times this task's execution was re-queued by the Batch service per user request.
        /// </summary>
        public int RequeueCount
        {
            get { return this.requeueCount; }
        }

        /// <summary>
        /// Gets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is <see cref="Common.TaskExecutionResult.Failure" />, then the details of the failure can be found 
        /// in the <see cref="FailureInformation" /> property.
        /// </remarks>
        public Common.TaskExecutionResult? Result
        {
            get { return this.result; }
        }

        /// <summary>
        /// Gets the number of times the task has been retried by the Batch service.
        /// </summary>
        /// <remarks>
        /// Task application failures (non-zero exit code) are retried, pre-processing errors (the task could not be run) 
        /// and file upload errors are not retried. The Batch service will retry the task up to the specified <see cref="TaskConstraints.MaxTaskRetryCount" 
        /// />.
        /// </remarks>
        public int RetryCount
        {
            get { return this.retryCount; }
        }

        /// <summary>
        /// Gets the time at which the task started running.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this.startTime; }
        }

        #endregion // TaskExecutionInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}
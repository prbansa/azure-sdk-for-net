// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation schedules.  (see
    /// http://aka.ms/azureautomationsdk/scheduleoperations for more
    /// information)
    /// </summary>
    public partial interface IScheduleOperations
    {
        /// <summary>
        /// Create a schedule.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create or update schedule operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create or update schedule operation.
        /// </returns>
        Task<ScheduleCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string automationAccount, ScheduleCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// The schedule name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string automationAccount, string scheduleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// The schedule name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get schedule operation.
        /// </returns>
        Task<ScheduleGetResponse> GetAsync(string resourceGroupName, string automationAccount, string scheduleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        Task<ScheduleListResponse> ListAsync(string resourceGroupName, string automationAccount, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='nextLink'>
        /// The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        Task<ScheduleListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the patch schedule operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> PatchAsync(string resourceGroupName, string automationAccount, SchedulePatchParameters parameters, CancellationToken cancellationToken);
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GeoBackupPoliciesOperations.
    /// </summary>
    public static partial class GeoBackupPoliciesOperationsExtensions
    {
            /// <summary>
            /// Updates a database geo backup policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating the geo backup policy.
            /// </param>
            public static GeoBackupPolicy CreateOrUpdate(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, GeoBackupPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a database geo backup policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating the geo backup policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GeoBackupPolicy> CreateOrUpdateAsync(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, GeoBackupPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a geo backup policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static GeoBackupPolicy Get(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a geo backup policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GeoBackupPolicy> GetAsync(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of geo backup policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static IEnumerable<GeoBackupPolicy> ListByDatabase(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of geo backup policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<GeoBackupPolicy>> ListByDatabaseAsync(this IGeoBackupPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

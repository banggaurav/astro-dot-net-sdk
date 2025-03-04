// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseGeoBackupPolicyResource"/> and their operations.
    /// Each <see cref="SynapseGeoBackupPolicyResource"/> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource"/>.
    /// To get a <see cref="SynapseGeoBackupPolicyCollection"/> instance call the GetSynapseGeoBackupPolicies method from an instance of <see cref="SynapseSqlPoolResource"/>.
    /// </summary>
    public partial class SynapseGeoBackupPolicyCollection : ArmCollection, IEnumerable<SynapseGeoBackupPolicyResource>, IAsyncEnumerable<SynapseGeoBackupPolicyResource>
    {
        private readonly ClientDiagnostics _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics;
        private readonly SqlPoolGeoBackupPoliciesRestOperations _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseGeoBackupPolicyCollection"/> class for mocking. </summary>
        protected SynapseGeoBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseGeoBackupPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseGeoBackupPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseGeoBackupPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseGeoBackupPolicyResource.ResourceType, out string synapseGeoBackupPolicySqlPoolGeoBackupPoliciesApiVersion);
            _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient = new SqlPoolGeoBackupPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseGeoBackupPolicySqlPoolGeoBackupPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a SQL Pool geo backup policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="data"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseGeoBackupPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseGeoBackupPolicyName geoBackupPolicyName, SynapseGeoBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseGeoBackupPolicyResource>(Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a SQL Pool geo backup policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="data"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseGeoBackupPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SynapseGeoBackupPolicyName geoBackupPolicyName, SynapseGeoBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseGeoBackupPolicyResource>(Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified SQL pool geo backup policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseGeoBackupPolicyResource>> GetAsync(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified SQL pool geo backup policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseGeoBackupPolicyResource> Get(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of SQL pool geo backup policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseGeoBackupPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseGeoBackupPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SynapseGeoBackupPolicyResource(Client, SynapseGeoBackupPolicyData.DeserializeSynapseGeoBackupPolicyData(e)), _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics, Pipeline, "SynapseGeoBackupPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of SQL pool geo backup policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseGeoBackupPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseGeoBackupPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SynapseGeoBackupPolicyResource(Client, SynapseGeoBackupPolicyData.DeserializeSynapseGeoBackupPolicyData(e)), _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics, Pipeline, "SynapseGeoBackupPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseGeoBackupPolicyResource>> GetIfExistsAsync(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseGeoBackupPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/geoBackupPolicies/{geoBackupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolGeoBackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseGeoBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseGeoBackupPolicyResource> GetIfExists(SynapseGeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesClientDiagnostics.CreateScope("SynapseGeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseGeoBackupPolicySqlPoolGeoBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseGeoBackupPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseGeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseGeoBackupPolicyResource> IEnumerable<SynapseGeoBackupPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseGeoBackupPolicyResource> IAsyncEnumerable<SynapseGeoBackupPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

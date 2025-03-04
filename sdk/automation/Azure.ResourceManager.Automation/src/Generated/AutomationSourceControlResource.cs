// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A Class representing an AutomationSourceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomationSourceControlResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomationSourceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="AutomationAccountResource"/> using the GetAutomationSourceControl method.
    /// </summary>
    public partial class AutomationSourceControlResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomationSourceControlResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="automationAccountName"> The automationAccountName. </param>
        /// <param name="sourceControlName"> The sourceControlName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automationSourceControlSourceControlClientDiagnostics;
        private readonly SourceControlRestOperations _automationSourceControlSourceControlRestClient;
        private readonly ClientDiagnostics _sourceControlSyncJobClientDiagnostics;
        private readonly SourceControlSyncJobRestOperations _sourceControlSyncJobRestClient;
        private readonly ClientDiagnostics _sourceControlSyncJobStreamsClientDiagnostics;
        private readonly SourceControlSyncJobStreamsRestOperations _sourceControlSyncJobStreamsRestClient;
        private readonly AutomationSourceControlData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automation/automationAccounts/sourceControls";

        /// <summary> Initializes a new instance of the <see cref="AutomationSourceControlResource"/> class for mocking. </summary>
        protected AutomationSourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomationSourceControlResource(ArmClient client, AutomationSourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomationSourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationSourceControlSourceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automationSourceControlSourceControlApiVersion);
            _automationSourceControlSourceControlRestClient = new SourceControlRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationSourceControlSourceControlApiVersion);
            _sourceControlSyncJobClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _sourceControlSyncJobRestClient = new SourceControlSyncJobRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _sourceControlSyncJobStreamsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _sourceControlSyncJobStreamsRestClient = new SourceControlSyncJobStreamsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomationSourceControlData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieve the source control identified by source control name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomationSourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the source control identified by source control name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomationSourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The parameters supplied to the update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<AutomationSourceControlResource>> UpdateAsync(AutomationSourceControlPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The parameters supplied to the update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<AutomationSourceControlResource> Update(AutomationSourceControlPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the sync job for a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="content"> The parameters supplied to the create source control sync job operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SourceControlSyncJob>> CreateSourceControlSyncJobAsync(Guid sourceControlSyncJobId, SourceControlSyncJobCreateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sourceControlSyncJobClientDiagnostics.CreateScope("AutomationSourceControlResource.CreateSourceControlSyncJob");
            scope.Start();
            try
            {
                var response = await _sourceControlSyncJobRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the sync job for a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="content"> The parameters supplied to the create source control sync job operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SourceControlSyncJob> CreateSourceControlSyncJob(Guid sourceControlSyncJobId, SourceControlSyncJobCreateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sourceControlSyncJobClientDiagnostics.CreateScope("AutomationSourceControlResource.CreateSourceControlSyncJob");
            scope.Start();
            try
            {
                var response = _sourceControlSyncJobRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the source control sync job identified by job id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SourceControlSyncJobResult>> GetSourceControlSyncJobAsync(Guid sourceControlSyncJobId, CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlSyncJobClientDiagnostics.CreateScope("AutomationSourceControlResource.GetSourceControlSyncJob");
            scope.Start();
            try
            {
                var response = await _sourceControlSyncJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the source control sync job identified by job id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SourceControlSyncJobResult> GetSourceControlSyncJob(Guid sourceControlSyncJobId, CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlSyncJobClientDiagnostics.CreateScope("AutomationSourceControlResource.GetSourceControlSyncJob");
            scope.Start();
            try
            {
                var response = _sourceControlSyncJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of source control sync jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControlSyncJob"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControlSyncJob> GetSourceControlSyncJobsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sourceControlSyncJobRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sourceControlSyncJobRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SourceControlSyncJob.DeserializeSourceControlSyncJob(e), _sourceControlSyncJobClientDiagnostics, Pipeline, "AutomationSourceControlResource.GetSourceControlSyncJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of source control sync jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJob_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControlSyncJob"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControlSyncJob> GetSourceControlSyncJobs(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sourceControlSyncJobRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sourceControlSyncJobRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SourceControlSyncJob.DeserializeSourceControlSyncJob(e), _sourceControlSyncJobClientDiagnostics, Pipeline, "AutomationSourceControlResource.GetSourceControlSyncJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of sync job streams identified by sync job id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}/streams</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJobStreams_ListBySyncJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControlSyncJobStream"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControlSyncJobStream> GetSourceControlSyncJobStreamsAsync(Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sourceControlSyncJobStreamsRestClient.CreateListBySyncJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sourceControlSyncJobStreamsRestClient.CreateListBySyncJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SourceControlSyncJobStream.DeserializeSourceControlSyncJobStream(e), _sourceControlSyncJobStreamsClientDiagnostics, Pipeline, "AutomationSourceControlResource.GetSourceControlSyncJobStreams", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of sync job streams identified by sync job id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}/streams</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJobStreams_ListBySyncJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControlSyncJobStream"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControlSyncJobStream> GetSourceControlSyncJobStreams(Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sourceControlSyncJobStreamsRestClient.CreateListBySyncJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sourceControlSyncJobStreamsRestClient.CreateListBySyncJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SourceControlSyncJobStream.DeserializeSourceControlSyncJobStream(e), _sourceControlSyncJobStreamsClientDiagnostics, Pipeline, "AutomationSourceControlResource.GetSourceControlSyncJobStreams", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a sync job stream identified by stream id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}/streams/{streamId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJobStreams_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="streamId"> The id of the sync job stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamId"/> is null. </exception>
        public virtual async Task<Response<SourceControlSyncJobStreamResult>> GetSourceControlSyncJobStreamAsync(Guid sourceControlSyncJobId, string streamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamId, nameof(streamId));

            using var scope = _sourceControlSyncJobStreamsClientDiagnostics.CreateScope("AutomationSourceControlResource.GetSourceControlSyncJobStream");
            scope.Start();
            try
            {
                var response = await _sourceControlSyncJobStreamsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, streamId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a sync job stream identified by stream id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}/sourceControlSyncJobs/{sourceControlSyncJobId}/streams/{streamId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlSyncJobStreams_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="streamId"> The id of the sync job stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamId"/> is null. </exception>
        public virtual Response<SourceControlSyncJobStreamResult> GetSourceControlSyncJobStream(Guid sourceControlSyncJobId, string streamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamId, nameof(streamId));

            using var scope = _sourceControlSyncJobStreamsClientDiagnostics.CreateScope("AutomationSourceControlResource.GetSourceControlSyncJobStream");
            scope.Start();
            try
            {
                var response = _sourceControlSyncJobStreamsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sourceControlSyncJobId, streamId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

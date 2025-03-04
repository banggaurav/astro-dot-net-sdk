// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockablePeeringResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePeeringResourceGroupResource"/> class for mocking. </summary>
        protected MockablePeeringResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePeeringResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePeeringResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PeeringResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PeeringResources and their operations over a PeeringResource. </returns>
        public virtual PeeringCollection GetPeerings()
        {
            return GetCachedClient(client => new PeeringCollection(client, Id));
        }

        /// <summary>
        /// Gets an existing peering with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Peerings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PeeringResource>> GetPeeringAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            return await GetPeerings().GetAsync(peeringName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing peering with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Peerings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PeeringResource> GetPeering(string peeringName, CancellationToken cancellationToken = default)
        {
            return GetPeerings().Get(peeringName, cancellationToken);
        }

        /// <summary> Gets a collection of PeeringServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PeeringServiceResources and their operations over a PeeringServiceResource. </returns>
        public virtual PeeringServiceCollection GetPeeringServices()
        {
            return GetCachedClient(client => new PeeringServiceCollection(client, Id));
        }

        /// <summary>
        /// Gets an existing peering service with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PeeringServiceResource>> GetPeeringServiceAsync(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            return await GetPeeringServices().GetAsync(peeringServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing peering service with the specified name under the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeeringServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringServiceName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PeeringServiceResource> GetPeeringService(string peeringServiceName, CancellationToken cancellationToken = default)
        {
            return GetPeeringServices().Get(peeringServiceName, cancellationToken);
        }
    }
}

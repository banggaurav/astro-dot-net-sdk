// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents threat intelligence data connector. </summary>
    public partial class SecurityInsightsTIDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsTIDataConnector"/>. </summary>
        public SecurityInsightsTIDataConnector()
        {
            Kind = DataConnectorKind.ThreatIntelligence;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsTIDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="tipLookbackOn"> The lookback period for the feed to be imported. </param>
        /// <param name="dataTypes"> The available data types for the connector. </param>
        internal SecurityInsightsTIDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, DateTimeOffset? tipLookbackOn, TIDataConnectorDataTypes dataTypes) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            TipLookbackOn = tipLookbackOn;
            DataTypes = dataTypes;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The lookback period for the feed to be imported. </summary>
        public DateTimeOffset? TipLookbackOn { get; set; }
        /// <summary> The available data types for the connector. </summary>
        internal TIDataConnectorDataTypes DataTypes { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? IndicatorsState
        {
            get => DataTypes is null ? default : DataTypes.IndicatorsState;
            set
            {
                if (DataTypes is null)
                    DataTypes = new TIDataConnectorDataTypes();
                DataTypes.IndicatorsState = value;
            }
        }
    }
}

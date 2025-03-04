// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Sku capability. </summary>
    public partial class PostgreSqlFlexibleServerSkuCapability : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerSkuCapability"/>. </summary>
        internal PostgreSqlFlexibleServerSkuCapability()
        {
            SupportedZones = new ChangeTrackingList<string>();
            SupportedHaMode = new ChangeTrackingList<PostgreSqlFlexibleServerHAMode>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerSkuCapability"/>. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Sku name. </param>
        /// <param name="vCores"> Supported vCores. </param>
        /// <param name="supportedIops"> Supported IOPS. </param>
        /// <param name="supportedMemoryPerVcoreMb"> Supported memory per vCore in MB. </param>
        /// <param name="supportedZones"> List of supported Availability Zones. E.g. "1", "2", "3". </param>
        /// <param name="supportedHaMode"> Supported high availability mode. </param>
        internal PostgreSqlFlexibleServerSkuCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, int? vCores, int? supportedIops, long? supportedMemoryPerVcoreMb, IReadOnlyList<string> supportedZones, IReadOnlyList<PostgreSqlFlexibleServerHAMode> supportedHaMode) : base(capabilityStatus, reason, serializedAdditionalRawData)
        {
            Name = name;
            VCores = vCores;
            SupportedIops = supportedIops;
            SupportedMemoryPerVcoreMb = supportedMemoryPerVcoreMb;
            SupportedZones = supportedZones;
            SupportedHaMode = supportedHaMode;
        }

        /// <summary> Sku name. </summary>
        public string Name { get; }
        /// <summary> Supported vCores. </summary>
        public int? VCores { get; }
        /// <summary> Supported IOPS. </summary>
        public int? SupportedIops { get; }
        /// <summary> Supported memory per vCore in MB. </summary>
        public long? SupportedMemoryPerVcoreMb { get; }
        /// <summary> List of supported Availability Zones. E.g. "1", "2", "3". </summary>
        public IReadOnlyList<string> SupportedZones { get; }
        /// <summary> Supported high availability mode. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerHAMode> SupportedHaMode { get; }
    }
}

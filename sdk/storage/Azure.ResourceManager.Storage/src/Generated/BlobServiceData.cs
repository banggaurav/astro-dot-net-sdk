// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the BlobService data model.
    /// The properties of a storage account’s Blob service.
    /// </summary>
    public partial class BlobServiceData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobServiceData"/>. </summary>
        public BlobServiceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Sku name and tier. </param>
        /// <param name="cors"> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </param>
        /// <param name="defaultServiceVersion"> DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions. </param>
        /// <param name="deleteRetentionPolicy"> The blob service properties for blob soft delete. </param>
        /// <param name="isVersioningEnabled"> Versioning is enabled if set to true. </param>
        /// <param name="isAutomaticSnapshotPolicyEnabled"> Deprecated in favor of isVersioningEnabled property. </param>
        /// <param name="changeFeed"> The blob service properties for change feed events. </param>
        /// <param name="restorePolicy"> The blob service properties for blob restore policy. </param>
        /// <param name="containerDeleteRetentionPolicy"> The blob service properties for container soft delete. </param>
        /// <param name="lastAccessTimeTrackingPolicy"> The blob service property to configure last access time based tracking policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StorageSku sku, StorageCorsRules cors, string defaultServiceVersion, DeleteRetentionPolicy deleteRetentionPolicy, bool? isVersioningEnabled, bool? isAutomaticSnapshotPolicyEnabled, BlobServiceChangeFeed changeFeed, RestorePolicy restorePolicy, DeleteRetentionPolicy containerDeleteRetentionPolicy, LastAccessTimeTrackingPolicy lastAccessTimeTrackingPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Cors = cors;
            DefaultServiceVersion = defaultServiceVersion;
            DeleteRetentionPolicy = deleteRetentionPolicy;
            IsVersioningEnabled = isVersioningEnabled;
            IsAutomaticSnapshotPolicyEnabled = isAutomaticSnapshotPolicyEnabled;
            ChangeFeed = changeFeed;
            RestorePolicy = restorePolicy;
            ContainerDeleteRetentionPolicy = containerDeleteRetentionPolicy;
            LastAccessTimeTrackingPolicy = lastAccessTimeTrackingPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sku name and tier. </summary>
        public StorageSku Sku { get; }
        /// <summary> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </summary>
        internal StorageCorsRules Cors { get; set; }
        /// <summary> The List of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<StorageCorsRule> CorsRules
        {
            get
            {
                if (Cors is null)
                    Cors = new StorageCorsRules();
                return Cors.CorsRules;
            }
        }

        /// <summary> DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions. </summary>
        public string DefaultServiceVersion { get; set; }
        /// <summary> The blob service properties for blob soft delete. </summary>
        public DeleteRetentionPolicy DeleteRetentionPolicy { get; set; }
        /// <summary> Versioning is enabled if set to true. </summary>
        public bool? IsVersioningEnabled { get; set; }
        /// <summary> Deprecated in favor of isVersioningEnabled property. </summary>
        public bool? IsAutomaticSnapshotPolicyEnabled { get; set; }
        /// <summary> The blob service properties for change feed events. </summary>
        public BlobServiceChangeFeed ChangeFeed { get; set; }
        /// <summary> The blob service properties for blob restore policy. </summary>
        public RestorePolicy RestorePolicy { get; set; }
        /// <summary> The blob service properties for container soft delete. </summary>
        public DeleteRetentionPolicy ContainerDeleteRetentionPolicy { get; set; }
        /// <summary> The blob service property to configure last access time based tracking policy. </summary>
        public LastAccessTimeTrackingPolicy LastAccessTimeTrackingPolicy { get; set; }
    }
}

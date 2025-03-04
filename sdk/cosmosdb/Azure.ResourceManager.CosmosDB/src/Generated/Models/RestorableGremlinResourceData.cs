// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specific Databases to restore. </summary>
    public partial class RestorableGremlinResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinResourceData"/>. </summary>
        internal RestorableGremlinResourceData()
        {
            GraphNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseName"> The name of the gremlin database available for restore. </param>
        /// <param name="graphNames"> The names of the graphs available for restore. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorableGremlinResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string databaseName, IReadOnlyList<string> graphNames, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DatabaseName = databaseName;
            GraphNames = graphNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the gremlin database available for restore. </summary>
        public string DatabaseName { get; }
        /// <summary> The names of the graphs available for restore. </summary>
        public IReadOnlyList<string> GraphNames { get; }
    }
}

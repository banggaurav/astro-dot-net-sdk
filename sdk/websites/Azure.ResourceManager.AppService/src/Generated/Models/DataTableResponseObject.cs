// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Data Table which defines columns and raw row values. </summary>
    public partial class DataTableResponseObject
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

        /// <summary> Initializes a new instance of <see cref="DataTableResponseObject"/>. </summary>
        public DataTableResponseObject()
        {
            Columns = new ChangeTrackingList<DataTableResponseColumn>();
            Rows = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of <see cref="DataTableResponseObject"/>. </summary>
        /// <param name="tableName"> Name of the table. </param>
        /// <param name="columns"> List of columns with data types. </param>
        /// <param name="rows"> Raw row values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataTableResponseObject(string tableName, IList<DataTableResponseColumn> columns, IList<IList<string>> rows, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TableName = tableName;
            Columns = columns;
            Rows = rows;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the table. </summary>
        public string TableName { get; set; }
        /// <summary> List of columns with data types. </summary>
        public IList<DataTableResponseColumn> Columns { get; }
        /// <summary> Raw row values. </summary>
        public IList<IList<string>> Rows { get; }
    }
}

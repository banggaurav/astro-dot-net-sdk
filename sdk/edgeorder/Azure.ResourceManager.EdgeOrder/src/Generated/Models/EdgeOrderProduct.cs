// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> List of Products. </summary>
    public partial class EdgeOrderProduct
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

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProduct"/>. </summary>
        internal EdgeOrderProduct()
        {
            ImageInformation = new ChangeTrackingList<EdgeOrderProductImageInformation>();
            FilterableProperties = new ChangeTrackingList<FilterableProperty>();
            Configurations = new ChangeTrackingList<ProductConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProduct"/>. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="configurations"> List of configurations for the product. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderProduct(string displayName, ProductDescription description, IReadOnlyList<EdgeOrderProductImageInformation> imageInformation, EdgeOrderProductCostInformation costInformation, ProductAvailabilityInformation availabilityInformation, HierarchyInformation hierarchyInformation, IReadOnlyList<FilterableProperty> filterableProperties, IReadOnlyList<ProductConfiguration> configurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            ImageInformation = imageInformation;
            CostInformation = costInformation;
            AvailabilityInformation = availabilityInformation;
            HierarchyInformation = hierarchyInformation;
            FilterableProperties = filterableProperties;
            Configurations = configurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Display Name for the product system. </summary>
        public string DisplayName { get; }
        /// <summary> Description related to the product system. </summary>
        public ProductDescription Description { get; }
        /// <summary> Image information for the product system. </summary>
        public IReadOnlyList<EdgeOrderProductImageInformation> ImageInformation { get; }
        /// <summary> Cost information for the product system. </summary>
        public EdgeOrderProductCostInformation CostInformation { get; }
        /// <summary> Availability information of the product system. </summary>
        public ProductAvailabilityInformation AvailabilityInformation { get; }
        /// <summary> Hierarchy information of a product. </summary>
        public HierarchyInformation HierarchyInformation { get; }
        /// <summary> list of filters supported for a product. </summary>
        public IReadOnlyList<FilterableProperty> FilterableProperties { get; }
        /// <summary> List of configurations for the product. </summary>
        public IReadOnlyList<ProductConfiguration> Configurations { get; }
    }
}

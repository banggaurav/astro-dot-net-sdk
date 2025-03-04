// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeShareData : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeShareData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeShareData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeShareData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeShareData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeShareData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("shareStatus"u8);
            writer.WriteStringValue(ShareStatus.ToString());
            writer.WritePropertyName("monitoringStatus"u8);
            writer.WriteStringValue(MonitoringStatus.ToString());
            if (Optional.IsDefined(AzureContainerInfo))
            {
                writer.WritePropertyName("azureContainerInfo"u8);
                writer.WriteObjectValue(AzureContainerInfo);
            }
            writer.WritePropertyName("accessProtocol"u8);
            writer.WriteStringValue(AccessProtocol.ToString());
            if (Optional.IsCollectionDefined(UserAccessRights))
            {
                writer.WritePropertyName("userAccessRights"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccessRights)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientAccessRights))
            {
                writer.WritePropertyName("clientAccessRights"u8);
                writer.WriteStartArray();
                foreach (var item in ClientAccessRights)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RefreshDetails))
            {
                writer.WritePropertyName("refreshDetails"u8);
                writer.WriteObjectValue(RefreshDetails);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ShareMappings))
            {
                writer.WritePropertyName("shareMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ShareMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DataPolicy))
            {
                writer.WritePropertyName("dataPolicy"u8);
                writer.WriteStringValue(DataPolicy.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataBoxEdgeShareData IJsonModel<DataBoxEdgeShareData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeShareData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeShareData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeShareData(document.RootElement, options);
        }

        internal static DataBoxEdgeShareData DeserializeDataBoxEdgeShareData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            ShareStatus shareStatus = default;
            DataBoxEdgeShareMonitoringStatus monitoringStatus = default;
            Optional<DataBoxEdgeStorageContainerInfo> azureContainerInfo = default;
            ShareAccessProtocol accessProtocol = default;
            Optional<IList<UserAccessRight>> userAccessRights = default;
            Optional<IList<ClientAccessRight>> clientAccessRights = default;
            Optional<DataBoxEdgeRefreshDetails> refreshDetails = default;
            Optional<IReadOnlyList<DataBoxEdgeMountPointMap>> shareMappings = default;
            Optional<DataBoxEdgeDataPolicy> dataPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareStatus"u8))
                        {
                            shareStatus = new ShareStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitoringStatus"u8))
                        {
                            monitoringStatus = new DataBoxEdgeShareMonitoringStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureContainerInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureContainerInfo = DataBoxEdgeStorageContainerInfo.DeserializeDataBoxEdgeStorageContainerInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessProtocol"u8))
                        {
                            accessProtocol = new ShareAccessProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userAccessRights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<UserAccessRight> array = new List<UserAccessRight>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UserAccessRight.DeserializeUserAccessRight(item));
                            }
                            userAccessRights = array;
                            continue;
                        }
                        if (property0.NameEquals("clientAccessRights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClientAccessRight> array = new List<ClientAccessRight>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClientAccessRight.DeserializeClientAccessRight(item));
                            }
                            clientAccessRights = array;
                            continue;
                        }
                        if (property0.NameEquals("refreshDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshDetails = DataBoxEdgeRefreshDetails.DeserializeDataBoxEdgeRefreshDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shareMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeMountPointMap> array = new List<DataBoxEdgeMountPointMap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeMountPointMap.DeserializeDataBoxEdgeMountPointMap(item));
                            }
                            shareMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("dataPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataPolicy = new DataBoxEdgeDataPolicy(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeShareData(id, name, type, systemData.Value, description.Value, shareStatus, monitoringStatus, azureContainerInfo.Value, accessProtocol, Optional.ToList(userAccessRights), Optional.ToList(clientAccessRights), refreshDetails.Value, Optional.ToList(shareMappings), Optional.ToNullable(dataPolicy), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeShareData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeShareData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeShareData)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeShareData IPersistableModel<DataBoxEdgeShareData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeShareData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeShareData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeShareData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeShareData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

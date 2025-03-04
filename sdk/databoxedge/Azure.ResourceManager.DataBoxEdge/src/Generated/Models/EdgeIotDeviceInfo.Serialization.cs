// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotDeviceInfo : IUtf8JsonSerializable, IJsonModel<EdgeIotDeviceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeIotDeviceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeIotDeviceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotDeviceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotDeviceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("deviceId"u8);
            writer.WriteStringValue(DeviceId);
            writer.WritePropertyName("ioTHostHub"u8);
            writer.WriteStringValue(IotHostHub);
            if (Optional.IsDefined(IotHostHubId))
            {
                writer.WritePropertyName("ioTHostHubId"u8);
                writer.WriteStringValue(IotHostHubId);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
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

        EdgeIotDeviceInfo IJsonModel<EdgeIotDeviceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotDeviceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotDeviceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeIotDeviceInfo(document.RootElement, options);
        }

        internal static EdgeIotDeviceInfo DeserializeEdgeIotDeviceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceId = default;
            string iotHostHub = default;
            Optional<ResourceIdentifier> iotHostHubId = default;
            Optional<Authentication> authentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHub"u8))
                {
                    iotHostHub = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHubId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iotHostHubId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = Authentication.DeserializeAuthentication(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeIotDeviceInfo(deviceId, iotHostHub, iotHostHubId.Value, authentication.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeIotDeviceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotDeviceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeIotDeviceInfo)} does not support '{options.Format}' format.");
            }
        }

        EdgeIotDeviceInfo IPersistableModel<EdgeIotDeviceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotDeviceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeIotDeviceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeIotDeviceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeIotDeviceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

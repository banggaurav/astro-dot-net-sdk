// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnLinkProviderProperties : IUtf8JsonSerializable, IJsonModel<VpnLinkProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnLinkProviderProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnLinkProviderProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnLinkProviderProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkProviderName))
            {
                writer.WritePropertyName("linkProviderName"u8);
                writer.WriteStringValue(LinkProviderName);
            }
            if (Optional.IsDefined(LinkSpeedInMbps))
            {
                writer.WritePropertyName("linkSpeedInMbps"u8);
                writer.WriteNumberValue(LinkSpeedInMbps.Value);
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

        VpnLinkProviderProperties IJsonModel<VpnLinkProviderProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnLinkProviderProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnLinkProviderProperties(document.RootElement, options);
        }

        internal static VpnLinkProviderProperties DeserializeVpnLinkProviderProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> linkProviderName = default;
            Optional<int> linkSpeedInMbps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkProviderName"u8))
                {
                    linkProviderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeedInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkSpeedInMbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnLinkProviderProperties(linkProviderName.Value, Optional.ToNullable(linkSpeedInMbps), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnLinkProviderProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnLinkProviderProperties)} does not support '{options.Format}' format.");
            }
        }

        VpnLinkProviderProperties IPersistableModel<VpnLinkProviderProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnLinkProviderProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnLinkProviderProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnLinkProviderProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

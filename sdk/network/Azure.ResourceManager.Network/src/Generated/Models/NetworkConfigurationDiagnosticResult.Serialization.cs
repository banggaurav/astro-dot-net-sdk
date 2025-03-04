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
    public partial class NetworkConfigurationDiagnosticResult : IUtf8JsonSerializable, IJsonModel<NetworkConfigurationDiagnosticResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkConfigurationDiagnosticResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkConfigurationDiagnosticResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkConfigurationDiagnosticResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkConfigurationDiagnosticResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile);
            }
            if (Optional.IsDefined(NetworkSecurityGroupResult))
            {
                writer.WritePropertyName("networkSecurityGroupResult"u8);
                writer.WriteObjectValue(NetworkSecurityGroupResult);
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

        NetworkConfigurationDiagnosticResult IJsonModel<NetworkConfigurationDiagnosticResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkConfigurationDiagnosticResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkConfigurationDiagnosticResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkConfigurationDiagnosticResult(document.RootElement, options);
        }

        internal static NetworkConfigurationDiagnosticResult DeserializeNetworkConfigurationDiagnosticResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkConfigurationDiagnosticProfile> profile = default;
            Optional<NetworkSecurityGroupResult> networkSecurityGroupResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = NetworkConfigurationDiagnosticProfile.DeserializeNetworkConfigurationDiagnosticProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityGroupResult = NetworkSecurityGroupResult.DeserializeNetworkSecurityGroupResult(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkConfigurationDiagnosticResult(profile.Value, networkSecurityGroupResult.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkConfigurationDiagnosticResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkConfigurationDiagnosticResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkConfigurationDiagnosticResult)} does not support '{options.Format}' format.");
            }
        }

        NetworkConfigurationDiagnosticResult IPersistableModel<NetworkConfigurationDiagnosticResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkConfigurationDiagnosticResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkConfigurationDiagnosticResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkConfigurationDiagnosticResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkConfigurationDiagnosticResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownMonitoringFeatureFilterBase : IUtf8JsonSerializable, IJsonModel<MonitoringFeatureFilterBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringFeatureFilterBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringFeatureFilterBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringFeatureFilterBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringFeatureFilterBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("filterType"u8);
            writer.WriteStringValue(FilterType.ToString());
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

        MonitoringFeatureFilterBase IJsonModel<MonitoringFeatureFilterBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringFeatureFilterBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringFeatureFilterBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownMonitoringFeatureFilterBase(document.RootElement, options);
        }

        internal static UnknownMonitoringFeatureFilterBase DeserializeUnknownMonitoringFeatureFilterBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoringFeatureFilterType filterType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterType"u8))
                {
                    filterType = new MonitoringFeatureFilterType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownMonitoringFeatureFilterBase(filterType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoringFeatureFilterBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringFeatureFilterBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringFeatureFilterBase)} does not support '{options.Format}' format.");
            }
        }

        MonitoringFeatureFilterBase IPersistableModel<MonitoringFeatureFilterBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringFeatureFilterBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownMonitoringFeatureFilterBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoringFeatureFilterBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringFeatureFilterBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

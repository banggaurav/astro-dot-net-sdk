// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsSearchSchemaValue : IUtf8JsonSerializable, IJsonModel<OperationalInsightsSearchSchemaValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsSearchSchemaValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsSearchSchemaValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsSearchSchemaValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsSearchSchemaValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(SearchSchemaValueType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SearchSchemaValueType);
            }
            writer.WritePropertyName("indexed"u8);
            writer.WriteBooleanValue(Indexed);
            writer.WritePropertyName("stored"u8);
            writer.WriteBooleanValue(Stored);
            writer.WritePropertyName("facet"u8);
            writer.WriteBooleanValue(Facet);
            if (Optional.IsCollectionDefined(OwnerType))
            {
                writer.WritePropertyName("ownerType"u8);
                writer.WriteStartArray();
                foreach (var item in OwnerType)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        OperationalInsightsSearchSchemaValue IJsonModel<OperationalInsightsSearchSchemaValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsSearchSchemaValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsSearchSchemaValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsSearchSchemaValue(document.RootElement, options);
        }

        internal static OperationalInsightsSearchSchemaValue DeserializeOperationalInsightsSearchSchemaValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> type = default;
            bool indexed = default;
            bool stored = default;
            bool facet = default;
            Optional<IReadOnlyList<string>> ownerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexed"u8))
                {
                    indexed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stored"u8))
                {
                    stored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facet"u8))
                {
                    facet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ownerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ownerType = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsSearchSchemaValue(name.Value, displayName.Value, type.Value, indexed, stored, facet, Optional.ToList(ownerType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsSearchSchemaValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsSearchSchemaValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsSearchSchemaValue)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsSearchSchemaValue IPersistableModel<OperationalInsightsSearchSchemaValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsSearchSchemaValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsSearchSchemaValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsSearchSchemaValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsSearchSchemaValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ThreeTierFullResourceNames : IUtf8JsonSerializable, IJsonModel<ThreeTierFullResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreeTierFullResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreeTierFullResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreeTierFullResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CentralServer))
            {
                writer.WritePropertyName("centralServer"u8);
                writer.WriteObjectValue(CentralServer);
            }
            if (Optional.IsDefined(ApplicationServer))
            {
                writer.WritePropertyName("applicationServer"u8);
                writer.WriteObjectValue(ApplicationServer);
            }
            if (Optional.IsDefined(DatabaseServer))
            {
                writer.WritePropertyName("databaseServer"u8);
                writer.WriteObjectValue(DatabaseServer);
            }
            if (Optional.IsDefined(SharedStorage))
            {
                writer.WritePropertyName("sharedStorage"u8);
                writer.WriteObjectValue(SharedStorage);
            }
            writer.WritePropertyName("namingPatternType"u8);
            writer.WriteStringValue(NamingPatternType.ToString());
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

        ThreeTierFullResourceNames IJsonModel<ThreeTierFullResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreeTierFullResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreeTierFullResourceNames(document.RootElement, options);
        }

        internal static ThreeTierFullResourceNames DeserializeThreeTierFullResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CentralServerFullResourceNames> centralServer = default;
            Optional<ApplicationServerFullResourceNames> applicationServer = default;
            Optional<DatabaseServerFullResourceNames> databaseServer = default;
            Optional<SharedStorageResourceNames> sharedStorage = default;
            SapNamingPatternType namingPatternType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("centralServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    centralServer = CentralServerFullResourceNames.DeserializeCentralServerFullResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationServer = ApplicationServerFullResourceNames.DeserializeApplicationServerFullResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseServer = DatabaseServerFullResourceNames.DeserializeDatabaseServerFullResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("sharedStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharedStorage = SharedStorageResourceNames.DeserializeSharedStorageResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("namingPatternType"u8))
                {
                    namingPatternType = new SapNamingPatternType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreeTierFullResourceNames(namingPatternType, serializedAdditionalRawData, centralServer.Value, applicationServer.Value, databaseServer.Value, sharedStorage.Value);
        }

        BinaryData IPersistableModel<ThreeTierFullResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreeTierFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        ThreeTierFullResourceNames IPersistableModel<ThreeTierFullResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreeTierFullResourceNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreeTierFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreeTierFullResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

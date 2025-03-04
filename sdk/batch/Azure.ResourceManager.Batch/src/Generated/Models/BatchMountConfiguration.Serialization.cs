// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchMountConfiguration : IUtf8JsonSerializable, IJsonModel<BatchMountConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchMountConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchMountConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchMountConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BlobFileSystemConfiguration))
            {
                writer.WritePropertyName("azureBlobFileSystemConfiguration"u8);
                writer.WriteObjectValue(BlobFileSystemConfiguration);
            }
            if (Optional.IsDefined(NfsMountConfiguration))
            {
                writer.WritePropertyName("nfsMountConfiguration"u8);
                writer.WriteObjectValue(NfsMountConfiguration);
            }
            if (Optional.IsDefined(CifsMountConfiguration))
            {
                writer.WritePropertyName("cifsMountConfiguration"u8);
                writer.WriteObjectValue(CifsMountConfiguration);
            }
            if (Optional.IsDefined(FileShareConfiguration))
            {
                writer.WritePropertyName("azureFileShareConfiguration"u8);
                writer.WriteObjectValue(FileShareConfiguration);
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

        BatchMountConfiguration IJsonModel<BatchMountConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchMountConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchMountConfiguration(document.RootElement, options);
        }

        internal static BatchMountConfiguration DeserializeBatchMountConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchBlobFileSystemConfiguration> azureBlobFileSystemConfiguration = default;
            Optional<BatchNfsMountConfiguration> nfsMountConfiguration = default;
            Optional<BatchCifsMountConfiguration> cifsMountConfiguration = default;
            Optional<BatchFileShareConfiguration> azureFileShareConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBlobFileSystemConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileSystemConfiguration = BatchBlobFileSystemConfiguration.DeserializeBatchBlobFileSystemConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nfsMountConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfsMountConfiguration = BatchNfsMountConfiguration.DeserializeBatchNfsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cifsMountConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cifsMountConfiguration = BatchCifsMountConfiguration.DeserializeBatchCifsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileShareConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareConfiguration = BatchFileShareConfiguration.DeserializeBatchFileShareConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchMountConfiguration(azureBlobFileSystemConfiguration.Value, nfsMountConfiguration.Value, cifsMountConfiguration.Value, azureFileShareConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchMountConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchMountConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchMountConfiguration IPersistableModel<BatchMountConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchMountConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchMountConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchMountConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

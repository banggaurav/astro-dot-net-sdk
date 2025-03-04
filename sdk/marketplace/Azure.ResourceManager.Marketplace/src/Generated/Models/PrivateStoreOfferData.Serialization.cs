// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreOfferData : IUtf8JsonSerializable, IJsonModel<PrivateStoreOfferData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStoreOfferData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateStoreOfferData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreOfferData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreOfferData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(UniqueOfferId))
            {
                writer.WritePropertyName("uniqueOfferId"u8);
                writer.WriteStringValue(UniqueOfferId);
            }
            if (options.Format != "W" && Optional.IsDefined(OfferDisplayName))
            {
                writer.WritePropertyName("offerDisplayName"u8);
                writer.WriteStringValue(OfferDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherDisplayName))
            {
                writer.WritePropertyName("publisherDisplayName"u8);
                writer.WriteStringValue(PublisherDisplayName);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateStoreId))
            {
                writer.WritePropertyName("privateStoreId"u8);
                writer.WriteStringValue(PrivateStoreId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedAt"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(SpecificPlanIdsLimitation))
            {
                writer.WritePropertyName("specificPlanIdsLimitation"u8);
                writer.WriteStartArray();
                foreach (var item in SpecificPlanIdsLimitation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsUpdateSuppressedDueToIdempotence))
            {
                writer.WritePropertyName("updateSuppressedDueIdempotence"u8);
                writer.WriteBooleanValue(IsUpdateSuppressedDueToIdempotence.Value);
            }
            if (Optional.IsCollectionDefined(IconFileUris))
            {
                writer.WritePropertyName("iconFileUris"u8);
                writer.WriteStartObject();
                foreach (var item in IconFileUris)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value.AbsoluteUri);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PrivateStoreOfferData IJsonModel<PrivateStoreOfferData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreOfferData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreOfferData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreOfferData(document.RootElement, options);
        }

        internal static PrivateStoreOfferData DeserializePrivateStoreOfferData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> uniqueOfferId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherDisplayName = default;
            Optional<ETag> eTag = default;
            Optional<Guid> privateStoreId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<IList<string>> specificPlanIdsLimitation = default;
            Optional<bool> updateSuppressedDueIdempotence = default;
            Optional<IDictionary<string, Uri>> iconFileUris = default;
            Optional<IList<PrivateStorePlan>> plans = default;
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
                        if (property0.NameEquals("uniqueOfferId"u8))
                        {
                            uniqueOfferId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerDisplayName"u8))
                        {
                            offerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherDisplayName"u8))
                        {
                            publisherDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eTag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateStoreId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("specificPlanIdsLimitation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            specificPlanIdsLimitation = array;
                            continue;
                        }
                        if (property0.NameEquals("updateSuppressedDueIdempotence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateSuppressedDueIdempotence = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconFileUris"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, Uri> dictionary = new Dictionary<string, Uri>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, new Uri(property1.Value.GetString()));
                                }
                            }
                            iconFileUris = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("plans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateStorePlan> array = new List<PrivateStorePlan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateStorePlan.DeserializePrivateStorePlan(item));
                            }
                            plans = array;
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
            return new PrivateStoreOfferData(id, name, type, systemData.Value, uniqueOfferId.Value, offerDisplayName.Value, publisherDisplayName.Value, Optional.ToNullable(eTag), Optional.ToNullable(privateStoreId), Optional.ToNullable(createdAt), Optional.ToNullable(modifiedAt), Optional.ToList(specificPlanIdsLimitation), Optional.ToNullable(updateSuppressedDueIdempotence), Optional.ToDictionary(iconFileUris), Optional.ToList(plans), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStoreOfferData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreOfferData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreOfferData)} does not support '{options.Format}' format.");
            }
        }

        PrivateStoreOfferData IPersistableModel<PrivateStoreOfferData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreOfferData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateStoreOfferData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreOfferData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateStoreOfferData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

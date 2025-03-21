// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzurePostgreSqlLinkedServiceConverter))]
    public partial class AzurePostgreSqlLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteObjectValue<object>(ConnectionString);
            }
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                writer.WriteObjectValue<object>(Server);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteObjectValue<object>(Port);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteObjectValue<object>(Username);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteObjectValue<object>(Database);
            }
            if (Optional.IsDefined(SslMode))
            {
                writer.WritePropertyName("sslMode"u8);
                writer.WriteObjectValue<object>(SslMode);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteObjectValue<object>(Timeout);
            }
            if (Optional.IsDefined(CommandTimeout))
            {
                writer.WritePropertyName("commandTimeout"u8);
                writer.WriteObjectValue<object>(CommandTimeout);
            }
            if (Optional.IsDefined(TrustServerCertificate))
            {
                writer.WritePropertyName("trustServerCertificate"u8);
                writer.WriteObjectValue<object>(TrustServerCertificate);
            }
            if (Optional.IsDefined(ReadBufferSize))
            {
                writer.WritePropertyName("readBufferSize"u8);
                writer.WriteObjectValue<object>(ReadBufferSize);
            }
            if (Optional.IsDefined(Timezone))
            {
                writer.WritePropertyName("timezone"u8);
                writer.WriteObjectValue<object>(Timezone);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteObjectValue<object>(Encoding);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue<object>(EncryptedCredential);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue<object>(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            if (Optional.IsDefined(ServicePrincipalCredentialType))
            {
                writer.WritePropertyName("servicePrincipalCredentialType"u8);
                writer.WriteObjectValue<object>(ServicePrincipalCredentialType);
            }
            if (Optional.IsDefined(ServicePrincipalEmbeddedCert))
            {
                writer.WritePropertyName("servicePrincipalEmbeddedCert"u8);
                writer.WriteObjectValue(ServicePrincipalEmbeddedCert);
            }
            if (Optional.IsDefined(ServicePrincipalEmbeddedCertPassword))
            {
                writer.WritePropertyName("servicePrincipalEmbeddedCertPassword"u8);
                writer.WriteObjectValue(ServicePrincipalEmbeddedCertPassword);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                writer.WriteObjectValue<object>(Tenant);
            }
            if (Optional.IsDefined(AzureCloudType))
            {
                writer.WritePropertyName("azureCloudType"u8);
                writer.WriteObjectValue<object>(AzureCloudType);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzurePostgreSqlLinkedService DeserializeAzurePostgreSqlLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string version = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object connectionString = default;
            object server = default;
            object port = default;
            object username = default;
            object database = default;
            object sslMode = default;
            object timeout = default;
            object commandTimeout = default;
            object trustServerCertificate = default;
            object readBufferSize = default;
            object timezone = default;
            object encoding = default;
            AzureKeyVaultSecretReference password = default;
            object encryptedCredential = default;
            object servicePrincipalId = default;
            SecretBase servicePrincipalKey = default;
            object servicePrincipalCredentialType = default;
            SecretBase servicePrincipalEmbeddedCert = default;
            SecretBase servicePrincipalEmbeddedCertPassword = default;
            object tenant = default;
            object azureCloudType = default;
            CredentialReference credential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("connectionString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionString = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("server"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            server = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            database = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sslMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sslMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("commandTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commandTimeout = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustServerCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustServerCertificate = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("readBufferSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readBufferSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timezone"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timezone = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encoding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encoding = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = AzureKeyVaultSecretReference.DeserializeAzureKeyVaultSecretReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredentialType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredentialType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalEmbeddedCert"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalEmbeddedCert = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalEmbeddedCertPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalEmbeddedCertPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCloudType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzurePostgreSqlLinkedService(
                type,
                version,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                connectionString,
                server,
                port,
                username,
                database,
                sslMode,
                timeout,
                commandTimeout,
                trustServerCertificate,
                readBufferSize,
                timezone,
                encoding,
                password,
                encryptedCredential,
                servicePrincipalId,
                servicePrincipalKey,
                servicePrincipalCredentialType,
                servicePrincipalEmbeddedCert,
                servicePrincipalEmbeddedCertPassword,
                tenant,
                azureCloudType,
                credential);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AzurePostgreSqlLinkedService FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAzurePostgreSqlLinkedService(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class AzurePostgreSqlLinkedServiceConverter : JsonConverter<AzurePostgreSqlLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, AzurePostgreSqlLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override AzurePostgreSqlLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzurePostgreSqlLinkedService(document.RootElement);
            }
        }
    }
}

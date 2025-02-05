// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegistryListCredentialsResult
    {
        internal static RegistryListCredentialsResult DeserializeRegistryListCredentialsResult(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<string> username = default;
            Optional<IReadOnlyList<PasswordDetail>> passwords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("passwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PasswordDetail> array = new List<PasswordDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PasswordDetail.DeserializePasswordDetail(item));
                    }
                    passwords = array;
                    continue;
                }
            }
            return new RegistryListCredentialsResult(Optional.ToNullable(location), username.Value, Optional.ToList(passwords));
        }
    }
}

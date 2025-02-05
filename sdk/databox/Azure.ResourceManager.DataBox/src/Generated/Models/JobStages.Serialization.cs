// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class JobStages
    {
        internal static JobStages DeserializeJobStages(JsonElement element)
        {
            Optional<StageName> stageName = default;
            Optional<string> displayName = default;
            Optional<StageStatus> stageStatus = default;
            Optional<DateTimeOffset> stageTime = default;
            Optional<BinaryData> jobStageDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stageName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stageName = new StageName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stageStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stageStatus = property.Value.GetString().ToStageStatus();
                    continue;
                }
                if (property.NameEquals("stageTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stageTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobStageDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobStageDetails = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new JobStages(Optional.ToNullable(stageName), displayName.Value, Optional.ToNullable(stageStatus), Optional.ToNullable(stageTime), jobStageDetails.Value);
        }
    }
}

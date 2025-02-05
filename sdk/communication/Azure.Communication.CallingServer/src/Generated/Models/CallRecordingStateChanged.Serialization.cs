// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallRecordingStateChanged
    {
        internal static CallRecordingStateChanged DeserializeCallRecordingStateChanged(JsonElement element)
        {
            Optional<AcsEventType> type = default;
            Optional<string> recordingId = default;
            Optional<RecordingState> state = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AcsEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recordingId"))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new RecordingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
            }
            return new CallRecordingStateChanged(type, recordingId.Value, state, Optional.ToNullable(startDateTime), callConnectionId.Value, serverCallId.Value, correlationId.Value);
        }
    }
}

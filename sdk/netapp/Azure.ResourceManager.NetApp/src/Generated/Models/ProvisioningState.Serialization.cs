// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NetApp.Models
{
    internal static partial class ProvisioningStateExtensions
    {
        public static string ToSerialString(this ProvisioningState value) => value switch
        {
            ProvisioningState.Accepted => "Accepted",
            ProvisioningState.Creating => "Creating",
            ProvisioningState.Patching => "Patching",
            ProvisioningState.Deleting => "Deleting",
            ProvisioningState.Moving => "Moving",
            ProvisioningState.Failed => "Failed",
            ProvisioningState.Succeeded => "Succeeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.")
        };

        public static ProvisioningState ToProvisioningState(this string value)
        {
            if (string.Equals(value, "Accepted", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Accepted;
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Creating;
            if (string.Equals(value, "Patching", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Patching;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Deleting;
            if (string.Equals(value, "Moving", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Moving;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Failed;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Succeeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.");
        }
    }
}

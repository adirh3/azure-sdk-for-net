// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Schedule. </summary>
    public readonly partial struct ReplicationSchedule : IEquatable<ReplicationSchedule>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicationSchedule"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicationSchedule(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string _10MinutelyValue = "_10minutely";
        private const string HourlyValue = "hourly";
        private const string DailyValue = "daily";

        /// <summary> _10minutely. </summary>
        public static ReplicationSchedule _10Minutely { get; } = new ReplicationSchedule(_10MinutelyValue);
        /// <summary> hourly. </summary>
        public static ReplicationSchedule Hourly { get; } = new ReplicationSchedule(HourlyValue);
        /// <summary> daily. </summary>
        public static ReplicationSchedule Daily { get; } = new ReplicationSchedule(DailyValue);
        /// <summary> Determines if two <see cref="ReplicationSchedule"/> values are the same. </summary>
        public static bool operator ==(ReplicationSchedule left, ReplicationSchedule right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationSchedule"/> values are not the same. </summary>
        public static bool operator !=(ReplicationSchedule left, ReplicationSchedule right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationSchedule"/>. </summary>
        public static implicit operator ReplicationSchedule(string value) => new ReplicationSchedule(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationSchedule other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationSchedule other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct DevCenterNameUnavailableReason : IEquatable<DevCenterNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static DevCenterNameUnavailableReason Invalid { get; } = new DevCenterNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static DevCenterNameUnavailableReason AlreadyExists { get; } = new DevCenterNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="DevCenterNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(DevCenterNameUnavailableReason left, DevCenterNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(DevCenterNameUnavailableReason left, DevCenterNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevCenterNameUnavailableReason"/>. </summary>
        public static implicit operator DevCenterNameUnavailableReason(string value) => new DevCenterNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Option indicating enforcement of peerings created by the connectivity configuration. </summary>
    public readonly partial struct PeeringEnforcement : IEquatable<PeeringEnforcement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringEnforcement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringEnforcement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnenforcedValue = "Unenforced";
        private const string EnforcedValue = "Enforced";

        /// <summary> Default. Peerings created by the connectivity configuration may be modified or deleted outside of the network manager. </summary>
        public static PeeringEnforcement Unenforced { get; } = new PeeringEnforcement(UnenforcedValue);
        /// <summary> Peerings created by the connectivity configuration will not be modifiable or deletable outside of the network manager. </summary>
        public static PeeringEnforcement Enforced { get; } = new PeeringEnforcement(EnforcedValue);
        /// <summary> Determines if two <see cref="PeeringEnforcement"/> values are the same. </summary>
        public static bool operator ==(PeeringEnforcement left, PeeringEnforcement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringEnforcement"/> values are not the same. </summary>
        public static bool operator !=(PeeringEnforcement left, PeeringEnforcement right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PeeringEnforcement"/>. </summary>
        public static implicit operator PeeringEnforcement(string value) => new PeeringEnforcement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringEnforcement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringEnforcement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

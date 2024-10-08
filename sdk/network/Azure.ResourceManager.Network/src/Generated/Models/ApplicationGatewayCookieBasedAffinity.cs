// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Cookie based affinity. </summary>
    public readonly partial struct ApplicationGatewayCookieBasedAffinity : IEquatable<ApplicationGatewayCookieBasedAffinity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayCookieBasedAffinity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayCookieBasedAffinity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ApplicationGatewayCookieBasedAffinity Enabled { get; } = new ApplicationGatewayCookieBasedAffinity(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ApplicationGatewayCookieBasedAffinity Disabled { get; } = new ApplicationGatewayCookieBasedAffinity(DisabledValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayCookieBasedAffinity"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayCookieBasedAffinity left, ApplicationGatewayCookieBasedAffinity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayCookieBasedAffinity"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayCookieBasedAffinity left, ApplicationGatewayCookieBasedAffinity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewayCookieBasedAffinity"/>. </summary>
        public static implicit operator ApplicationGatewayCookieBasedAffinity(string value) => new ApplicationGatewayCookieBasedAffinity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayCookieBasedAffinity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayCookieBasedAffinity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

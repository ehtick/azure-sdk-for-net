// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The offer type for the Cosmos DB database account. </summary>
    public readonly partial struct CosmosDBAccountOfferType : IEquatable<CosmosDBAccountOfferType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountOfferType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBAccountOfferType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";

        /// <summary> Standard. </summary>
        public static CosmosDBAccountOfferType Standard { get; } = new CosmosDBAccountOfferType(StandardValue);
        /// <summary> Determines if two <see cref="CosmosDBAccountOfferType"/> values are the same. </summary>
        public static bool operator ==(CosmosDBAccountOfferType left, CosmosDBAccountOfferType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBAccountOfferType"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBAccountOfferType left, CosmosDBAccountOfferType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CosmosDBAccountOfferType"/>. </summary>
        public static implicit operator CosmosDBAccountOfferType(string value) => new CosmosDBAccountOfferType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBAccountOfferType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBAccountOfferType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

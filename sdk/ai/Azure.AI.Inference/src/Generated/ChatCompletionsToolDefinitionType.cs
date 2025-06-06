// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Inference
{
    /// <summary> The ChatCompletionsToolDefinitionType. </summary>
    public readonly partial struct ChatCompletionsToolDefinitionType : IEquatable<ChatCompletionsToolDefinitionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsToolDefinitionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChatCompletionsToolDefinitionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        /// <summary> function. </summary>
        public static ChatCompletionsToolDefinitionType Function { get; } = new ChatCompletionsToolDefinitionType(FunctionValue);
        /// <summary> Determines if two <see cref="ChatCompletionsToolDefinitionType"/> values are the same. </summary>
        public static bool operator ==(ChatCompletionsToolDefinitionType left, ChatCompletionsToolDefinitionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChatCompletionsToolDefinitionType"/> values are not the same. </summary>
        public static bool operator !=(ChatCompletionsToolDefinitionType left, ChatCompletionsToolDefinitionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ChatCompletionsToolDefinitionType"/>. </summary>
        public static implicit operator ChatCompletionsToolDefinitionType(string value) => new ChatCompletionsToolDefinitionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatCompletionsToolDefinitionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChatCompletionsToolDefinitionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

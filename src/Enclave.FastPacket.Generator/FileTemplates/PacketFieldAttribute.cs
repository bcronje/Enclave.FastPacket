﻿// <auto-generated />
using System;

namespace Enclave.FastPacket.Generator
{
    /// <summary>
    /// Allows a field to occupy only a subset of bits within the read value.
    /// Bit numbers are specified using MSB 0 bit-numbering, to match most network packet RFCs.
    /// </summary>
    /// <remarks>
    /// <code>
    /// Whenever an octet represents a numeric quantity the left most bit in
    /// the diagram is the high order or most significant bit.That is, the
    /// bit labeled 0 is the most significant bit.For example, the following
    /// diagram represents the value 170 (decimal).
    ///
    ///
    ///                0 1 2 3 4 5 6 7
    ///               +-+-+-+-+-+-+-+-+
    ///               |1 0 1 0 1 0 1 0|
    ///               +-+-+-+-+-+-+-+-+
    ///
    ///              Significance of Bits
    ///
    /// Similarly, whenever a multi-octet field represents a numeric quantity
    /// the left most bit of the whole field is the most significant bit.
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct)]
    internal sealed class PacketFieldBitsAttribute : Attribute
    {
        /// <summary>
        /// Define a packet field that consumes only a specified set of bits within the read value.
        /// Bit numbers are specified using MSB 0 bit-numbering, to match most network packet RFCs.
        /// </summary>
        /// <param name="firstBit">The first bit to include in the value (e.g. 0)</param>
        /// <param name="lastBit">The last bit to include in the value (e.g. 7)</param>
        public PacketFieldBitsAttribute(uint firstBit, uint lastBit)
        {
            FirstBit = firstBit;
            LastBit = lastBit;
        }

        public uint FirstBit { get; }

        public uint LastBit { get; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct)]
    internal sealed class PacketFieldAttribute : Attribute
    {
        /// <summary>
        /// Create a new <see cref="PacketFieldAttribute"/>. Customise the
        /// field using named arguments.
        /// </summary>
        public PacketFieldAttribute()
        {
        }

        public int Size { get; set; }

        public int Position { get; set; }

        public string? PositionFunction { get; set; }

        public Type? EnumBackingType { get; set; }

        public ulong Bitmask { get; set; }

        public string? SizeFunction { get; set; }
    }
}

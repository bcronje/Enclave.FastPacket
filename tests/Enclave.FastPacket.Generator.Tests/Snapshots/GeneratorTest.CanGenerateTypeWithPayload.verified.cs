﻿//HintName: T.PacketParser_Generated.cs
// <auto-generated />

using System;
using System.Buffers.Binary;

namespace T
{
    readonly ref partial struct PacketParser
    {
        private readonly Span<byte> _span;

        /// <summary>
        /// Defines the minimum possible size of this packet, given all
        /// known fixed sizes.
        /// </summary>
        public const int MinimumSize = sizeof(int);

        /// <summary>
        /// Create a new instance of <see cref="PacketParser"/>.
        /// </summary>
        public PacketParser(Span<byte> packetData)
        {
            _span = packetData;
        }

        /// <summary>
        /// Gets the raw underlying buffer for this packet.
        /// </summary>
        public Span<byte> GetRawData() => _span;
        
        
        public int Value1
        {
           get => BinaryPrimitives.ReadInt32BigEndian(_span.Slice(0));
           set => BinaryPrimitives.WriteInt32BigEndian(_span.Slice(0), value); 
        }
        
        
        public System.Span<byte> Payload
        {
           get => _span.Slice(0 + sizeof(int));
        }
        
        /// <summary>
        /// Get a string representation of this packet.
        /// </summary>
        public override string ToString()
        {
            return $"Value1: {Value1}; Payload: {Payload.Length} bytes";
        }

        /// <summary>
        /// Get the computed total size of this packet, including any dynamically-sized fields and trailing payloads.
        /// </summary>
        public int GetTotalSize()
        {
            return 0 + sizeof(int) + _span.Slice(0 + sizeof(int)).Length;
        }
    }
}

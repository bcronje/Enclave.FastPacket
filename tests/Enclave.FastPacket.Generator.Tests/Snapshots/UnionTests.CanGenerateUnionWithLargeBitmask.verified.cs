﻿//HintName: T.ValueItem_Generated.cs
// <auto-generated />

using System;
using System.Buffers.Binary;

namespace T
{
    readonly ref partial struct ValueItem
    {
        private readonly Span<byte> _span;

        /// <summary>
        /// Defines the minimum possible size of this packet, given all
        /// known fixed sizes.
        /// </summary>
        public const int MinimumSize = sizeof(ushort) + 2 + sizeof(ushort);

        /// <summary>
        /// Create a new instance of <see cref="ValueItem"/>.
        /// </summary>
        public ValueItem(Span<byte> packetData)
        {
            _span = packetData;
        }

        /// <summary>
        /// Gets the raw underlying buffer for this packet.
        /// </summary>
        public Span<byte> GetRawData() => _span;
        
        
        public ushort Value
        {
           get => BinaryPrimitives.ReadUInt16BigEndian(_span.Slice(0));
           set => BinaryPrimitives.WriteUInt16BigEndian(_span.Slice(0), value); 
        }
        
        
        public T.FragmentFlags Flags
        {
           get => (T.FragmentFlags)((byte)((_span[0 + sizeof(ushort)] & 0xE0u) >> 5));
           set => _span[0 + sizeof(ushort)] = (byte)((((byte)(value) << 5) & 0xE0u) | (byte)(_span[0 + sizeof(ushort)] & ~0xE0u)); 
        }
        
        
        public ushort FragmentValue
        {
           get => (ushort)(BinaryPrimitives.ReadUInt16BigEndian(_span.Slice(0 + sizeof(ushort))) & 0x1FFFu);
           set => BinaryPrimitives.WriteUInt16BigEndian(_span.Slice(0 + sizeof(ushort)), (ushort)((value & 0x1FFFu) | (ushort)(BinaryPrimitives.ReadUInt16BigEndian(_span.Slice(0 + sizeof(ushort))) & ~0x1FFFu))); 
        }
        
        
        public ushort Value2
        {
           get => BinaryPrimitives.ReadUInt16BigEndian(_span.Slice(0 + sizeof(ushort) + 2));
           set => BinaryPrimitives.WriteUInt16BigEndian(_span.Slice(0 + sizeof(ushort) + 2), value); 
        }
        
        /// <summary>
        /// Get a string representation of this packet.
        /// </summary>
        public override string ToString()
        {
            return $"Value: {Value}; Flags: {Flags}; FragmentValue: {FragmentValue}; Value2: {Value2}";
        }

        /// <summary>
        /// Get the computed total size of this packet, including any dynamically-sized fields and trailing payloads.
        /// </summary>
        public int GetTotalSize()
        {
            return 0 + sizeof(ushort) + 2 + sizeof(ushort);
        }
    }
}

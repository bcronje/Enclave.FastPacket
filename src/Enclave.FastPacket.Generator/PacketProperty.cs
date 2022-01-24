﻿using System.Collections.Generic;
using Enclave.FastPacket.Generator.PositionProviders;
using Enclave.FastPacket.Generator.ValueProviders;

namespace Enclave.FastPacket.Generator
{
    internal class PacketProperty : IPacketProperty
    {
        public PacketProperty(
            string name,
            PacketFieldOptions options,
            IPositionProvider positionProvider,
            ISizeProvider sizeProvider,
            IValueProvider valueProvider,
            IEnumerable<string> docComments)
        {
            Name = name;
            PositionProvider = positionProvider;
            SizeProvider = sizeProvider;
            ValueProvider = valueProvider;
            DocComments = docComments;
        }

        public string Name { get; }

        public IPositionProvider PositionProvider { get; }

        public ISizeProvider SizeProvider { get; }

        public IValueProvider ValueProvider { get; }

        public IEnumerable<string> DocComments { get; }
    }
}

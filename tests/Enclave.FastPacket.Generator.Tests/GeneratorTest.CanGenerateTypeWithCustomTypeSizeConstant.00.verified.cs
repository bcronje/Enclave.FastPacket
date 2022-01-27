﻿//HintName: FastPacket_PacketImplementationAttribute.cs
// <auto-generated />

using System;

namespace Enclave.FastPacket.Generator
{
    [AttributeUsage(AttributeTargets.Struct)]
    internal sealed class PacketImplementationAttribute : Attribute
    {
        public PacketImplementationAttribute(Type type)
        {
        }

        public bool IsReadOnly { get; set; }

        public bool CacheAll { get; set; }
    }
}

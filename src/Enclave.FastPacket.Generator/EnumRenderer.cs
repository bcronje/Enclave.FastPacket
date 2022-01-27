﻿using System;

namespace Enclave.FastPacket.Generator;

internal static class EnumRenderer
{
    public static string RenderEnumToSource<TEnum>()
        where TEnum : struct
    {
        var typeInfo = typeof(TEnum);

        if (!typeInfo.IsEnum)
        {
            throw new ArgumentException("Can only generate source for enum types.");
        }

        return @$"
// <auto-generated />
namespace Enclave.FastPacket.Generator
{{
    internal enum {typeInfo.Name}
    {{
        {string.Join(",\n        ", Enum.GetNames(typeInfo))}
    }}
}}";
    }
}

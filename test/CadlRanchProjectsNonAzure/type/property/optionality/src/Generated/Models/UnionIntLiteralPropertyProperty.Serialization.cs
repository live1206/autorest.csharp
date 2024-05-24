// <auto-generated/>

#nullable disable

using System;

namespace Scm._Type.Property.Optionality.Models
{
    internal static partial class UnionIntLiteralPropertyPropertyExtensions
    {
        public static UnionIntLiteralPropertyProperty ToUnionIntLiteralPropertyProperty(this int value)
        {
            if (value == 1) return UnionIntLiteralPropertyProperty._1;
            if (value == 2) return UnionIntLiteralPropertyProperty._2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UnionIntLiteralPropertyProperty value.");
        }
    }
}
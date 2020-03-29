using System;
using System.Collections.Generic;
using System.Text;

namespace YamlToObject.Shared.Extensions
{
    public static class IntExtensions
    {
        public static Guid ToGuid(this int value)
        {
            return new Guid(value, (short)0, (short)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0);
        }
    }
}

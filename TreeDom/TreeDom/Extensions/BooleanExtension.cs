using System;

namespace TreeDom.Extensions
{
    public static class BooleanExtension
    {
        public static bool IfTrue(this bool value, Action act)
        {
            if (value) act();
            return value;
        }
        public static bool IfFalse(this bool value, Action act)
        {
            if (!value) act();
            return value;
        }
    }
}

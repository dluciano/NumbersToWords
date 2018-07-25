using System;

namespace ToWords
{
    public static class Extensions
    {
        public static string ToWords(this int val) {
            switch (val)
            {
                case 0:
                    return "zero";
                default:
                    return "Not defined";
            }
        }
    }
}

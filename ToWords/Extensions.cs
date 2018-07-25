using System;

namespace ToWords
{
    public static class Extensions
    {

        public static string ToWords(this int val)
        {
            var ones = val % 10;
            int tens = val / 10;

            return Tens(tens, ones);

            string Ones(int n)
            {
                switch (n)
                {
                    case 0:
                        return "zero";
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    case 4:
                        return "four";
                    case 5:
                        return "five";
                    case 6:
                        return "six";
                    case 7:
                        return "seven";
                    case 8:
                        return "eight";
                    case 9:
                        return "nine";
                    default:
                        return "Not defined";
                }
            }

            string Tens(int t, int o, char separator = '-')
            {
                var r = "";
                switch (t)
                {
                    case 0:
                        r = string.Empty;
                        break;
                    //case 1:
                    //    return "one";
                    case 2:
                        r = "twenty";
                        break;
                    //case 3:
                    //    return "three";
                    //case 4:
                    //    return "four";
                    //case 5:
                    //    return "five";
                    //case 6:
                    //    return "six";
                    //case 7:
                    //    return "seven";
                    //case 8:
                    //    return "eight";
                    //case 9:
                    //    return "nine";
                    default:
                        throw new NotImplementedException();
                }
                return r +
                    (o == 0 || t == 0 ? String.Empty : separator.ToString()) +
                    (t == 0 ? Ones(o) : o == 0 ? String.Empty : Ones(o));
            }
        }
    }
}

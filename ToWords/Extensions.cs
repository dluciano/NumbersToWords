using System;

namespace ToWords
{
    public static class Extensions
    {

        public static string ToWords(this int val)
        {
            var hundreds = val / 100;
            int tens = (val - (hundreds * 100)) / 10;
            var ones = (val - (hundreds * 100)) % 10;

            return Hundreds(hundreds, tens, ones);

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
                        throw new Exception("Unexpected ones number");
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
                    case 1://Special cases of teens
                        switch (o)
                        {
                            case 0:
                                return "ten";
                            case 1:
                                return "eleven";
                            case 2:
                                return "twelve";
                            case 3:
                                r = "thir";
                                break;
                            case 4:
                                r = "four";
                                break;
                            case 5:
                                r = "fif";
                                break;
                            case 8:
                                r = "eigh";
                                break;
                            case 6:
                            case 7:
                            case 9:
                                r = Ones(o);
                                break;
                            default:
                                throw new Exception("Unexpected teen number");
                        }
                        return r + "teen";
                    case 2:
                        r = "twenty";
                        break;
                    case 3:
                        r = "thirty";
                        break;
                    case 4:
                        r = "forty";
                        break;
                    case 5:
                        r = "fifty";
                        break;
                    case 6:
                        r = "sixty";
                        break;
                    case 7:
                        r = "seventy";
                        break;
                    case 8:
                        r = "eighty";
                        break;
                    case 9:
                        r = "ninety";
                        break;
                    default:
                        throw new Exception("Unexpected ten number");
                }
                return r +
                    (o == 0 || t == 0 ? String.Empty : separator.ToString()) +
                    (t == 0 ? Ones(o) : o == 0 ? String.Empty : Ones(o));
            }

            string Hundreds(int h, int t, int o, string hundredsSeparator = " and ", char tenSeparator = '-')
            {
                if (h == 0)
                    return Tens(t, o, tenSeparator);
                return Ones(h) + " hundred" + (t == 0 && o == 0 ? String.Empty :
                    hundredsSeparator + Tens(t, o, tenSeparator));
            }
        }
    }
}

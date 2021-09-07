using System;
using System.Numerics;

namespace Exercise01
{
    public static class Describer
    {
        public static string Towards(this BigInteger bigInteger)
        {
            string description;
            if (bigInteger == 0)
                description = "zero";
            else
            {
                description = IntWords(bigInteger);
            }
            return description;
        }

        static String IntWords(BigInteger n)
        {
            string[] numbersArr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen",
                "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensArr = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] suffixesArr = new string[] { "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion",
                "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion",
                "Septdecillion","Octodecillion", "Novemdecillion", "Vigintillion" };
            string description = "";

            bool tens = false;

            if (n < 0)
            {
                description += "negative ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                BigInteger pow = (BigInteger)Math.Pow(10, power);
                if (n >= pow)
                {
                    description += IntWords((BigInteger)(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                    n %= pow;
                    if (n > 0) description += ",";
                    if (n > 100) description += " ";
                }
                power -= 3;
            }
            if (n >= 1000)
            {
                description += IntWords(n / 1000) + " thousand";
                n %= 1000;
                if (n > 100) description += ", ";
            }

            if (0 <= n && n <= 999)
            {
                if (n / 100 > 0)
                {
                    description += IntWords((n / 100)) + " hundred";
                    n %= 100;
                }
                if (n / 10 > 1)
                {
                    if (description != "")
                        description += " and ";
                    description += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0)
                {
                    if (description != "" && !tens)
                    {
                        description += " and ";
                    }
                    description += (tens ? "-" + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                }
            }

            return description;

        }
    }
}

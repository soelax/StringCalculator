using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringMultiplier
    {
        public StringMultiplier()
        {
        }

        public string multiply(string first, string second)
        {
            var result = "";

            /* 1234*1234
             *   1234000
             *    246800
             *     37020
             *      4936
             * ---------
             *   1522756
             */

            var parts = new List<string>();
            for(int i = 0; i < second.Length; i++)
            {
                var part = singleMultiplication(first, second.Substring(i, 1));
                parts.Add(part + new string('0', second.Length - 1 - i));
            }

            var adder = new StringAdder();
            result = parts.Aggregate((res, item) => adder.add(res, item));

            return result;
        }

        private string singleMultiplication(string first, string simpleFactor)
        {
            int factor = int.Parse(simpleFactor);
            var result = new System.Text.StringBuilder();

            var firstChars = first.ToCharArray();
            int carryOver = 0;
            for(int i = first.Length - 1; i >= 0; i--)
            {
                var prod = int.Parse(firstChars[i].ToString()) * factor + carryOver;
                if (prod >= 10)
                {
                    carryOver = prod / 10;
                    prod = prod % 10;
                }
                else
                {
                    carryOver = 0;
                }

                result.Append(prod);
            }
            if (carryOver > 0) result.Append(carryOver);

            return Tools.reverse(result.ToString());
        }
    }
}
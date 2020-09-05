using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Tools
    {
        public static string reverse(string input)
        {
            var chars = input.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }
    }
}

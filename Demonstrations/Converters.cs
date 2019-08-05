using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations
{
    public static class Converters
    {
        public static double ConvertStringToDecimal(string input)
        {
            double output = 0;

            double.TryParse(input, out output);

            return output;
        }

        public static double ToDouble(this string input)
        {
            double output = 0;

            double.TryParse(input, out output);

            return output;
        }
    }
    }
}

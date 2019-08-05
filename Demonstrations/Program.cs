using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            string firstValue = Console.ReadLine();

            Console.Write("y: ");
            string secondValue = Console.ReadLine();

            double x = Converters.ConvertStringToDecimal(firstValue);
            double y = secondValue.ToDouble();

            double z = x * y;

            Console.WriteLine("The product of {0} and {1} is {2}", x, y, z);

            Console.ReadLine();
        }
    }
}

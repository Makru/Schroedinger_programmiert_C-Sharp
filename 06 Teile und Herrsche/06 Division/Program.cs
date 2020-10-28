using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Division
{
    class Program
    {
        static bool Divide(double a, double b, out double result)
        {
            if (b == 0.0)
            {
                result = 0.0;
                return false;
            }
            else
            {
                result = a / b;
                return true;
            }
        }
        static void Main(string[] args)
        {
            double ergebnis = Divide(15, 3);
            Console.WriteLine(ergebnis);
            Console.ReadKey();
        }
    }
}

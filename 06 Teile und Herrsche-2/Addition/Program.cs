using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int sum = Add(2, 99);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
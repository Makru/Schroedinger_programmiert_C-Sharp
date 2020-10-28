using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool isPrim = true;
                for (int j = 2; j < i; j++)
                    if (i % j == 0)
                    {
                        isPrim = false;
                        break;
                    }
                if (isPrim)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

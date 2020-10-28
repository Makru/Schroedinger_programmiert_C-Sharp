using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreieck
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 5;

            if (a == b && b == c && a == c)
            {
                Console.WriteLine("Es handelt sich um ein gleichseitiges Dreieck");
            }

            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Es handelt sich um ein gleichschenkeliges Dreieck");
            }
            else
            {
                Console.WriteLine("Es handelt sich um ein allgemeines Dreieck");

            }
            Console.ReadKey();
        }
    }
}

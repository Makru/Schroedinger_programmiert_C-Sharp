using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_Werkstatt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Die For Schleife");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                    Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Die While Schleife");
            int number = 1;
            while (number <= 50)
            {
                if (number % 3 == 0)
                    Console.Write(number + ", ");
                number++;
            }
            Console.WriteLine();
            Console.WriteLine("Die Do-While Schleife");
            int num = 1;
            do
            {
                if (num % 3 == 0)
                    Console.Write(num + ", ");
                num++;
            }
            while (num <= 50);
            Console.WriteLine();
            Console.WriteLine("Endlosschleife mit break");
            int n = 1;
            while (true)
            {
                if (n % 3 == 0)
                    Console.Write(n + ", ");
                n++;
                if (n > 50)
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Aktuellen Schleifendurchlauf mit continue abbrechen.");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 != 0)
                    continue;
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            string[] zutaten = new string[] { "Pommes", "Schnitzel", "Mayo", "Ketchup" };
            foreach (string zutat in zutaten)
            {
                Console.WriteLine(zutat);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laufzeitkomplexitaet {
    class Program {
        static void Main(string[] args) {
            const int NUM_COUNT = 1000;
            int[] numbers = new int[NUM_COUNT];
            Random rnd = new Random();

            // Array mit Zufallszahlen füllen.
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(0, numbers.Length);

            Console.WriteLine("Bitte Zahl zum Suchen eingeben:");
            int search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == search) {
                    Console.WriteLine("Gefunden! Die Zahl {0} steht an Stelle {1}", search, i);
                    break;
                }
        }
    }
}

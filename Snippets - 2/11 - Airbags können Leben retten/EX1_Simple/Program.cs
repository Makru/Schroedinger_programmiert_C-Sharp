using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_Simple {
    class Program {
        static void Main(string[] args) {
            string[] names = { "Schrödinger", "Katze", "Freundin" };
            try {
                int lastIndex = 0;
                for (int i = 0; i <= 4; i++) {
                    lastIndex = i;
                    try {
                        Console.WriteLine("Protagonist: {0}", names[i]);
                    }
                    catch (IndexOutOfRangeException) {
                        Console.WriteLine("Hoppala etwas zu weit gelaufen");
                        Console.WriteLine("Last info: {0}", names[lastIndex]);
                    }
                }
            }
            catch (IndexOutOfRangeException) {
                Console.WriteLine("So nicht - IndexOutOfRange");
            }
            catch (NullReferenceException) {
                Console.WriteLine("So nicht - null");
            }
            catch (Exception) {
                Console.WriteLine("So nicht - Allgemein");
            }
        }
    }
}

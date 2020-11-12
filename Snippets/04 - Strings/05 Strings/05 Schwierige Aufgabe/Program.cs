using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Schwierige_Aufgabe {
    class Program {
        static void Main(string[] args) {
            string text;
            string searchTerm;
            bool found = false;

            Console.WriteLine("Bitte Text eingeben");
            text = Console.ReadLine();
            Console.WriteLine("Bitte Suchbegriff eingeben");
            searchTerm = Console.ReadLine();

            for (int i = 0; i < text.Length - searchTerm.Length; i++) {
                found = true;
                for (int j = 0; j < searchTerm.Length; j++) {
                    if (text[i + j] != searchTerm[j]) {
                        found = false;
                        break;
                    }
                }
                if (found)
                    break;
            }

            Console.WriteLine("Gefunden? " + found);
        }
    }
}

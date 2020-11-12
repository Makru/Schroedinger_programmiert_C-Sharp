using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Einfache_Aufgabe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Text eingeben:");
            string text = Console.ReadLine();
            string neuerText = "";
            // Bitte hier Code einfügen
            for (int i = text.Length - 1; i >= 0; i--)
                neuerText += text[i];
            Console.WriteLine("Der invertierte Text: {0}", neuerText);
        }
    }
}




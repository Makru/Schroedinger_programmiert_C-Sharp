using System;   // Der Grundnamespace des .NET Frameworks
using System.Collections.Generic; // alternativen zu Arrays
using System.Linq; // LINQ abfragen - lernst du später noch.
using System.Text; // Arbeiten mit Text-Elementen wie StringBuilder.
using System.Threading.Tasks; // Beinhaltet Klassen für Nebenläufigkeiten

namespace _01___Schwierige_Aufgabe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Vorname eingeben:");
            var vorname = Console.ReadLine();
            Console.WriteLine("Nachname eingeben:");
            var nachname = Console.ReadLine();
            Console.WriteLine(vorname + " " + nachname);

        }
    }
}

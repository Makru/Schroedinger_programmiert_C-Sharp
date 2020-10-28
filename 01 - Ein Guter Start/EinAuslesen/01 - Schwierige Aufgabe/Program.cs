using System;   // Der Grundnamespace des .NET Frameworks

namespace _01___Schwierige_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vorname eingeben:");
            var vorname = Console.ReadLine();
            Console.WriteLine("Nachname eingeben:");
            var nachname = Console.ReadLine();
            Console.WriteLine(vorname + " " + nachname);
        }
    }
}

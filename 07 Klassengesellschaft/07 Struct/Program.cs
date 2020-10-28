using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct {
    class Program {
        static void Main(string[] args) {
            // Personen anlegen
            Person p1 = new Person();
            p1.Name = "Schrödinger";
            Person p2 = new Person();
            p2.Name = "Schrödingers Freundin";

            // Personen tauschen
            Person.Switch(p1, p2);

            // Ergebnis ausgeben.
            Console.WriteLine("Person1: " + p1.Name);
            Console.WriteLine("Person2: " + p2.Name);
        }
    }
}

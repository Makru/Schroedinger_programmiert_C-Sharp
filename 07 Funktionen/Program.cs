using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Funktionen {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person("Schrödinger");
            Person p2 = new Person();
            Person p3 = new Person("Noch wer", 70);
            p1.Name = "Schrödinger";
            p2.Name = "Schördingers Freundin";
            p1.Walk(1500);
            p2.Walk(1500);
            p2.Walk(2100);   // Deine Freundin ist sportlicher als du. Sie geht noch eine extra Runde.
            Console.WriteLine("Schrödingers Schritte: {0}. km: {1}", p1.Footsteps, p1.WalkedKm);
            Console.WriteLine("Ihre Schritte: {0}. km: {1}", p2.Footsteps, p2.WalkedKm);
            float average = Person.AverageWalkedKm(new Person[] { p1, p2 });
            Console.WriteLine("Euer Durchschnitt: {0}km", average);
        }
    }
}

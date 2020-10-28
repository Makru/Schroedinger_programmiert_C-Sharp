using System;

namespace _06_Tauschgeschäfte_01 {
    internal class Program {
        private static void Main(string[] args) {
            double var1 = 2.5;
            double var2 = 3.8;
            Swap(ref var1, ref var2); //Lösung: ref auch beim Aufruf einfügen, siehe vorne
            Console.WriteLine("Variable1: {0}; Variable2: {1}", var1, var2);
            Console.ReadKey();

            if (int.TryParse("1", out _)) {
                // Hat funktioniert!
            }
            Console.ReadKey();
        }
        //Lösung: ref bei den Parametern einfügen, siehe unten
        private static void Swap(ref double a, ref double b) {
            double temp = a;
            a = b;
            b = temp;
        }

        private static void ReadOnly(in double a, in double b) {
            double tmp = a; // OK
            //a = b;  // Nein! Auf a darf nur lesend zugegriffen werden!
        }
    }
}

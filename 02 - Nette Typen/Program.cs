using System;

namespace Konvertierung {
    internal class Program {
        private static void Main(string[] args) {
            byte var1 = 12;
            int var2 = var1;
            long var3 = var2;

            float var4 = 1;
            double var5 = 1.3;
            float var6 = var1;
            float var7 = var2;
            float var8 = var3;
            var5 = var4;

            double pi = 3.14159265;
            byte firstNumOfPi = Convert.ToByte(pi);

            // Werte werden kopiert.
            int variable1 = 3;
            int variable2 = variable1;
            variable1++;

            // Wertverweise
            ref int variable3 = ref variable1;
            Console.WriteLine("Variable3: " + variable3);
            Console.WriteLine("Variable1: " + variable1);
            variable3++;
            Console.WriteLine("Variable3: " + variable3);
            Console.WriteLine("Variable1: " + variable1);
            int gemeinsameVariable = 3;
            ref int verweisAufVariable = ref gemeinsameVariable;


            bool schnitzel = true;
            bool pommes = false;
            bool salatZutaten = true;
            bool essenZuHause = salatZutaten || schnitzel && pommes;
            ref bool bleibeZuHause = ref essenZuHause;
            bleibeZuHause = false;

            /* Viele bool'sche Verknüpfungen
                Was ist am Ende das Ergebnis? */
            bool ergebnis = false || true;  // Ergibt true
            ergebnis |= false;          // Bleibt true
            ergebnis = !ergebnis;       // wird false
            ergebnis |= !true;          // bleibt false


            bool x = true;
            bool y = false;
            bool wert1 = x || y;
            int wert2 = 42;
            double wert3 = 3.14159265;
            double wert5 = wert2 + wert3;
            double wert6 = 1.2F * wert3;


            Console.ReadKey();
        }
    }
}

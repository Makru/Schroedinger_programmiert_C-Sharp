using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvertierung {
    class Program {
        static void Main(string[] args) {
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


            int rest = 10 % 3;


            bool schnitzel = true;
            bool pommes = false;
            bool salatZutaten = true;
            bool essenZuHause = salatZutaten || schnitzel && pommes;

            /* Viele bool'sche Verknüpfungen
                Was ist am Ende das Ergebnis? */
            bool ergebnis = false || true;  // Ergibt true
            ergebnis |= false;          // Bleibt true
            ergebnis = !ergebnis;       // wird false
            ergebnis |= !true;          // bleibt false

            var boolVariable = true;
            var zahl = 3;
            var doubleVariable = 3.4;
            var floatVariable = 3.4f;
            var longVariable = 42L;


bool x = true;
bool y = false;
var wert1 = x || y;
var wert2 = 42;
var wert3 = 3.14159265;
var wert4;
var wert7 = 32 + 17;
var wert5 = wert2 + wert3;
var wert6 = 1.2F * wert3;

        }
    }
}

using System;
using System.Diagnostics;

namespace _07_Klassen_vs_Strukturen {
    internal class Program {
        private const int AMOUNT = 1000000;

        private static void Main(string[] args) {
            Console.WriteLine($"Zeitmessung für {AMOUNT} Objekte");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            VectorClass[] classArr = new VectorClass[AMOUNT];
            for (int i = 0; i < AMOUNT; i++) {
                classArr[i] = new VectorClass() {
                    X = i,
                    Y = i,
                    Z = i
                };
            }
            Console.WriteLine("Klassen erzeugen: " + sw.ElapsedMilliseconds);
            sw.Reset();
            sw.Start();
            VectorStruct[] structArr = new VectorStruct[AMOUNT];
            for (int i = 0; i < AMOUNT; i++) {
                structArr[i] = new VectorStruct() {
                    X = i,
                    Y = i,
                    Z = i
                };
            }
            Console.WriteLine("Strukturen erzeugen: " + sw.ElapsedMilliseconds);

            // Großer Unterschied im Debug Mode allerdings nicht im Release Mode
            // Zugriffstest
            int[] itemsToAccess = new int[AMOUNT * 5];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < itemsToAccess.Length; i++) {
                itemsToAccess[i] = rnd.Next(0, AMOUNT);
            }

            Console.WriteLine("Zugriffstest und zwar: " + (itemsToAccess.Length + 1) + " mal.");
            sw.Reset();
            sw.Start();
            VectorClass itm = classArr[0];
            for (int i = 0; i < itemsToAccess.Length; i++) {
                itm = classArr[itemsToAccess[i]];
            }
            Console.WriteLine("Klassen Direkter Array Zugriff: " + sw.ElapsedMilliseconds);

            sw.Reset();
            sw.Start();
            // Verwende Referenzvariable um gleiche Bedingungen sicherzustellen.
            ref VectorStruct structItm = ref structArr[0];
            for (int i = 0; i < itemsToAccess.Length; i++) {
                structItm = ref structArr[itemsToAccess[i]];
            }
            Console.WriteLine("Struktur Direkter Array Zugriff: " + sw.ElapsedMilliseconds);


            sw.Reset();
            sw.Start();
            // Ohne Referenzvariable wird kopiert. Der Vergleich wird spannend.
            VectorStruct structItmCpy = structArr[0];
            for (int i = 0; i < itemsToAccess.Length; i++) {
                structItmCpy = structArr[itemsToAccess[i]];
            }
            Console.WriteLine("Struktur Kopie Array Zugriff: " + sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}

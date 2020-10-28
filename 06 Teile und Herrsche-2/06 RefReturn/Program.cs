using System;

namespace _06_RefReturn {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("Bitte Zahl1 eingeben:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte Zahl2 eingeben:");
            int num2 = int.Parse(Console.ReadLine());

            ref int max = ref GetMax(ref num1, ref num2);
            Console.WriteLine($"Das Maximum ist: {max}");
            max -= 1;   // Es wird der Wert der Original-Variable reduziert!
            Console.WriteLine($"Die Beiden Zahlen waren: {num1} und {num2}. Doch die größere wurde um 1 reduziert.");
            Console.ReadKey();
        }

        private static ref int GetMax(ref int num1, ref int num2) {
            if (num1 > num2)
                return ref num1;
            return ref num2;
        }
    }
}

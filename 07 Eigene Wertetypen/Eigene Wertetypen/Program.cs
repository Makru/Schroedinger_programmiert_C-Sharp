using System;
using System.Runtime.CompilerServices;

namespace Eigene_Wertetypen {
    internal class Program {
        private static void Main(string[] args) {

            Person person = new Person {
                Firstname = "Max",
                Lastname = "Müller"
            };


            Ingredient[] ingredients = new Ingredient[2];
            ingredients[0] = new Ingredient();
            ingredients[0].Name = "Mehl";
            ingredients[0].Amount = 30;
            ingredients[0].Unit = "g";
            ingredients[1] = new Ingredient();
            ingredients[1].Name = "Wasser";
            ingredients[1].Amount = 0.25f;
            ingredients[1].Unit = "l";

            MinMax range = Range(new int[] { 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 });
            MinMax range2 = range;  // Alle Werte der Range werden kopiert!
            range2.Max = 100;       // Durch die neue Wertzuweisung von Max wird durch die Kopien die original-Variable range nicht verändert.
            Console.WriteLine(range.Max);

            // Verweis auf die Variable
            ref var range3 = ref range;
            range3.Max = 1000;
            Console.WriteLine(range.Max);
            Console.ReadKey();
        }

        private static MinMax Range(int[] nums) {
            MinMax range = new MinMax {
                Min = int.MaxValue,
                Max = int.MinValue
            };
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] < range.Min)
                    range.Min = nums[i];
                if (nums[i] > range.Max)
                    range.Max = nums[i];
            }
            return range;
        }

        private static int Size(in MinMax range) {
            return range.Max - range.Min;
        }
    }
}

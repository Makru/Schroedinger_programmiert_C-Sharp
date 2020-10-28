using System;

namespace EigeneWertetypen {
    internal class Program {
        private static void Main(string[] args) {
            (int Max, int Min) arrRange = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {arrRange.Min} - {arrRange.Max}");

            (int Max, int Min) resultRange = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {resultRange.Min} - {resultRange.Max}");

            (int max, int min) = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {min} - {max}");


            (string Name, float Amount, string Unit)[] ingredients = new (string Name, float Amount, string Unit)[2];
            ingredients[0] = ("Wasser", 0.25F, "l");
            ingredients[1] = ("Mehl", 30, "g");

            Console.ReadKey();
        }

        private static (int Max, int Min) Range(int[] nums) {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++) {
                min = (nums[i] < min) ? nums[i] : min;
                max = (nums[i] > max) ? nums[i] : max;
            }
            return (max, min);
        }
    }
}

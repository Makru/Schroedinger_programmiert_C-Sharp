using System;

namespace Spans {
    internal class Program {
        private static void Main(string[] args) {
            int[] numbers = new int[] { 2, 1, 3, 1, 2, 3, 8, 9 };

            (int max, int min) = Range(numbers.AsSpan(0, 6).ToArray());
            Console.WriteLine($"max: {max}, min: {min}");

            (max, min) = Range(numbers.AsSpan(6).ToArray());
            Console.WriteLine($"max: {max}, min: {min}");


            // Nur lesend oder doch auch schreibend?
            numbers.AsSpan(0, 6)[1] = 2;
            Console.WriteLine(numbers[1]);  // Schreiben ist möglich!


            ref int evenOrLastValue = ref EvenOrLast(numbers);
            evenOrLastValue = 47;    // Wir bekommen numbers[0] (2) -> Ändern wir es auf 47 -> Dadurch wird das Element im Array an dieser Stelle verändert.
            Console.WriteLine(numbers[0]);



            Console.ReadKey();
        }

        private static ref int EvenOrLast(int[] values, int searchStart = 0) {
            for (int i = searchStart; i < values.Length; i++) {
                if (values[i] % 2 == 0)
                    return ref values[i];
            }
            return ref values[values.Length - 1];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Kochrezept1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Größe eingeben:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Gewicht eingeben:");
            int weight = int.Parse(Console.ReadLine());

            float bmi = CalculateBMI(weight: weight, height: height);
            Console.WriteLine(bmi);
        }

        static float CalculateBMI(float weight = 75, float height = 1.80f) {
            return weight / (height * height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Teile_und_Herrsche {
    class Program {
        static void Main(string[] args) {
            int sum = Add(2, 3);
            Console.WriteLine(sum);


            int a = 12;
            Increment(ref a);
            Console.WriteLine(a);

            int number;
            if (int.TryParse("2", out number))
                Console.WriteLine("Parse hat funktioniert");
            else
                Console.WriteLine("Keine gültige Zahl.");

            MyFunction("hier", "können");
        }

        static int Add(int a, int b) {
            return a + b;
        }
        static int Add(int a, int b, int c = 0) {
            return a + b + c;
        }
        static int Add(int a) {
            return Add(a, 1);
        }

        static void Increment(ref int number) {
            number++;
        }

        static void MyFunction(params string[] data) {
        }
    }
}

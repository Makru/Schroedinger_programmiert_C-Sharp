using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Tauschgeschäfte_01 {
    class Program {
        static void Main(string[] args) {
            double var1 = 2.5;
            double var2 = 3.8;
            Swap(var1, var2);
            Console.WriteLine("Variable1: {0}; Variable2: {1}", var1, var2);
        }

        static void Swap(double a, double b) {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}

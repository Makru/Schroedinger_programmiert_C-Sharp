using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterValidation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine().Trim();
            if (!String.IsNullOrEmpty(name))
                WriteHello(name);
            else
                Console.WriteLine("Warum machst du nie, was man dir sagt?");

            Variante1();
        }

        private static void Variante1() {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine().Trim();
            try {
                WriteHello(name);
            }
            catch (ArgumentNullException a) when (a.ParamName == "name") {
                Console.WriteLine("Warum machst du nie, was man dir sagt?");
            }
        }

        static void WriteHello(string name) {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            Console.WriteLine("Hello {0}", name);
        }
    }
}

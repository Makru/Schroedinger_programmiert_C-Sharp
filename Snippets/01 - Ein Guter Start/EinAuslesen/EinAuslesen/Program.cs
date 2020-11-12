using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinAuslesen {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bitte Namen eingeben:");
            var name = Console.ReadLine();
            Console.WriteLine("Hallo {0}", name);
            Console.ReadKey();
        }
    }
}

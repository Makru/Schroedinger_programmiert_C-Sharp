using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2 {

    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            PrintPersonInfo(p);
        }

        private static void PrintPersonInfo(Person p) {
            if (p == null)
                throw new ArgumentNullException("p");
            if (p.Name == null)
                throw new ArgumentException("The Name property is null.", "p");

            if (p.Name.Contains("Schrödinger"))
                Console.WriteLine("Unser Held: {0}", p.Name);
            else
                Console.WriteLine(p.Name);
        }

    }
}

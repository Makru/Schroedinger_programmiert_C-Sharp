using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eigenschaften_Einfache_Aufgabe {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            p.Title = "Dr.";
            p.Lastname = "Schrödinger";
            p.Age = 29;
            p.Sex = Sex.Male;
            Console.WriteLine(p.Firstname);
            Console.WriteLine(p.FullName);
        }
    }
}

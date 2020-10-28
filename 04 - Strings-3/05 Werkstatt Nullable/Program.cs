using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Werkstatt_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? myValue = null;
            Console.WriteLine("Wert setzen (true, false)?");
            bool setValue = bool.Parse(Console.ReadLine());
            if (setValue)
                myValue = 42;

            if (myValue.HasValue)
                Console.WriteLine("Der Wert ist: {0}.", myValue.Value);
            else
                Console.WriteLine("Wert nicht gesetzt.");

            string lastUnicorn = "";
            bool hasName = lastUnicorn.HasValue;
            Console.WriteLine(hasName);
            Console.ReadKey();
        }
    }
}

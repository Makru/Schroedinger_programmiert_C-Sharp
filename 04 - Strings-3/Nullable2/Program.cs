#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastUnicorn = "";
            bool hasName = lastUnicorn.HasValue;
            Console.WriteLine(hasName);
            Console.ReadKey();
        }
    }
}

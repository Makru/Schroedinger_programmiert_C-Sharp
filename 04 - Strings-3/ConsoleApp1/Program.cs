using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"Hallo", "Schrödinger","wie", "geht", "es", "dir"};
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
                sb.Append(words[i]);
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Einfache_Aufgabe {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Text eingeben:");
            string text = Console.ReadLine();
			string neuerText = "";
            int u = text.Length;
            // Bitte hier Code einfügen
            Console.WriteLine(u);
            Console.WriteLine(text[u-1]);
            for (int i = text.Length - 1; i >= 0; i--)
				neuerText += text[i];
			Console.WriteLine("Der invertierte Text: {0}", neuerText);

			char[] inverted = new char[text.Length];
			for (int i = 0; i < inverted.Length; i++)
				inverted[i] = text[inverted.Length - 1 - i];
			neuerText = new String(inverted);
			Console.WriteLine("Der invertierte Text: {0}", neuerText);
            Console.ReadKey();
		}
	}
}




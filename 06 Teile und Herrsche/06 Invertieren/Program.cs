using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Invertieren {
	class Program {
		static void Main(string[] args) {
			string name = "Schrödinger";
			string title = "God Father of WoW";
			//int Namenlänge = name.Length;
			//Console.WriteLine(Namenlänge);
			char[] invertedNameChars = new char[name.Length];
			char[] invertedTitleChars = new char[title.Length];

			for (int i = 1; i <= name.Length; i++)
				invertedNameChars[name.Length - i] = name[i - 1];

			string invertedName = new String(invertedNameChars);
			for (int i = 1; i <= title.Length; i++)
				invertedTitleChars[title.Length - i] = title[i - 1];

			string invertedTitle = new String(invertedTitleChars);

			Console.WriteLine("Name: {0}; Invertiert: {1}", name, invertedName);
			Console.WriteLine("Titel: {0}; Invertiert: {1}", title, invertedTitle);
            Console.ReadKey();
		}
	}
}

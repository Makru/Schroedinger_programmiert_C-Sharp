using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Invertieren_Mit_Funktion {
	class Program {
        static void Main(string[] args)
        {
            string name = "Schrödinger";
            string title = "God Father of WoW";
            string invertedName = Invert(name);
            string invertedTitle = Invert(title);
            Console.WriteLine("Name: {0}; Invertiert: {1}", name, invertedName);
            Console.WriteLine("Titel: {0}; Invertiert: {1}", title, invertedTitle);
            Console.ReadKey();
        }
		static string Invert(string textToInvert) {
			char[] theChars = new char[textToInvert.Length];
			for (int i = 1; i <= textToInvert.Length; i++)
				theChars[textToInvert.Length - i] = textToInvert[i - 1];
			return new String(theChars);
		}
	}
}

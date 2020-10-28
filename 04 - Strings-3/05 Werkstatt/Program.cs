using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Werkstatt {
	class Program {
		static void Main(string[] args) {
			string text = "Schrödinger ist cool ";
			char zeichen = text[2];
			Console.WriteLine(zeichen);
			int zahl = zeichen;// (int)zeichen;
			Console.WriteLine(zahl);


			char z = 'ö';
			byte num = (byte)z;
			int b = (int)z;

			Console.WriteLine(zeichen + " entspricht der Zahl " + zahl);

			int indexOfCool = text.IndexOf("cool");
			string lowerText = text.ToLower();
			string upperText = text.ToUpper();
			string textWithoutWhitespace = text.Trim();
            Console.WriteLine($"Der Index of cool ist: {indexOfCool}.");

            int len = text.Length;
			string[] words = text.Split(' ');
			string newText = String.Format("Die Länge: {0}. Anzahl der Wörter: {1}", len, words.Length);
			
			Console.WriteLine($"Die Länge: {len}. Anzahl der Wörter: {words.Length}");
			string newText1 = $"Die Länge: {len}. Anzahl der Wörter: {words.Length}";
			string newText2 = String.Concat("Die Länge: ", len, ". Anzahl der Wörter: ", words.Length);
			Console.WriteLine(newText);
			Console.WriteLine(newText1);
			Console.WriteLine(newText2);

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < words.Length; i++)
				sb.Append(words[i]);
			Console.WriteLine(sb.ToString());

			string a = String.Format("{0} {1} {2} {0}", "!", "Hallo", "Schrödinger");
			Console.WriteLine(a);

			Console.ReadKey();
        }
	}
}

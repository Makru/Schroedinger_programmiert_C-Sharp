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
            int zahl = (int)zeichen;
            Console.WriteLine(zeichen + " entspricht der Zahl " + zahl);

            int indexOfCool = text.IndexOf("cool");
            string lowerText = text.ToLower();
            string upperText = text.ToUpper();
            string textWithoutWhitespace = text.Trim();

            int len = text.Length;
            string[] words = text.Split(' ');
            string newText = String.Format("Die Länge: {0}. Anzahl der Wörter: {1}", len, words.Length);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
                sb.Append(words[i]);
            Console.WriteLine(sb.ToString());
        }
    }
}

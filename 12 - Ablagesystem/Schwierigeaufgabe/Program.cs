using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schwierigeaufgabe {
	class Program {
		static Random rnd = new Random(DateTime.Now.Millisecond);
		static void Main(string[] args) {
			int zeichenAnzahl = 5;
			String[] ihreSchuhe = new String[10000];
			String[] imGeschaeft = new String[100000];
			Console.WriteLine("Generiere Schuhe...");
			GeneriereSchuhnummern(ihreSchuhe, zeichenAnzahl);
			GeneriereSchuhnummern(imGeschaeft, zeichenAnzahl);

			Teil1(ihreSchuhe, imGeschaeft);

			Teil2(ihreSchuhe, imGeschaeft);

			Console.Read();
		}

		private static void Teil2(String[] ihreSchuhe, String[] imGeschaeft) {
			Console.WriteLine("Teil 2: Suche übereinstimmungen...");
			DateTime start = DateTime.Now;
			List<string> neueSchuhe = new List<string>(imGeschaeft.Length - ihreSchuhe.Length);
			HashSet<string> ihreSchuheHash = new HashSet<string>();
			for (int i = 0; i < ihreSchuhe.Length; i++)
				ihreSchuheHash.Add(ihreSchuhe[i]);
			for (int i = 0; i < imGeschaeft.Length; i++)
				if (ihreSchuheHash.Add(imGeschaeft[i]))
					neueSchuhe.Add(imGeschaeft[i]);
			Console.WriteLine("Fertig. Dauer: {0}ms", DateTime.Now.Subtract(start).Milliseconds);
			Console.WriteLine("Deine Freundin kann sich noch weitere {0} paar Schuhe kaufen", neueSchuhe.Count);
		}

		private static void Teil1(String[] ihreSchuhe, String[] imGeschaeft) {
			Console.WriteLine("Teil 1: Suche übereinstimmungen...");
			DateTime start = DateTime.Now;
			List<string> neueSchuhe = new List<string>(imGeschaeft.Length - ihreSchuhe.Length);
			for (int i = 0; i < imGeschaeft.Length; i++) {
				bool vorhanden = false;
				for (int j = 0; j < ihreSchuhe.Length; j++) {
					if (ihreSchuhe[j] == imGeschaeft[i]) {
						vorhanden = true;
						break;
					}
				}
				if (!vorhanden)
					neueSchuhe.Add(imGeschaeft[i]);
			}
			Console.WriteLine("Fertig. Dauer: {0}sec", DateTime.Now.Subtract(start).Seconds);
			Console.WriteLine("Deine Freundin kann sich noch weitere {0} paar Schuhe kaufen", neueSchuhe.Count);
		}

		private static void GeneriereSchuhnummern(string[] arr, int zeichenAnzahl) {
			for (int i = 0; i < arr.Length; i++) {
				char[] nummer = new char[zeichenAnzahl];
				for (int j = 0; j < zeichenAnzahl; j++)
					nummer[j] = (char)rnd.Next(65, 97);
				arr[i] = new String(nummer);
			}
		}
	}
}

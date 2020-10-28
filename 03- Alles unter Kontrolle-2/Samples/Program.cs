using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("Bitte Monat eingeben:");
			int month = int.Parse(Console.ReadLine());
			switch (month) {
				case 1:
					Console.WriteLine("Der erste Monat dieses Jahres.");
					break;
				case 2:
					Console.WriteLine("Valentinstag nicht vergessen!");
					break;
				case 3:
				case 4:
					Console.WriteLine("Es ist März oder April!");
					break;
				//....
				case 12:
					Console.WriteLine("Es ist Dezember - Weihnachten ypeeeiee.");
					break;
				default:
					Console.WriteLine("Hey so viele Monate hat das Jahr doch gar nicht.");
					break;                    
            }

			int dayOfWeek = 4;
			switch (dayOfWeek) {
				case 0:
				case 1:
					Console.WriteLine("Anfang der Woche");
					break;
				case 2:
					Console.WriteLine("Bald ist Wochenmitte");
					break;
				case 3:
					Console.WriteLine("Es ist Wochenmitte");
					break;
				case 4:
				case 5:
					Console.WriteLine("Wochenmitte ist vorbei");
					break;
				default:
					Console.WriteLine("Ende");
					break;
			}

			Console.WriteLine("Freundin da? (true, false):");
			bool freundinDa = bool.Parse(Console.ReadLine());
			if (freundinDa == true) {
				Console.WriteLine("Kanal auf dem Titanic läuft:");
				int kanal = int.Parse(Console.ReadLine());
				Console.WriteLine("Tja, heute wird Titanic angesehen. Kanal: " + kanal);
			}
			else {
				Console.WriteLine("Horror (true) oder Action (false)?");
				bool horror = bool.Parse(Console.ReadLine());
				if (horror)
					Console.WriteLine("Gute Wahl heute wirds gruselig.");
				else
					Console.WriteLine("Ein guter Action Film ist immer toll.");
			}
			Console.ReadKey();
		}
	}
}
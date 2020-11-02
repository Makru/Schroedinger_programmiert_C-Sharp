using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Diät {
	class Program {
		static void Main(string[] args) {
			// Werte von http://www.drogistenverband.at/gesundheitsratgeber/koerper/Verdau/kalorien.htm
			Speise[] speisen = new Speise[] {
                new Speise() { Name = "Broccoli gratiniert", KiloKalorien = 216},
                new Speise() { Name = "Nudelsalat", KiloKalorien = 506 },
                new Speise() { Name = "Mozarella mit Tomaten", KiloKalorien = 300 },
                new Speise() { Name = "Schnitzel mit Pommes", KiloKalorien = 518 + 320 },
                new Speise() { Name = "Gefüllte Paprika", KiloKalorien = 182 },
                new Speise() { Name = "Spagetti mit Tomatensauce", KiloKalorien = 333}
            };

			/* LINQ VARIANTE */
			// Gruppieren der Speisen nach Kaloriengehalt
			var katSpeisen = from s in speisen
							 group s by s.KiloKalorien > 300;
			// Ausgabe der Speisen
			foreach (var gruppe in katSpeisen) {
				Console.WriteLine(gruppe.Key ? "\nLeckere Speise" : "\nDiättaugliche Speise");
				foreach (var speise in gruppe)
					Console.WriteLine("{0}kCal\t{1}", speise.KiloKalorien, speise.Name);
			}

			/* LAMDA VARIANTE */
			var lamdaSpeisen = speisen.GroupBy(n => n.KiloKalorien > 300);
			// Ausgabe der Speisen
			foreach (var gruppe in lamdaSpeisen) {
				Console.WriteLine(gruppe.Key ? "\nLeckere Speise" : "\nDiättaugliche Speise");
				foreach (var speise in gruppe)
					Console.WriteLine("{0}kCal\t{1}", speise.KiloKalorien, speise.Name);
			}

			Console.ReadKey();
		}
	}
}

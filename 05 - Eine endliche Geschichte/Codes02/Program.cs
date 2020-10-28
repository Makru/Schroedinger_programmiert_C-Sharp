using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes02 {
	class Program {
		enum Weekday {
			Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64
		}
		static void Main(string[] args) {
			Console.WriteLine("Bitte englischen Wochentag eingeben: ");
			string day = Console.ReadLine();
			Weekday myDay = (Weekday)Enum.Parse(typeof(Weekday), day);
			Console.WriteLine("Der eingegebene Wochentag im Enum-Typ ist {0}:", myDay);
            Console.ReadKey();
		}
	}
}

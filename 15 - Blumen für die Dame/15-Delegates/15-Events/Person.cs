using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events {
	class Person {
		public string Name { get; set; }

		public void Eintreten(Bar bar) {
			// Ereignis registrieren
			bar.EsWirdEineRundeAusgegeben += RundeEmpfangen;
			bar.EsWirdEineRundeAusgegeben2 += this.RundeEmpfangen2;
		}
		public void Verlassen(Bar bar) {
			// Ereignis de-registrieren
			bar.EsWirdEineRundeAusgegeben -= RundeEmpfangen;
			bar.EsWirdEineRundeAusgegeben2 -= this.RundeEmpfangen2;
		}
		public void RundeEmpfangen(object sender, EventArgs e) {
			Console.WriteLine("{0} freut sich über ein Getränk!", this.Name);
		}
		public void RundeEmpfangen2(object sender, DrinkEventArgs e) {
			string drinkType;
			if (e.Drink == DrinkType.NonAlcoholic)
				drinkType = "alkoholfreies";
			else
				drinkType = "alkoholisches";
			Console.WriteLine("{0} freut sich über ein {1} Getränk!", this.Name, drinkType);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Stream_Aufgabe1 {
	class Program {
		static void Main(string[] args) {
			EinfacheAufgabe();

			SchwereAufgabe();
			SchwereAufgabe2();

		}

		static void EinfacheAufgabe() {
			using (DisposeBeispiel db = new DisposeBeispiel()) {
			}
		}

		private static void SchwereAufgabe() {
			try {
				using (DisposeBeispiel db = new DisposeBeispiel()) {
					throw new Exception();
					Console.WriteLine("Auch ich bin im using");
				}
			}
			catch (Exception) {
				Console.WriteLine("Fehlerbehandlung");
			}
		}

		static void SchwereAufgabe2() {
			using (DisposeBeispiel db = new DisposeBeispiel()) {
				return;
			}
		}
	}
}

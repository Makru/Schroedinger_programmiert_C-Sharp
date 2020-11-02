using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Delegates {
	class Program {
		delegate int CalculationHandler(int a, int b);

		static void Main(string[] args) {
			CalculationHandler calc = null;
			Console.WriteLine("Was möchtest du tun? 1: Addieren, 2: Subtrahieren, 3: Dividieren");
			string input = Console.ReadLine();
			int number;
			if (int.TryParse(input, out number))
				switch (number) {
					case 1:
						calc = AddMethod;
						break;
					case 2:
						calc = SubstractMethod;
						break;
					case 3:
						//calc = DivisionMethod;	// <- hier ist ein Fehler!
						break;
					default:
						Console.WriteLine("Was erwartest du von mir?");
						break;
				}
			else
				Console.WriteLine("Das war keine Zahl!");

			ExecuteCalculation(calc);

			Console.ReadKey();
		}

		static void ExecuteCalculation(CalculationHandler calc) {
			int a = 5;
			int b = 3;
			Console.WriteLine("Berechnung wird ausgeführt. Werte: a:{0}; b:{1}", a, b);
			int result = calc(a, b);
			Console.WriteLine("Das Ergebnis ist: {0}", result);
		}

		static int AddMethod(int x, int y) {
			return x + y;
		}
		static int SubstractMethod(int x, int y) {
			return x - y;
		}
		static float DivisionMethod(int x, int y) {
			return (float)x / (float)y;
		}
	}
}

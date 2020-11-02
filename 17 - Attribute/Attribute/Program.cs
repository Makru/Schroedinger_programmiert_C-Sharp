using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute {
	class Program {
		static void Main(string[] args) {
			Foo();
			Bar();

			Console.WriteLine(IsPrim(1));
			Console.WriteLine(IsPrim(2));
			Console.WriteLine(IsPrim(3));
			Console.WriteLine(IsPrim(4));
			Console.WriteLine(IsPrim(5));
			Console.WriteLine(IsPrim(565));
		}

		[Conditional("DEBUG")]
		static void Foo() {
			Console.WriteLine("The code ist debug mode!");
		}

		[Obsolete("Mich gibt es bald nicht mehr", false)]
		static void Bar() {
			Console.WriteLine("Thie code is release mode!");
		}

		static bool IsPrim(int number) {
			for (int i = 2; i <= number / 2; i++) {
				if (number % i == 0) {
					LogInfo(String.Format("Die Zahl {0} ist keine Primzahl", number));
					return false;
				}
			}
			return true;
		}
		[Conditional("DEBUG")]
		static void LogInfo(string text) {
			Console.WriteLine(text);
		}
	}
}

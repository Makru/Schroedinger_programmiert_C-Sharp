using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Attribute_bsp {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hallo Schrödinger");
			LogCall();
			Console.WriteLine("Wie geht es dir?");
		}

		[Conditional("DEBUG")]
		static void LogCall() {
			Console.WriteLine("Im Debug habe ich mich rein geschummelt.");
		}
	}
}

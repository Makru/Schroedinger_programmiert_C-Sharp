using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Delegates_Aufgaben {
	class Program {
		static void Main(string[] args) {
			EinfacheAufgabe();

			SchwierigeAufgabe();
		}

		delegate bool MyTryParseHandler(string input, out int result);

		private static void SchwierigeAufgabe() {
			MyTryParseHandler hdl = int.TryParse;

		}

		delegate void MyHandler();

		private static void EinfacheAufgabe() {
			MyHandler method = EinfacheAufgabe;//();
			method();
		}
	}
}

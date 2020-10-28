using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Rethrow {
	class Program {
		static void Main(string[] args) {
			try {
				// Fehler
			}
			catch (Exception) {
				// Logging
				throw;
			}



			try {
				// Fehler
			}
			catch (Exception ex) {
				// Logging
				throw new Exception("Infos", ex);
			}

		}

	}
}

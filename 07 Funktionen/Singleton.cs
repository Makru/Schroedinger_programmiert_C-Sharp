using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Funktionen {
	class MySingleton {
		static MySingleton obj;
		private MySingleton() {
		}
		public static MySingleton GetSingleton() {
			if (obj == null)
				obj = new MySingleton();
			return obj;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Beispiele {
	class Program {
		static void Main(string[] args) {
			bool kino = false;
			bool autofahren = false;
			bool fernsehen = true;
			bool chips = true;
			bool popcorn = false;

			bool zuhause = fernsehen && chips && !(kino && popcorn);
			bool zuhause1 = fernsehen && chips && !(kino || !popcorn);
		}
	}
}

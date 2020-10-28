using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_vs_Freundin {
	interface IFriend {
		string Name { get; set; }
		void GetCalled();
		void BeCool();
	}
}

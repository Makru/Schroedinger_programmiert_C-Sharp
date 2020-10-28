using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	interface IHasCaffeine {
		/// <summary>
		/// Ungefähre der Menge an Koffein je Tasse / Dose in mg.
		/// </summary>
		float Caffeine { get; set; }
	}
}

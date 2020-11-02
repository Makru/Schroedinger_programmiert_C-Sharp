using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EigeneAttribute {
	[Author("Schrödinger")]
	[Author("Bernhard", 1.1)]
	class Person {
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
		[Author("Bernhard", 1.1)]
		public string GetFullName() {
			return String.Format("{0} {1}", this.Firstname, this.Lastname);
		}
	}
}

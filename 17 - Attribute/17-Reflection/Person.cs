using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Reflection {
	[Obsolete("Diese Klasse wird ausgetauscht.")]
	class Person {
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
		public string GetFullName() {
			return String.Format("{0} {1}", this.Firstname, this.Lastname);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EigeneAttribute {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = true)]
	public class AuthorAttribute : Attribute {
		public AuthorAttribute(string name, double version = 1.0) {
			this.Name = name;
			this.Version = version;
		}

		public string Name { get; set; }
		public double Version { get; set; }
	}
}

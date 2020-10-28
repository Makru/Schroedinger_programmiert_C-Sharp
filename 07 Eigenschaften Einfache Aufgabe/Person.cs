using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eigenschaften_Einfache_Aufgabe {
	public enum Sex {
		Male,
		Female
	}
	class Person {
		private Sex Sex;
		string Title { get; set; }
		public string Firstname { private get; set; }
		public string Lastname { get; private set; }
		public void Age { get; set; }
		public string FullName {
			get {
				return String.Format("{0} {1} {2}",
					this.Title, this.Firstname, this.Lastname);
			}
		}
	}
}

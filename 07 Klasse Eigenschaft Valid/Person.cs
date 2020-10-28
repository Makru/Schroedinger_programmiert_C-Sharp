using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schroedinger.Klassen {
	enum Sex { Male, Female }

	class Person {
		public string Firstname { get; set; }
		DateTime birthday;
		public DateTime BirthDay {
			get { return this.birthday; }
			set {
				if (value <= DateTime.Now)
					this.birthday = value;
			}
		}
		public Sex Sex { get; set; }
	}
}

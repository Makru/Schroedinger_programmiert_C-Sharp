using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelWC {
	class Person {
		public Person(int timeOnToilette, int waitUntilToilette) {
			this.TimeOnToilette = timeOnToilette;
			this.WaitUntilToilette = waitUntilToilette;
		}
		public int TimeOnToilette { get; set; }
		public int WaitUntilToilette { get; set; }
		public int Number { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Serialisieren {
	[Serializable]
	public class Person {
		public string Name { get; set; }
		public string Email { get; set; }

		[NonSerialized]
		int weight;

		[System.Xml.Serialization.XmlIgnore]
		public int Weight {
			get { return weight; }
			set { weight = value; }
		}
	}
}

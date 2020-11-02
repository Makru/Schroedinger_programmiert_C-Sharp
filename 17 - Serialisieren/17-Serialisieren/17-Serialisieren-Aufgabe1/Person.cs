using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Serialisieren_Aufgabe1 {
[Serializable]
public class Person {
	public string Name { get; set; }
	public Speise[] LieblingsSpeisen { get; set; }
}
}

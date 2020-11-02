using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Serialisieren_Aufgabe1 {
public enum SpeiseArt {
	Kalt,
	Warm
}

[Serializable]
public class Speise {
	public string Name { get; set; }
	public SpeiseArt Art { get; set; }
}
}

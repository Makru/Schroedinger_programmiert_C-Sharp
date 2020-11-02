using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Stream_Aufgabe1 {
	public class DisposeBeispiel : IDisposable {
		public void Dispose() {
			Console.WriteLine("Aufräumen ist angesagt!");
		}
	}
}

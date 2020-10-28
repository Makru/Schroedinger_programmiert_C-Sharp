using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct_Vector {
	class Program {
		static void Main(string[] args) {
			Vector v1 = new Vector() { X = 21, Y = 2 };
			Vector v2 = new Vector() { X = 42, Y = 3 };
			v1.Add(v2);
			Console.WriteLine("X: {0} Y: {1}", v1.X, v1.Y);
		}
	}
}

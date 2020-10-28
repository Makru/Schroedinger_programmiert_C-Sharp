using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct_Vector {
	struct Vector {
		public int X { get; set; }
		public int Y { get; set; }
		public void Add(Vector a) {
			this.X += a.X;
			this.Y += a.Y;
		}
	}
}

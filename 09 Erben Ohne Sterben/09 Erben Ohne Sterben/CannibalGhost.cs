using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
	class CannibalGhost : Ghost {
		public CannibalGhost(string name) : base(name) { }
		public void Eat(ref Ghost g) {
			IncreaseSize(g.Size);
			g = null;
		}
		public void Eat(ref SlimeGhost g) {
			IncreaseSize(g.Size);
			g = null;
		}
		public void Eat(ref CannibalGhost g) {
			IncreaseSize(g.Size);
			g = null;
		}

		private void IncreaseSize(int size) {
			this.Size += size;
		}
	}


	// Variante mit ausgelagertem Code & OO. Teile und Herrsche!
	//class CannibalGhost : Ghost {
	//	public CannibalGhost(string name) : base(name) { }
	//	public void Eat(ref Ghost g) {
	//		IncreaseSize(g);
	//		g = null;
	//	}
	//	public void Eat(ref SlimeGhost g) {
	//		IncreaseSize(g);
	//		g = null;
	//	}
	//	public void Eat(ref CannibalGhost g) {
	//		IncreaseSize(g);
	//		g = null;
	//	}

	//	private void IncreaseSize(Ghost g) {
	//		this.Size += g.Size;
	//	}
	//}

	// Variante ohne Auslagern
	//class CannibalGhost : Ghost {
	//	public CannibalGhost(string name) : base(name) { }
	//	public void Eat(ref Ghost g) {
	//		this.Size += g.Size;
	//		g = null;
	//	}
	//	public void Eat(ref SlimeGhost g) {
	//		this.Size += g.Size;
	//		g = null;
	//	}
	//	public void Eat(ref CannibalGhost g) {
	//		this.Size += g.Size;
	//		g = null;
	//	}
	//}
}

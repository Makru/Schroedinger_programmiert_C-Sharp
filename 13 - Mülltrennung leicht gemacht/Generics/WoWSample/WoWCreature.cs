namespace Generics.WoWSample {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public abstract class WoWCreature {
		public string Name { get; set; }
		public int Attack { get; set; }
		public int Energy { get; set; }
		public int MaxEnergy { get; set; }
		public void DoAttack(WoWCreature creature) {
			// Die Berechnung ist bestimmt etwas komplexer ;-)
			creature.Energy -= this.Attack;
		}
	}
}

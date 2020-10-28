namespace Generics.WoWSample {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Shaman : WoWCreature, IHealingCreature {
		public int HealingValue { get; set; }

		public void Heal(WoWCreature creature) {
			creature.Energy += this.HealingValue;
			if (creature.Energy > creature.MaxEnergy)
				creature.Energy = creature.MaxEnergy;
		}
	}
}

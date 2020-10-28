namespace Generics.WoWSample {

	public interface IHealingCreature {
		int HealingValue { get; set; }
		void Heal(WoWCreature creature);
	}
}

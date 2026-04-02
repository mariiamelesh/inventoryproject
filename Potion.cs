namespace Inventory {
	public class Potion : Item {
		public double Heal {get; }
		public Potion (string name, double weight, Rarity rarity, double heal) : base (name, weight, rarity) {
			Heal = heal;
		}

		public override void Use(Hero hero) {
			hero.HP += Heal;
			hero.Inventory.Remove(this);
		}

		public override string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight}, heal: +{Heal})";
		}
	}
}

namespace Inventory {
	public class Armor : Item {
		public double Defense {get; }
		public Armor (string name, double weight, Rarity rarity,double defense) : base (name, weight, rarity) {
			Defense = defense;
		}

		public override void Use(Hero hero) {
			hero.Defense += Defense;
		}

		public override string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight}, defense: +{Defense})";
		}
	}
}

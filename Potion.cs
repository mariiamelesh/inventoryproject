namespace Inventory {
	public class Potion : Item {
		public double Heal {get; }
		public Potion (string name, double weight, Rarity rarity, double heal) : base (name, weight, rarity) {
			Heal = heal;
		}

		public override void Use(Hero hero) {
			if (hero.HP == 100) {
				Console.WriteLine("HP is full! Can't use potion");
			} else {
				hero.HP += Heal;
				hero.Inventory.Remove(this);
				Console.WriteLine($"Used {Name}! HP now {hero.HP}");
			}
		}

		public override string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight}, heal: +{Heal})";
		}
	}
}

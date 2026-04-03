namespace Inventory {
	public class Armor : Item {
		public double Defense {get; }
		private int _useCount = 0;
		public Armor (string name, double weight, Rarity rarity,double defense) : base (name, weight, rarity) {
			Defense = defense;
		}

		public override void Use(Hero hero) {
			if (hero.Defense == 100) {
				Console.WriteLine("Defense is full! Cannot use more armor");
			} 
			else if (_useCount == 1) {
				Console.WriteLine("Cannot use armor more than once");
			}
			else {
				hero.Defense += Defense;
				Console.WriteLine($"Used {Name}! Defense now +{hero.Defense}");
			}
		}

		public override string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight}, defense: +{Defense})";
		}
	}
}

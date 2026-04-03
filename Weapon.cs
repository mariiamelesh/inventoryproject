namespace Inventory {
	public class Weapon : Item {
		public double Attack {get; }
		private int _useCount = 0;
		public Weapon (string name, double weight, Rarity rarity, double attack) : base (name, weight, rarity) {
			Attack = attack;
		}

		public override void Use(Hero hero) {
			if (hero.Attack == 100) {
				Console.WriteLine("Attack is full! Cannot use more weapon");
			}
			else if (_useCount == 1) {
				Console.WriteLine("Cannot use weapon more than once");
			}
			else {
				_useCount++;
				hero.Attack += Attack;
				Console.WriteLine($"Used {Name}! Attack now +{hero.Attack}");
			}
		}

		public override string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight}, attack: +{Attack})";
		}
	}
}

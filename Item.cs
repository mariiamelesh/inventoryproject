namespace Inventory {
	public abstract class Item {
		enum Rarity {
			Common,
			Rare, 
			Epic, 
			Legendary
		}
		
		public string Name {get; }
		public double Weight {get; }
		public string Rarity {get; }
		
		public abstract void Use(Hero hero);
		public virtual void GetInfo() {
			Console.WriteLine($"[{Rarity}] {Name} (weight: {Weight})");
		}
	}
}
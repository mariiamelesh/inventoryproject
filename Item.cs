namespace Inventory {
	public enum Rarity {
		Common,
		Rare, 
		Epic, 
		Legendary
	}

	public abstract class Item : IComparable<Item> {
		
		public string Name {get; }
		public double Weight {get; }
		public Rarity Rarity {get; }
		
		public int CompareTo(Item other) {
			if (other == null) return 1;
			return this.Rarity.CompareTo(other.Rarity);
        }

		public Item(string name, double weight, Rarity rarity) {
			Name = name;
			Weight = weight;
			Rarity = rarity;
		}
		
		public abstract void Use(Hero hero);
		public virtual string GetInfo() {
			return $"[{Rarity}] {Name} (weight: {Weight})";
		}
	}
}
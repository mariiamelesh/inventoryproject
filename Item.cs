namespace Inventory {
	public abstract class Item {
		enum Rarity {
			Common,
			Rare, 
			Epic, 
			Legendary
		}
		
		public string Name {get; }
		public int Weight {get; }
		public string Rarity {get; }
		
		public abstract void Use(Hero hero);
	}
}
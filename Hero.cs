namespace Inventory {
	public class Hero {
		public string Name {get; private set; }
		public double HP {get; set; }
		public double Attack {get; set; }
		public double Defense {get; set; }
		
		public Inventory<Item> Inventory {get; private set; }


		public Hero(string name) {
			Name = name;
			HP = 100;
			Attack = 10;
			Defense = 10;
			Inventory = new Inventory<Item>(50);
		}

		public string GetHeroInfo() => $"Hero {Name} (HP: {HP}, ATK: {Attack}, DEF: {Defense})";

		public void ShowInventory() {
			Console.WriteLine($"Inventory | {GetHeroInfo()})");
			Inventory.PrintInventory();
		}
	}
}

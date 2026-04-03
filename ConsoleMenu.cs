namespace Inventory {
	public class ConsoleMenu {
		private Hero _hero;

		public ConsoleMenu(Hero hero)
		{
			_hero = hero;
		}

		public void Run() {
			
			while (true)
			{
				Console.WriteLine("\n--- Menu ---");
				Console.WriteLine("1. Show inventory");
				Console.WriteLine("2. Add item to inventory");
				Console.WriteLine("3. Use item");
				Console.WriteLine("4. Sort inventory by rarity");
				Console.WriteLine("5. Show hero info");
				Console.WriteLine("0. Exit");
				Console.Write("\nChoose action: ");

				var choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						ShowInventory();
						break;
					case "2":
						AddItem();
						break;
					case "3":
						UseItem();
						break;
					case "4":
						Sort();
						break;
					case "5":
						ShowInfo();
						break;
					case "0":
						return;
					default:
						Console.WriteLine("No such option. Try again");
						break;
				}
				
			}
		}
		
		private void ShowInventory() {
			_hero.ShowInventory();
		}
		private void AddItem() {
			Console.WriteLine("Enter item name: ");
			string name = Console.ReadLine() ?? "";
			var item = _hero.Inventory.GameItems.FirstOrDefault(item => item.Name == name);
			if (item == null) {
				Console.WriteLine("No item with such name found");
				return;
			} else {
				_hero.Inventory.Add(item);
			}
		}
		private void UseItem() {
			Console.WriteLine("Enter item name: ");
			string name = Console.ReadLine() ?? "";
			var item = _hero.Inventory.GetByName(name);
			if (item != null) {
				item.Use(_hero);
			}
		}
		private void Sort() {} 
		private void ShowInfo() {}
	}
}
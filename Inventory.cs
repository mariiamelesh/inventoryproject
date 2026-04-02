using System;
using System.Collections; 
using System.Collections.Generic; 
using System.Linq;

namespace Inventory {
	public class Inventory<T> : IEnumerable<T> where T : Item {
		private List<Item> _gameItems = new List<Item> {

			new Weapon("Rusty Sword", 5.0, Rarity.Common, 5.0),
			new Weapon("Dragon Slayer", 12.0, Rarity.Legendary, 45.0),
			new Weapon("Shadow Dagger", 2.5, Rarity.Epic, 18.0),
			new Weapon("Hunter's Bow", 4.0, Rarity.Rare, 12.0),

			new Armor("Leather Vest", 6.0, Rarity.Common, 4.0),
			new Armor("Paladin's Plate", 18.0, Rarity.Legendary, 40.0),
			new Armor("Iron Shield", 10.0, Rarity.Rare, 15.0),
			new Armor("Cloak of Shadows", 1.5, Rarity.Epic, 8.0),

			new Potion("Minor Health Potion", 0.5, Rarity.Common, 20.0),
			new Potion("Greater Healing Elixir", 1.0, Rarity.Epic, 50.0),
			new Potion("Ancient Life Essence", 1.5, Rarity.Legendary, 100.0)
		};
		
		private List <T> _inventory = new List<T>();
		private double _capacity;
		
		public Inventory(double capacity) {
			_capacity = capacity;
		}
		
		
		public IEnumerator<T> GetEnumerator() 
        {
            return _inventory.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }


		private double FreeSpace() {
			return _capacity - _inventory.Sum(item => item.Weight);
		}

		public void Add(T item) {
			double freeSpace = FreeSpace();
			if (item.Weight <= freeSpace) {
				_inventory.Add(item);
				Console.WriteLine($"Success! Item {item.Name} added to inventory");
			}
			else {
				Console.WriteLine($"Failed. Not enough space in inventory. Free space left: {freeSpace}");
			}
		}

		public void Remove(T item) {
			if (_inventory.Contains(item)) {
				_inventory.Remove(item);
				Console.WriteLine($"Success! Item {item.Name} removed from inventory");
			}
			else {
				Console.WriteLine("Failed. Item not found in inventory");
			}
		}

		public void GetByName(string name) {
			Console.WriteLine($"Items with the name {name}:");

			foreach (T item in _inventory) {
				if (item.Name == name) {
					Console.WriteLine(item.GetInfo());
				}
			}
		}

		public void PrintInventory() {
			foreach (Item item in _inventory) {
				Console.WriteLine(item.GetInfo());
			}
		}

		public void ShowCapacity() {
			double freeSpace = FreeSpace();
			Console.WriteLine($"Inventory weight: {_capacity - freeSpace} / {_capacity}");
		}
	}
}

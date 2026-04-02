using System;
using System.Collections; 
using System.Collections.Generic; 
using System.Linq;

namespace Inventory {
	public class Inventory<T> : IEnumerable<T> where T : Item {
		private List <T> _inventory = new List<T>();
		private const double capacity = 50;
		
		
		public IEnumerator<T> GetEnumerator() 
        {
            return _inventory.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }


		private double FreeSpace() {
			return capacity - _inventory.Sum(item => item.Weight);
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
			Console.WriteLine($"Inventory weight: {capacity - freeSpace} / {capacity}");
		}
	}
}

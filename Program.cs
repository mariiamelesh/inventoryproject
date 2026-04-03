namespace Inventory {
	public class Program {
		static void Main(string[] args) {
			var artur = new Hero("Arthur");
			var menu = new ConsoleMenu(artur);
			menu.Run();
		}
	}
}

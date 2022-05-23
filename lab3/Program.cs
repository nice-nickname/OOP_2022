using System;

namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			var console = new ConsoleInteractor();
			while (true)
			{
				console.Run();
				Console.WriteLine("Enter q to exit, press ENTER to re-run");
				var c = Console.ReadKey();
				if (c.Key == ConsoleKey.Q)
				{
					return;
				}
			}
		}
	}
}

namespace lab3
{
	using System;

	public class ConsoleInteractor
	{
		private static readonly ICypherFactory factory = new CypherFactory();

		public void Run()
		{
			var executor = new CypherExecutor();

			Console.WriteLine("Enter cypher name: ");

			var name = Console.ReadLine();
			try
			{
				var cypherStrategy = factory.Create(name);
				cypherStrategy.Alphabet = "abcdefghijklmnopqrstuvwxyz";

				executor.SetStrategy(cypherStrategy);

				Console.WriteLine("Enter string to cypher: ");
				var str = Console.ReadLine();

				var hash = executor.Run(str);

				Console.WriteLine("");
				Console.WriteLine($"SOURCE STRING: {str}");
				Console.WriteLine($"CYPHER STRING: {hash}");
				Console.WriteLine($"ALGORITHM: {name}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return;
			}
		}
	}
}

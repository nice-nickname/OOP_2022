namespace lab3
{
	using System;

	public class CypherExecutor
	{
		private ICypherStrategy strategy;

		public void SetStrategy(ICypherStrategy strategy)
		{
			this.strategy = strategy;
		}

		public string Run(string source)
		{
			return strategy.Action(source);
		}
	}
}

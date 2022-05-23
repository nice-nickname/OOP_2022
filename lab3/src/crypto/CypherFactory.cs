namespace lab3
{
	public interface ICypherFactory
	{
		ICypherStrategy Create(string name);
	}

	public class CypherFactory : ICypherFactory
	{
		public ICypherStrategy Create(string name)
		{
			switch (name)
			{
				case "CAESAR":
					return new CaesarStrategy();
				case "ROT1":
					return new ROT1Strategy();
				case "TRANSPOSITION":
					return new TranspositionStrategy();
				default:
					throw new System.ArgumentOutOfRangeException("Unknown cypher algorithm");
			}
		}
	}
}

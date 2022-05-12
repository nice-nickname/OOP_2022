namespace lab3
{
	class CaesarStrategy : ICypherStrategy
	{
		public string Alphabet { get; set; }

		public string Action(string source)
		{
			int factor = 10;
			source = source.ToLower();
			char[] outString = new char[source.Length];
			for (int i = 0; i < source.Length; i++)
			{
				outString[i] = Alphabet[(Alphabet.IndexOf(source[i]) + factor) % Alphabet.Length];
			}
			return new string(outString);
		}
	}
}

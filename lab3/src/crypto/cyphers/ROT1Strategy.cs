namespace lab3
{

	using System;

	class ROT1Strategy : ICypherStrategy
	{
		public string Alphabet { get; set; }

		public string Action(string source)
		{
			source = source.ToLower();
			char[] outString = new char[source.Length];
			for (int i = 0; i < source.Length; i++)
			{
				outString[i] = Alphabet[(Alphabet.IndexOf(source[i]) + 1) % Alphabet.Length];
			}
			return new string(outString);
		}
	}
}

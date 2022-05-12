using System;

namespace lab3
{
	class TranspositionStrategy : ICypherStrategy
	{
		public string Alphabet { get; set; }

		public string Action(string source)
		{
			var arr = source.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}

namespace lab3
{

	public interface ICypherStrategy
	{
		string Alphabet { get; set; }

		string Action(string source);
	}
}

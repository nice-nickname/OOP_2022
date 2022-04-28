namespace lab1
{
    public class SweetSourSauce : ISauce
    {
        public string Name { get; }

        public string Flavor { get; }

        public SweetSourSauce()
        {
            Name = "Sauce";
            Flavor = "Sweet and Sour";
        }
    }
}

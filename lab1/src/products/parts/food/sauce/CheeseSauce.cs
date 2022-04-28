namespace lab1
{
    public class CheeseSauce : ISauce
    {
        public string Name { get; }

        public string Flavor { get; }

        public CheeseSauce()
        {
            Name = "Sauce";
            Flavor = "Cheese";
        }
    }
}

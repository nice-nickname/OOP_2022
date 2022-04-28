namespace lab1
{
    public class SalsaSauce : ISauce
    {
        public string Name { get; }

        public string Flavor { get; }

        public SalsaSauce()
        {
            Name = "Sauce";
            Flavor = "Salsa";
        }
    }
}

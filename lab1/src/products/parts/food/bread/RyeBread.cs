namespace lab1
{
    public class RyeBread : IBread
    {
        public string Name { get; }

        public string Kind { get; }

        public RyeBread()
        {
            Name = "Bread";
            Kind = "Rye";
        }
    }
}

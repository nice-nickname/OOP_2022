namespace lab1
{
    public class WhiteBread : IBread
    {
        public string Name { get; }

        public string Kind { get; }

        public WhiteBread()
        {
            Name = "Bread";
            Kind = "White";
        }
    }
}

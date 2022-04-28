namespace lab1
{
    public class PorkCutlet : ICutlet
    {
        public string Name { get; }
        public string Meat { get; }

        public PorkCutlet()
        {
            Name = "Cutlet";
            Meat = "Pork";
        }
    }
}

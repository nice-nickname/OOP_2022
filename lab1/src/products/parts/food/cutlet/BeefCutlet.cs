namespace lab1
{
    public class BeefCutlet : ICutlet
    {
        public string Name { get; }
        public string Meat { get; }

        public BeefCutlet()
        {
            Name = "Cutlet";
            Meat = "Beef";
        }
    }
}

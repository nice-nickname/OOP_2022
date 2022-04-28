namespace lab1
{
    public class ChickenCutlet : ICutlet
    {
        public string Name { get; }
        public string Meat { get; }

        public ChickenCutlet()
        {
            Name = "Cutlet";
            Meat = "Chicken";
        }
    }
}

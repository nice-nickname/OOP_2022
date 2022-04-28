namespace lab1
{
    public class Pickle : IVegetable
    {
        public string Name { get; }

        public string Grade { get; }

        public Pickle()
        {
            Name = "Vegetable";
            Grade = "Pickle";
        }
    }
}

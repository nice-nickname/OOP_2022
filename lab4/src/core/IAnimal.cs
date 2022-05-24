namespace lab4
{

    public interface IAnimal : IVisitable
    {
        IAnimalState State { get; set; }
        string Name { get; }
        string Kind { get; }
    }
}

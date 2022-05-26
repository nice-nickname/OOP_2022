namespace lab4
{

    public interface IAnimal : IVisitable
    {
        IAnimalState State { get; set; }
        IFoodState FoodState { get; set; }
        string Name { get; }
        string Kind { get; }
        int ComfortTemperature { get; set; }
    }
}

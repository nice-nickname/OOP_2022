namespace lab4
{
    public interface IAnimalState
    {
        void Handle(IAnimal context);
    }

    public interface IFoodState
    {
        void Handle(IAnimal context);
    }
}

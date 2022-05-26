namespace lab4
{
    public abstract class EmployeeBase : IEmployee
    {
        public abstract void Visit(IAnimal animal);
    }

    public class VetEmployee : EmployeeBase
    {
        public override void Visit(IAnimal animal)
        {
            if (animal.State is AnimalIllState)
            {
                animal.State = new AnimalHealthyState();
            }
        }
    }

    public class DefaultEmployee : EmployeeBase
    {
        public override void Visit(IAnimal animal)
        {
            if (animal.FoodState is AnimalHungryState)
            {
                animal.FoodState = new AnimalFedState();
            }
        }
    }
}

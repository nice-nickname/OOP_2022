namespace lab4
{
    using System.Linq;

    public class AnimalHealthyState : IAnimalState
    {
        public void Handle(IAnimal context)
        {
            if (context.FoodState is AnimalHungryState)
            {
                context.State = new AnimalIllState();
            }
        }
    }

    public class AnimalIllState : IAnimalState
    {
        public void Handle(IAnimal context)
        {
            if (context.FoodState is AnimalHungryState)
            {
                context.State = new AnimalDeadState();
            }
            else if (context.FoodState is AnimalFedState)
            {
                context.State = new AnimalHealthyState();
            }
        }
    }

    public class AnimalDeadState : IAnimalState
    {
        public void Handle(IAnimal context)
        {
        }
    }

    public class AnimalFedState : IFoodState
    {
        public void Handle(IAnimal context)
        {
            context.State.Handle(context);
        }
    }

    public class AnimalHungryState : IFoodState
    {
        public void Handle(IAnimal context)
        {
            context.State.Handle(context);
        }
    }

}

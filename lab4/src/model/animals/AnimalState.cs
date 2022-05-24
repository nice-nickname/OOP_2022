namespace lab4
{
    public class AnimalHealthyState : IAnimalState
    {
        public void PrintMe()
        {
            System.Console.WriteLine("Healthy");
        }
    }

    public class AnimalIllState : IAnimalState
    {
        public void PrintMe()
        {
            System.Console.WriteLine("Ill");
        }
    }

    public class AnimalDeadState : IAnimalState
    {
        public void PrintMe()
        {
            System.Console.WriteLine("Dead");
        }
    }

}

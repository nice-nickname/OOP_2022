namespace lab4
{
    public abstract class Personnel : IEmployee, IVisitor
    {
        public string Name { get; }
        public string LastName { get; set; }

        protected Personnel(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public abstract void Visit(IAnimal animal);
    }


    public class Vet : Personnel
    {
        public Vet(string name, string lastName)
                : base(name, lastName) { }

        public override void Visit(IAnimal animal)
        {

        }
    }


    public class Worker : Personnel
    {
        public Worker(string name, string lastName)
                : base(name, lastName) { }

        public override void Visit(IAnimal animal)
        {

        }
    }
}

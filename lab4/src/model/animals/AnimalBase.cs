namespace lab4
{
    public abstract class AnimalBase : IAnimal
    {
        public IAnimalState State { get; set; }

        public string Name { get; }

        public string Kind { get; }

        protected AnimalBase(string name, string kind)
        {
            Name = name;
            Kind = kind;
            State = new AnimalHealthyState();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
    public abstract class Bird : AnimalBase
    {
        public Bird(string name)
                : base(name, "BIRD") { }
    }

    public abstract class Reptile : AnimalBase
    {
        public Reptile(string name)
                : base(name, "REPTILE") { }
    }

    public abstract class Ungulates : AnimalBase
    {
        public Ungulates(string name)
                : base(name, "UNGULATES") { }
    }

    public class Penguin : Bird
    {
        public Penguin(string name)
                : base(name) { }
    }

    public class Cow : Ungulates
    {
        public Cow(string name)
                : base(name) { }
    }

    public class Crocodile : Reptile
    {
        public Crocodile(string name)
                : base(name) { }
    }
}

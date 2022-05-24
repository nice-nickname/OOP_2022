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
}

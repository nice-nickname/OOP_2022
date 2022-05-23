namespace lab4
{
    public abstract class Animal : IAnimal
    {
        public HealthState State { get; set; }
        public string Name { get; }
        public string Kind { get; }

        protected Animal(string name, string kind)
        {
            Name = name;
            Kind = kind;
            State = HealthState.Healthy;
        }

        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

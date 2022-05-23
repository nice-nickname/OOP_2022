namespace lab4
{
    using System.Collections.Generic;
    using System.Linq;


    public abstract class Aviary : IAviary, IVisitable
    {
        public List<IAnimal> Animals { get; }

        protected Aviary()
        {
            Animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            var kinds = Animals.Select(s => s.Kind).Distinct().ToList();
            if (kinds.Any() && kinds.First() == animal.Kind)
            {
                Animals.Add(animal);
            }
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var animal in Animals)
            {
                animal.Accept(visitor);
            }
        }
    }

    public class OpenAviary : Aviary
    {
        public OpenAviary()
                : base() { }
    }
}

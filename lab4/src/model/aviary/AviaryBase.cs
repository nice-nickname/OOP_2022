namespace lab4
{
    using System.Collections.Generic;

    public abstract class AviaryBase : IAviary
    {
        public List<IAnimal> Animals { get; }

        protected AviaryBase()
        {
            Animals = new List<IAnimal>();
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var animal in Animals)
            {
                animal.Accept(visitor);
            }
        }
    }
}

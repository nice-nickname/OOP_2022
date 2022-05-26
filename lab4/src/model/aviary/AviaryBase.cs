namespace lab4
{
    using System.Collections.Generic;

    public class AviaryTemperatureRegulator : ITemperatureCommand
    {
        public Aviary Aviary { get; set; }
        public void TemperatureUp()
        {
            Aviary.Temperature += 10;
        }

        public void TemperatureDown()
        {
            Aviary.Temperature -= 10;
        }
    }

    public class NoCommand : ITemperatureCommand
    {
        public void TemperatureUp()
        {
        }

        public void TemperatureDown()
        {
        }
    }

    public class Aviary : IAviary
    {
        public int Id { get; set; }
        public OfType Type { get; }
        public List<IAnimal> Animals { get; }
        public ITemperatureCommand Command { get; set; }
        public int Temperature { get; set; }


        public Aviary(OfType type, int id)
        {
            Id = id;
            Animals = new List<IAnimal>();
            Type = type;
            Temperature = 20;
            switch (type)
            {
                case OfType.Open:
                    Command = new NoCommand();
                    break;
                case OfType.Closed:
                    Command = new AviaryTemperatureRegulator() { Aviary = this };
                    break;
            }
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var animal in Animals)
            {
                animal.Accept(visitor);
            }
        }

        public void AddAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }
    }
}

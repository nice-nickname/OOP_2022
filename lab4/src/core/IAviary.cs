namespace lab4
{
    using System.Collections.Generic;

    public enum OfType
    {
        Open,
        Closed
    }

    public interface ITemperatureCommand
    {
        void TemperatureUp();
        void TemperatureDown();

    }

    public interface IAviary : IVisitable
    {
        OfType Type { get; }
        int Temperature { get;set; }
        List<IAnimal> Animals { get; }
        ITemperatureCommand Command { get; set; }
    }
}

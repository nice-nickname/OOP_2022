namespace lab4
{
    public enum HealthState
    {
        Healthy,
        Ill,
        Dead
    }

    public interface IAnimal : IVisitable
    {
        HealthState State { get; set; }
        string Name { get; }
        string Kind { get; }
    }
}

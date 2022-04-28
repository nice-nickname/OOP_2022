namespace lab1
{

    public interface IProduct
    {
        string Name { get; }
    }

    public interface ISauce : IProduct
    {
        string Flavor { get; }
    }

    public interface ICutlet : IProduct
    {
        string Meat { get; }
    }

    public interface IBread : IProduct
    {
        string Kind { get; }
    }

    public interface IVegetable : IProduct
    {
        string Grade { get; }
    }
}

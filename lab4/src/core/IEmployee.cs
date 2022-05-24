namespace lab4
{
    public interface IEmployee : IVisitor
    {
        string Name { get; }
        string LastName { get; set; }
    }
}

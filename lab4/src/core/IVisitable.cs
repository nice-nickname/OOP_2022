namespace lab4
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}

namespace lab4
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; }
        public string LastName { get; set; }

        protected EmployeeBase(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public abstract void Visit(IAnimal animal);
    }
}

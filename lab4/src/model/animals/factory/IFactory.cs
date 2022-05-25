namespace lab4
{
    public interface IFactory
    {
        IAnimal Create(string kind, string name);
    }

    public class AnimalFactory : IFactory
    {
        private AnimalFactory() { }

        public static AnimalFactory Instance { get; } = new AnimalFactory();

        public IAnimal Create(string kind, string name)
        {
            switch (kind)
            {
                case "PENGUIN":
                    return new Penguin(name);
                case "CROCODILE":
                    return new Crocodile(name);
                case "UNGULATES":
                    return new Cow(name);
                default:
                    return null;

            }
        }
    }
}

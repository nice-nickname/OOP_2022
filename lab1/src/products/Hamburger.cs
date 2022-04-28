using System.Collections.Generic;

namespace lab1
{
    using System.Linq;
    using System.Text;

    public class Hamburger
    {

        public IBread Bread { get; set; }

        public ICutlet Cutlet { get; set; }

        public List<IVegetable> Vegetables { get; set; }

        public List<ISauce> Sauces { get; set; }

        public Hamburger()
        {
            Sauces = new List<ISauce>();
            Vegetables = new List<IVegetable>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Hamburger: \n");
            sb.Append($"{Bread.Name} - {Bread.Kind}\n");
            sb.Append($"{Cutlet.Name} - {Cutlet.Meat}\n");


            foreach (var vegetable in Vegetables)
            {
                sb.Append($"{vegetable.Name} - {vegetable.Grade}, ");
            }
            if (Vegetables.Any())
            {
                sb.Append("\n");
            }


            foreach (var sauce in Sauces)
            {
                sb.Append($"{sauce.Name} - {sauce.Flavor}, ");
            }
            if (Vegetables.Any())
            {
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}

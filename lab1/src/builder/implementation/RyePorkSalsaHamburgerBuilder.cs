namespace lab1
{
    public class RyePorkSalsaHamburgerBuilder : HamburgerBuilder
    {
        public RyePorkSalsaHamburgerBuilder() : base()
        {
        }

        public override void SetSauces()
        {
            this.hamburger.Sauces.Add(new SalsaSauce());
        }

        public override void SetBread()
        {
            this.hamburger.Bread = new RyeBread();
        }

        public override void SetCutlet()
        {
            this.hamburger.Cutlet = new PorkCutlet();
        }

        public override void SetVegetables()
        {
            this.hamburger.Vegetables.Add(new Tomato());
        }
    }
}

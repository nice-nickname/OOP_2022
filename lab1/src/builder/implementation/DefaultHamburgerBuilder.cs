namespace lab1
{
    public class DefaultHamburgerBuilder : HamburgerBuilder
    {
        public DefaultHamburgerBuilder() : base()
        {
        }

        public override void SetSauces()
        {
            this.hamburger.Sauces.Add(new CheeseSauce());
            this.hamburger.Sauces.Add(new SalsaSauce());
        }

        public override void SetBread()
        {
            this.hamburger.Bread = new WhiteBread();
        }

        public override void SetCutlet()
        {
            this.hamburger.Cutlet = new BeefCutlet();
        }

        public override void SetVegetables()
        {
            this.hamburger.Vegetables.Add(new Tomato());
            this.hamburger.Vegetables.Add(new Pickle());
        }
    }
}

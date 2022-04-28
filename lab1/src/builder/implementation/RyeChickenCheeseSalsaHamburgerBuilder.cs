namespace lab1
{
    public class RyeChickenCheeseSalsaHamburgerBuilder : HamburgerBuilder
    {
        public RyeChickenCheeseSalsaHamburgerBuilder() : base()
        {
        }

        public override void SetSauces()
        {
            this.hamburger.Sauces.Add(new SalsaSauce());
            this.hamburger.Sauces.Add(new CheeseSauce());
        }

        public override void SetBread()
        {
            this.hamburger.Bread = new RyeBread();
        }

        public override void SetCutlet()
        {
            this.hamburger.Cutlet = new ChickenCutlet();
        }

        public override void SetVegetables()
        {
        }
    }
}

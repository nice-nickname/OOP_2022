namespace lab1
{
    public abstract class HamburgerBuilder
    {
        protected Hamburger hamburger;

        public HamburgerBuilder()
        {
            this.hamburger = new Hamburger();
        }

        public abstract void SetSauces();
        public abstract void SetBread();
        public abstract void SetCutlet();
        public abstract void SetVegetables();

        public Hamburger GetHamburger()
        {
            return this.hamburger;
        }
    }
}

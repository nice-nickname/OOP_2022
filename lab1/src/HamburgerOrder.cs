namespace lab1
{
    public class HamburgerOrder
    {
        public Hamburger CreateHamburger(HamburgerBuilder order)
        {
            order.SetBread();
            order.SetCutlet();
            order.SetVegetables();
            order.SetSauces();
            return order.GetHamburger();
        }
    }
}

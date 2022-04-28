namespace lab1
{
    using System;
    using System.Collections.Generic;

    public class ConsoleInteraction
    {
        private List<Hamburger> hamburgers =  new List<Hamburger>();

        public void Start()
        {
            do
            {
                int command;
                Console.WriteLine("Введите 1, чтобы ввести новый гамбургер");
                Console.WriteLine("Введите 2, чтобы вывести список гамбургеров");
                Console.WriteLine("Введите любое число, чтобы выйти");

                int.TryParse(Console.ReadLine(), out command);
                switch (command)
                {
                    case 1:
                        AddHamburgerCommand();
                        break;
                    case 2:
                        PrintHamburgerCommand();
                        break;

                    default:
                        return;
                }
            }
            while (true);
        }

        private void AddHamburgerCommand()
        {
            var order = new HamburgerOrder();
            Hamburger newHamburger;

            int command;
            Console.WriteLine("Введите 1, чтобы сделать обычный гамбургер (говядина, сырный соус, огурцы и помидоры)");
            Console.WriteLine("Введите 2, чтобы сделать гамбургер (свинина, сальса, помидоры в ржаной булке)");
            Console.WriteLine("Введите 3, чтобы сделать гамбургер (курица, сальса, сырный соус, без овощей в ржаной булке)");
            Console.WriteLine("Введите любое число, чтобы вернуться назад");

            int.TryParse(Console.ReadLine(), out command);
            switch (command)
            {
                case 1:
                    newHamburger = order.CreateHamburger(new DefaultHamburgerBuilder());
                    break;
                case 2:
                    newHamburger = order.CreateHamburger(new RyePorkSalsaHamburgerBuilder());
                    break;
                case 3:
                    newHamburger = order.CreateHamburger(new RyeChickenCheeseSalsaHamburgerBuilder());
                    break;
                default:
                    return;
            }
            this.hamburgers.Add(newHamburger);
        }

        private void PrintHamburgerCommand()
        {
            foreach (var hamburger in this.hamburgers)
            {
                Console.WriteLine(hamburger.ToString());
            }
        }
    }
}

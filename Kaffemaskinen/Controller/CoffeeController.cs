using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;
using Kaffemaskinen.Model.Machines;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    public class CoffeeController
    {
        private WaterContainerController waterContainerController;
        private CoffeeBeanContainerController coffeeBeanContainerController;
        private FilterController filterController;
        public CoffeeController(IWaterContainer water, ICoffeeBeanContainer coffeeBeanContainer, IFilter filter)
        {
            waterContainerController = new WaterContainerController(water);
            coffeeBeanContainerController = new CoffeeBeanContainerController(coffeeBeanContainer);
            filterController = new FilterController(filter);
        }

        private bool running = true;
        public void MainCoffeeController()
        {
            CoffeeDisplay coffeeDisplay = new CoffeeDisplay();

            while (running == true)
            {
                ConsoleKeyInfo key = coffeeDisplay.MainMenu();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            waterContainerController.FillWater();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            filterController.InsertFilter();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            coffeeBeanContainerController.AddBeans();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            waterContainerController.CheackWater();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            filterController.CheckFilter();
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            coffeeBeanContainerController.CheckBeans();
                            break;
                        }
                    case ConsoleKey.D7:
                        {

                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            running = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        public void BrewCoffee()
        {

        }
    }
}

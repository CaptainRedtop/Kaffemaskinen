using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    public class CoffeeController
    {
        public void MainCoffeeController()
        {
            CoffeeDisplay coffeeDisplay = new CoffeeDisplay();
            WaterContainerGUI waterContainerGUI = new WaterContainerGUI();
            WaterContainer waterContainer = new WaterContainer();
            ConsoleKeyInfo key = coffeeDisplay.MainMenu();

            while (true)
            {
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            waterContainer.FillWater(waterContainerGUI.WaterContainerMenu());
                            //waterContainerGUI.WaterLevel();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                break;
            }


            /*
            IWaterContainer waterContainer = new WaterContainer();
            IFilter filter = new CoffeeFilter();
            ICoffeeBeanContainer coffeeBeanContainer = new CoffeeBeanContainer();

            ICoffeeMaker coffeeMaker = new CoffeeMaker(waterContainer, filter, coffeeBeanContainer);

            // Simuler brugerinput
            waterContainer.FillWater(4);
            filter.InsertFilter();
            coffeeBeanContainer.AddBeans(50);

            // Start bryggeprocessen
            coffeeMaker.BrewCoffee();
            */
        }
    }
}

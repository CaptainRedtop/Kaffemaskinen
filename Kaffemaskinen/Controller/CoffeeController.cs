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
            //WaterContainer objects
            WaterContainer waterContainer = new WaterContainer();
            WaterContainerController waterContainerController = new WaterContainerController();
            WaterContainerGUI waterContainerGUI = new WaterContainerGUI();

            //Filter objects
            FilterController filterController = new FilterController();
            CoffeeFilter coffeeFilter = new CoffeeFilter();

            CoffeeDisplay coffeeDisplay = new CoffeeDisplay();

            while (true)
            {
                ConsoleKeyInfo key = coffeeDisplay.MainMenu();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            waterContainerController.WaterController(waterContainer);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            filterController.Filter();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            waterContainerGUI.WaterLevel(waterContainer);
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            waterContainerGUI.WaterLevel(waterContainer);
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            waterContainerGUI.WaterLevel(waterContainer);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

        }
    }
}

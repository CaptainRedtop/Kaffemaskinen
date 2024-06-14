using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.View
{
    internal class CoffeeBeanView
    {
        public int CoffeeBeanMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================\n" +
                "==========Coffeebean Container==========\n" +
                "========================================\n\n" +
                "How many grams of coffeebeans would are you adding to the container?");

            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                new ErrorMessage("Input not a valid number");
            }
            return 0;
        }
        public void CoffeeBeanContainerGui(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public void CheckBeanLevel(ICoffeeBeanContainer coffeeBeanContainer)
        {
            Console.Clear();
            Console.WriteLine($"There are at the moment {coffeeBeanContainer.BeansLevel} grams of coffee beans...");
            Console.ReadKey();
        }
    }
}

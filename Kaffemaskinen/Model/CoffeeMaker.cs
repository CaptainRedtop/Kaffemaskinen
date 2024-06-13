using Kaffemaskinen.Interfaces;
using System;

namespace Kaffemaskinen.Model
{
    public class CoffeeMaker : ICoffeeMaker
    {
        private readonly IWaterContainer waterContainer;
        private readonly IFilter filter;
        private readonly ICoffeeBeanContainer coffeeBeanContainer;

        public CoffeeMaker(IWaterContainer waterContainer, IFilter filter, ICoffeeBeanContainer coffeeBeanContainer)
        {
            this.waterContainer = waterContainer;
            this.filter = filter;
            this.coffeeBeanContainer = coffeeBeanContainer;
        }

        public void BrewCoffee()
        {
            if (waterContainer.WaterLevel == 0)
            {
                Console.WriteLine("Please add water.");
                return;
            }
            if (!filter.HasFilter)
            {
                Console.WriteLine("Please insert filter.");
                return;
            }
            if (coffeeBeanContainer.BeansLevel == 0)
            {
                Console.WriteLine("Please add coffee beans.");
                return;
            }

            Console.WriteLine("Brewing coffee...");
            // Simulate brewing process
            Console.WriteLine("Coffee is ready!");
        }
    }

}

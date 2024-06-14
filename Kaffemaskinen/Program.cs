using Kaffemaskinen.Controller;
using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;

namespace Kaffemaskinen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWaterContainer waterContainer = new WaterContainer();
            ICoffeeBeanContainer coff = new CoffeeBeanContainer();
            IFilter filter = new CoffeeFilter();
            CoffeeController controller = new CoffeeController(waterContainer, coff, filter);
            controller.MainCoffeeController();
        }
    }
}

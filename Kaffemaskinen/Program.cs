using Kaffemaskinen.Controller;

namespace Kaffemaskinen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeController controller = new CoffeeController();
            controller.MainCoffeeController();
        }
    }
}

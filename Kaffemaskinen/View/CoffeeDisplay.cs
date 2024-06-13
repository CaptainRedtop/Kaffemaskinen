using System;

namespace Kaffemaskinen.View
{
    internal class CoffeeDisplay
    {
        public ConsoleKeyInfo MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================\n" +
                    "==========Coffee Display==========\n" +
                    "==================================\n\n" +
                    "1. Add water\n" +
                    "2. Add filter\n" +
                    "3. Add coffeebeans\n" +
                    "4. Brew coffee");

                return Console.ReadKey();
            }
        }
    }
}

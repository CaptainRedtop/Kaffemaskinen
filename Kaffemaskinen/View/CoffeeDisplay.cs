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
                    "4. Check waterlevel\n" +
                    "5. Check if a filter is inserted\n" +
                    "6. Check how many coffeebeans are in the grinder\n" +
                    "7. Brew a cup of coffee\n\n" +
                    "Press ESC to exit...");

                return Console.ReadKey();
            }
        }
    }
}

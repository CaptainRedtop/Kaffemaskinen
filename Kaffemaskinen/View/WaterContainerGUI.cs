using System;
using Kaffemaskinen.Model;
using Kaffemaskinen.View;

namespace Kaffemaskinen.View
{
    internal class WaterContainerGUI
    {
        public int WaterContainerMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================\n" +
                    "==========Watercontainer==========\n" +
                    "==================================\n\n" +
                    "How many cups of water would you like to fill in the container?");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    new ErrorMessage("Input not a valid number");
                }
            }
        }

        public void WaterLevel(WaterContainer waterContainer)
        {
            Console.Clear();
            Console.WriteLine(waterContainer.ToString());
            Console.ReadKey();
        }
    }
}

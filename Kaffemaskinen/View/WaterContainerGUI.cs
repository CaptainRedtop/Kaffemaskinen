using System;
using Kaffemaskinen.Model;
using Kaffemaskinen.View;

namespace Kaffemaskinen.View
{
    internal class WaterContainerGUI
    {
        WaterContainer waterContainer = new WaterContainer();
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
                    break;
                }
                catch
                {
                    new ErrorMessage("Input not a valid number");
                }
            }
            return 0;
        }

        public void WaterLevel()
        {
            Console.WriteLine(waterContainer.WaterLevel.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.View
{
    internal class WaterContainerView
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

        public void WaterLevel(IWaterContainer waterContainer)
        {
            Console.Clear();
            Console.WriteLine(waterContainer.ToString());
            Console.ReadKey();
        }

        public void ErrorMessage(string error)
        {
            Console.Clear();
            Console.WriteLine($"Error: {error}");
            Console.ReadKey();
        }
    }
}

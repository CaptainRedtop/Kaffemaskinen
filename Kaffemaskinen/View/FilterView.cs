using Kaffemaskinen.Interfaces;
using System;

namespace Kaffemaskinen.View
{
    internal class FilterView
    {
        public void FilterMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }
        public void FilterCheck(IFilter coffeeFilter)
        {
            Console.Clear();
            if (coffeeFilter.HasFilter == true)
            {
                Console.WriteLine("A filter is inserted... Good for you!");
            }
            else
            {
                Console.WriteLine("No filter could be found... ");
            }
            Console.ReadKey();
        }
    }
}

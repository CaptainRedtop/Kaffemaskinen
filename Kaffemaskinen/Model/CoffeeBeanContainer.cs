using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class CoffeeBeanContainer : ICoffeeBeanContainer
    {
        private int beansLevel;

        public int BeansLevel => beansLevel;

        public void AddBeans(int amount)
        {
            beansLevel = amount;
            Console.WriteLine($"{amount} grams of coffee beans added.");
        }
    }
}

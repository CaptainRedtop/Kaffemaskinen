using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class CoffeeBeanContainer : ICoffeeBeanContainer
    {
        private int beansLevel;

        public int BeansLevel => beansLevel;

        public string AddBeans(int amount)
        {
            if (beansLevel + amount <= 500)
            {
                beansLevel += amount;
            }
            else
            {
                beansLevel = 500;
                return "Grinder is overflowing!\n" +
                    "Why do you need so many beans?!\n\n" +
                    "Press anything to go back";
            }
            return null;
        }
    }
}

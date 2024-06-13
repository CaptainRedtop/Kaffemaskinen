using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class CoffeeFilter : IFilter
    {
        private bool hasFilter;

        public bool HasFilter => hasFilter;

        public void InsertFilter()
        {
            hasFilter = true;
            Console.WriteLine("Filter inserted.");
        }
    }
}

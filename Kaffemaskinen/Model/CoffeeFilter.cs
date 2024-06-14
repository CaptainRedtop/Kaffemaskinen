using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class CoffeeFilter : IFilter
    {
        private bool hasFilter;

        public bool HasFilter => hasFilter;

        public string InsertFilter()
        {
            if (hasFilter == true)
            {
                return "Filter is already inserted";
            }
            else
            {
                hasFilter = true;
                return "Insterted filter";
            }
        }
    }
}

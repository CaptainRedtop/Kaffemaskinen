using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interfaces
{
    public interface ICoffeeMachine
    {
        string Name { get; }
        string Description { get; }
        object WaterContainer { get; }
        object Filter { get; }
        object BeanCotainer { get; }

        void BrewCoffee();
    }
}

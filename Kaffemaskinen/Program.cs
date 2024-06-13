using Kaffemaskinen.Controller;
using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeController controller = new CoffeeController();
            controller.MainCoffeeController();
        }
    }
}

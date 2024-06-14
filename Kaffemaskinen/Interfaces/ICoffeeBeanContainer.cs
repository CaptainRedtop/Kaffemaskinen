using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interfaces
{
    public interface ICoffeeBeanContainer
    {
        string AddBeans(int amount);
        int BeansLevel { get; }
    }
}

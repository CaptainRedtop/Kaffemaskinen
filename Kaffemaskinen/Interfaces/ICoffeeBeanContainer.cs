﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interfaces
{
    public interface ICoffeeBeanContainer
    {
        void AddBeans(int amount);
        int BeansLevel { get; }
    }
}

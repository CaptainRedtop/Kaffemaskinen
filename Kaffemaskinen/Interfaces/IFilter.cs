﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interfaces
{
    public interface IFilter
    {
        string InsertFilter();
        bool HasFilter { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interfaces
{
    public interface IFilter
    {
        void InsertFilter();
        bool HasFilter { get; }
    }
}

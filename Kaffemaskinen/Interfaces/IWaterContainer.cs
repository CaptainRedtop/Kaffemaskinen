using Kaffemaskinen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kaffemaskinen.Interfaces
{
    public interface IWaterContainer
    {
        void CheckWater(WaterContainer waterContainer);
        string FillWater(int cups);
        int WaterLevel { get; }
    }
}

using System;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class WaterContainer : IWaterContainer
    {
        private int waterLevel;

        public int WaterLevel => waterLevel;

        public void FillWater(int cups)
        {
            while (true)
            {
                waterLevel = cups;
            }
        }
    }
}

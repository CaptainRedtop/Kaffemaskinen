using System;
using Kaffemaskinen.Controller;
using Kaffemaskinen.Interfaces;
using Kaffemaskinen.View;

namespace Kaffemaskinen.Model
{
    public class WaterContainer : IWaterContainer
    { 
        private int waterLevel;

        public int WaterLevel => waterLevel;

        public string FillWater(int cups)
        {
            if (waterLevel + cups <= 15)
            {
                waterLevel += cups;
            }
            else
            {
                waterLevel = 15;
                return ("Too much water!!\n" +
                "Now there are water all over the table, you donk...");
            }
            return null;
        }

        public void CheckWater(WaterContainer waterContainer)
        {
            
        }

        public override string ToString()
        {
            return $"There are enough water for {waterLevel} cups of coffee...";
        }
    }
}

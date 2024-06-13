using System;
using Kaffemaskinen.Controller;
using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen.Model
{
    internal class WaterContainer : IWaterContainer
    {
        WaterContainerController controller = new WaterContainerController();

        private int waterLevel;

        public int WaterLevel => waterLevel;

        public void FillWater(int cups)
        {
            if (waterLevel + cups <= 15)
            {
                waterLevel += cups;
            }
            else
            {
                waterLevel = 15;
                controller.WaterError("Too much water!!\n" +
                "Now there are water all over the table, you donk...");
            }
        }

        public override string ToString()
        {
            return $"There are enough water for {waterLevel} cups of coffee...";
        }
    }
}

using Kaffemaskinen.Model;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    internal class WaterContainerController
    {
        WaterContainerGUI waterContainerGUI = new WaterContainerGUI();
        public void WaterController(WaterContainer waterContainer)
        {
            waterContainer.FillWater(waterContainerGUI.WaterContainerMenu());
        }
        public void WaterError(string error)
        {
            new ErrorMessage(error);
        }
    }
}

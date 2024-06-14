using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    internal class WaterContainerController
    {
        WaterContainerView waterContainerGUI = new WaterContainerView();
        IWaterContainer watercotainer;

        public WaterContainerController(IWaterContainer watercotainer)
        {
            this.watercotainer = watercotainer;
        }

        public void FillWater()
        {
            string message = watercotainer.FillWater(waterContainerGUI.WaterContainerMenu());

            if (message != null)
            {
                waterContainerGUI.ErrorMessage(message);
            }
        }
        public void CheackWater()
        {
            waterContainerGUI.WaterLevel(watercotainer);
        }
    }
}

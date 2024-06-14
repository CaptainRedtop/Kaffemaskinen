using Kaffemaskinen.Interfaces;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    public class CoffeeBeanContainerController
    {
        CoffeeBeanView coffeeBeanView = new CoffeeBeanView();
        ICoffeeBeanContainer coffeeBeanContainer;
        public CoffeeBeanContainerController(ICoffeeBeanContainer coffeeBeanContainer)
        {
            this.coffeeBeanContainer = coffeeBeanContainer;
        }

        public void AddBeans()
        {
            string message = coffeeBeanContainer.AddBeans(coffeeBeanView.CoffeeBeanMenu());
            if (message != null)
            {
                coffeeBeanView.CoffeeBeanContainerGui(message);
            }
        }
        public void CheckBeans()
        {
            coffeeBeanView.CheckBeanLevel(coffeeBeanContainer);
        }
    }
}

using Kaffemaskinen.Interfaces;
using Kaffemaskinen.Model;
using Kaffemaskinen.View;
using System;

namespace Kaffemaskinen.Controller
{
    internal class FilterController
    {
        FilterView filterView = new FilterView();
        IFilter filter;
        public FilterController(IFilter filter)
        {
            this.filter = filter;
        }

        public void InsertFilter()
        {
            string message = filter.InsertFilter();
            filterView.FilterMessage(message);
        }
        public void CheckFilter()
        {
            filterView.FilterCheck(filter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RT_GUI.ViewModels
{
    public abstract class NavigationViewModel
    {
        public INavigation Navigation { get; set; }
    }
}

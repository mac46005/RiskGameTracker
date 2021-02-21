using RT_GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RT_GUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerCountView : ContentPage
    {
        public PlayerCountView(/*PlayerCountViewModel vm*/)
        {
            InitializeComponent();
            //vm.Navigation = Navigation;
            //BindingContext = vm;
            
        }
    }
}
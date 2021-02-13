using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RGT_UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NewGame_Clicked(object sender, EventArgs e)
        {
            Routing.RegisterRoute(nameof(NewGameSetUpPage),typeof(NewGameSetUpPage));
            await Shell.Current.GoToAsync($"{nameof(NewGameSetUpPage)}");
        }
    }
}
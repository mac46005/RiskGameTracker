using RT_GUI.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RT_GUI.ViewModels
{
    public class PlayerCountViewModel : ViewModel
    {
        public PlayerCountViewModel()
        {

        }
        public int SliderValue { get; set; }
        ICommand OnButtonClicked => new Command(async () =>
        {
            await Navigation.PushAsync(Resolver.Resolve<PlayerSetupView>());
        });
    }
}

using RT_GUI.Models;
using RT_GUI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ICommand OnButtonClicked => new Command(async () =>
        {
            var v = Resolver.Resolve<PlayerSetupView>();
            var vm = v.BindingContext as PlayerSetupViewModel;
            vm.playerCount = SliderValue;
            await Navigation.PushAsync(v);
        });
    }
}

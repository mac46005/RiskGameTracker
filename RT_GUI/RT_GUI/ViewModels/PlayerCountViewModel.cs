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

        /// <summary>
        /// The amount of players playing.
        /// </summary>
        public int SliderValue { get; set; }

        /// <summary>
        /// Creates the playerSetup View/ViewModel. Instantiates players and sent to view.
        /// </summary>
        public ICommand OnButtonClicked => new Command(async () =>
        {
            var v = Resolver.Resolve<PlayerSetupView>();
            var vm = v.BindingContext as PlayerSetupViewModel;
            vm.PlayerCount = SliderValue;
            vm.InstantiatePlayers();
            await Navigation.PushAsync(v);
        });
    }
}

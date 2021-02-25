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
    public class PlayerSetupViewModel : ViewModel
    {
        public PlayerSetupViewModel()
        {
        }
        public int PlayerCount { get; set; }

        public ObservableCollection<PLayerViewModel> PlayerList { get; set; } = new ObservableCollection<PLayerViewModel>();
        public void OnPageLoad()
        {
            for (int i = 1; i <= PlayerCount; i++)
            {
                var player = Resolver.Resolve<PlayerModel>();
                player.Id = i;
                PlayerList.Add(CreatePlayer(player));
            }
        }
        private PLayerViewModel CreatePlayer(PlayerModel player)
        {
            var vm = Resolver.Resolve<PLayerViewModel>();
            vm.Player = player;
            return vm;
        }
        public ICommand OnButtonClicked => new Command(async () =>
        {
            var v = Resolver.Resolve<CurrentGameView>();
            var vm = v.BindingContext as CurrentGameViewModel;
            vm.PlayerViewList = PlayerList;
            
            await Navigation.PushAsync(v);
        });
    }
}

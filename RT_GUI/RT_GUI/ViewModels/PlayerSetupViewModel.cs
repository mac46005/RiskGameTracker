using RT_GUI.Models;
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
            OnPageLoad();
        }
        public int playerCount = 0;

        public ObservableCollection<PLayerViewModel> PlayerList { get; set; }
        private void OnPageLoad()
        {
            for (int i = 0; i <= playerCount; i++)
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
    }
}

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
        public int PlayerCount { get; set; }

        public ObservableCollection<PLayerViewModel> PlayerList { get; set; } = new ObservableCollection<PLayerViewModel>();
        private void OnPageLoad()
        {
            for (int i = 0; i <= PlayerCount; i++)
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

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

        /// <summary>
        /// The amount of players playing.
        /// </summary>
        public int PlayerCount { get; set; }


        /// <summary>
        /// The collection of players in the game.
        /// </summary>
        public ObservableCollection<PLayerViewModel> PlayerList { get; set; } = new ObservableCollection<PLayerViewModel>();

        /// <summary>
        /// Creates all the players counted from the PlayerCount and adds them to the PlayerList
        /// </summary>
        public void InstantiatePlayers()
        {
            //for (int i = 1; i <= PlayerCount; i++)
            //{
            //    var player = Resolver.Resolve<PlayerModel>();
            //    player.Id = i;
            //    PlayerList.Add(CreatePlayerVM(player));
            //}
            Risk.InstantiatePlayers(PlayerCount, PlayerList);
        }

        ///// <summary>
        ///// Creates a single new PlayerViewModel with a new PlayerModel 
        ///// </summary>
        ///// <param name="player">PlayerModel</param>
        ///// <returns>PlayerViewModel</returns>
        //private PLayerViewModel CreatePlayerVM(PlayerModel player)
        //{
        //    var vm = Resolver.Resolve<PLayerViewModel>();
        //    vm.Player = player;
        //    return vm;
        //}

        /// <summary>
        /// Sends Created players to the CurrentGameView
        /// </summary>
        public ICommand OnButtonClicked => new Command(async () =>
        {
            var v = Resolver.Resolve<CurrentGameView>();
            var vm = v.BindingContext as CurrentGameViewModel;
            vm.PlayerViewList = PlayerList;
            
            await Navigation.PushAsync(v);
        });
    }
}

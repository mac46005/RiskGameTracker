using RT_GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RT_GUI.Models
{
    public class Risk
    { 
        /// <summary>
        /// The bonus zone on the map.
        /// </summary>
        public static Dictionary<string, int> BonusPoints { get; } = new Dictionary<string, int>
        {
            { "NA",5 },
            { "SA",2 },
            { "AF",3 },
            { "EU",5 },
            { "AU",2 },
            { "AS",7 },
        };


        /// <summary>
        /// Creates a single new PlayerViewModel with a new PlayerModel 
        /// </summary>
        /// <param name="player">PlayerModel</param>
        /// <returns>PlayerViewModel</returns>
        private static PLayerViewModel CreatePlayerVM(PlayerModel player)
        {
            var vm = Resolver.Resolve<PLayerViewModel>();
            vm.Player = player;
            return vm;
        }
        /// <summary>
        /// Creates all the players counted from the PlayerCount and adds them to the PlayerList
        /// </summary>
        public static void InstantiatePlayers(int PlayerCount,ObservableCollection<PLayerViewModel> PlayerList)
        {
            for (int i = 1; i <= PlayerCount; i++)
            {
                var player = Resolver.Resolve<PlayerModel>();
                player.Id = i;
                PlayerList.Add(CreatePlayerVM(player));
            }
        }


        public static void StartingGame(ObservableCollection<PLayerViewModel> PlayerList)
        {
            switch (PlayerList.Count)
            {
                case 2:
                    break;
                default:
                    break;
            }
        }
        private static void ProccessStartingPoints(ObservableCollection<PLayerViewModel> PlayerList)
        {

        }
    }
}

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
        public static ObservableCollection<BonusZone> BonusZones = new ObservableCollection<BonusZone>
        {
            new BonusZone{Name = "North America", NameShort = "NA",ValueAmount = 5},
            new BonusZone{Name = "South America", NameShort = "SA",ValueAmount = 2},
            new BonusZone{Name = "Africa", NameShort = "AF",ValueAmount = 3},
            new BonusZone{Name = "Europe", NameShort = "EU",ValueAmount = 5},
            new BonusZone{Name = "Australia", NameShort = "AU",ValueAmount = 2},
            new BonusZone{Name = "Asia", NameShort = "AS",ValueAmount = 7}
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
    }
}

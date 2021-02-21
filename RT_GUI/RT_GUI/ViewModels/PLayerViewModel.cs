using RT_GUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RT_GUI.ViewModels
{
    public class PLayerViewModel
    {
        public PLayerViewModel(PlayerModel player)
        {
            Player = player;
        }
        public PlayerModel Player { get; set; }
    }
}

using RT_GUI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RT_GUI.ViewModels
{
    public class PLayerViewModel : ViewModel
    {
        public PLayerViewModel()
        { 
        }
        public PlayerModel Player { get; set; }
        ICommand OnPlusClicked => new Command(() =>
        {
            Player.ZonesOccupied = (Player.ZonesOccupied == 0)? Player.ZonesOccupied :  Player.ZonesOccupied + Player.ZonesOccupied++;
        });
        ICommand OnMinusClicked => new Command(() =>
        {
            Player.ZonesOccupied = (Player.ZonesOccupied == 0) ? Player.ZonesOccupied : Player.ZonesOccupied - Player.ZonesOccupied--;
        });
    }
}

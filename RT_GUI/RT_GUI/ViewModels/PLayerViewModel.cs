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

        public ICommand OnPlusClicked => new Command(() =>
        {
            Player.ZonesOccupied++;
        });
        public ICommand OnMinusClicked => new Command(() =>
        {
            Player.ZonesOccupied--;
        });








        ///Bonus Zones Checkbox
        public bool NA { get; set; }
        public bool SA { get; set; }
        public bool AF { get; set; }
        public bool EU { get; set; }
        public bool AU { get; set; }
        public bool AS { get; set; }





    }
}

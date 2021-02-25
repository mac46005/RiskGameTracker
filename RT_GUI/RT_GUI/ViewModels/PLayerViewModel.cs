using RT_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<bool> cbxList;
        private void IsClickedEvent()
        {
            cbxList = new ObservableCollection<bool>() { NA, SA, AF, EU, AU, AS };
            foreach (var cbx in cbxList)
            {
                if (cbx == true)
                {
                    
                }
                else if (cbx == false)
                {

                }
            }

        }

        private int BonusPoints(string area)
        {
            int points = 0;
            switch (area)
            {
                case nameof(NA):
                    break;
            }
            return points;
        }


    }
}

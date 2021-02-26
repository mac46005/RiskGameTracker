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
        private Dictionary<string, int> bonusValues = new Dictionary<string, int>
        {
            { nameof(NA),5 },
            { nameof(SA),2 },
            { nameof(AF),3 },
            { nameof(EU),5 },
            { nameof(AU),2 },
            { nameof(AS),7 },
        };
        //private int AddBonusPoints(string area)
        //{
        //    int points = 0;
        //    switch (area)
        //    {
        //        case nameof(NA):
        //            Player.TotalPoints += 5;
        //            break;
        //        case nameof(SA):
        //            Player.TotalPoints += 2;
        //            break;
        //        case nameof(AF):
        //            Player.TotalPoints += 3;
        //            break;
        //        case nameof(EU):
        //            Player.TotalPoints += 5;
        //            break;
        //        case nameof(AU):
        //            Player.TotalPoints += 2;
        //            break;
        //        case nameof(AS):
        //            Player.TotalPoints += 7;
        //            break;
        //    }
        //    return points;
        //}
        //private int SubstractBonusPoints(string area)
        //{
        //    int points = 0;
        //    switch (area)
        //    {
        //        case nameof(NA):
        //            Player.TotalPoints -= 5;
        //            break;
        //        case nameof(SA):
        //            Player.TotalPoints -= 2;
        //            break;
        //        case nameof(AF):
        //            Player.TotalPoints -= 3;
        //            break;
        //        case nameof(EU):
        //            Player.TotalPoints -= 5;
        //            break;
        //        case nameof(AU):
        //            Player.TotalPoints -= 2;
        //            break;
        //        case nameof(AS):
        //            Player.TotalPoints -= 7;
        //            break;
        //    }
        //    return points;
        //}


        public void AssessBonusPoint()
        {
            int total = 0;
            foreach (var cbx in cbxList)
            {
                if (cbx == true)
                {
                    total += bonusValues[nameof(cbx)];
                }
            }
            if ((Player.TotalPoints - total) == 0)
            {
                return;
            }
            if ((Player.TotalPoints - total) > 0)
            {
                Player.TotalPoints = total;
            }
            if ((Player.TotalPoints - total) < 0)
            {
                Player.TotalPoints = total;
            }

        }
    }
}

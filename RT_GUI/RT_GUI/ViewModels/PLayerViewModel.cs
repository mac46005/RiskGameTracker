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
        private bool _na;
        public bool NA { get { return _na; } set { _na = value; AssessBonusPoints(nameof(NA)); } }

        private bool _sa;
        public bool SA { get { return _sa; } set { _sa = value; AssessBonusPoints(nameof(SA)); } }

        private bool _af;
        public bool AF { get { return _af; } set { _af = value; AssessBonusPoints(nameof(AF)); } }

        private bool _eu;
        public bool EU { get { return _eu; } set { _eu = value; AssessBonusPoints(nameof(EU)); } }

        private bool _au;
        public bool AU { get { return _au; } set { _au = value; AssessBonusPoints(nameof(AU)); } }

        private bool _as;
        public bool AS { get { return _as; } set { _as = value; AssessBonusPoints(nameof(AS)); } }

        private ObservableCollection<bool> cbxList;
        private Dictionary<string, int> bonusValues = new Dictionary<string, int>
        {
            { nameof(NA),5 },
            { nameof(SA),2 },
            { nameof(AF),3 },
            { nameof(EU),5 },
            { nameof(AU),2 },
            { nameof(AS),7 },
        };

        public void AssessBonusPoints(string nameofBool)
        {
            int total = 0;
            cbxList = new ObservableCollection<bool> { NA, SA, AF, EU, AU, AS };
            int ptsWthNoSpoints = Player.TotalPoints - Player.SoldierCount;
            foreach (var cbx in cbxList)
            {
                if (cbx == true)
                {
                    total += bonusValues[nameofBool];
                }
            }
            if ((ptsWthNoSpoints - total) == 0)
            {
                return;
            }
            if ((ptsWthNoSpoints - total) > 0)
            {
                var subtractAmount = ptsWthNoSpoints - total;
                Player.TotalPoints -= subtractAmount;
            }
            if ((ptsWthNoSpoints - total) < 0)
            {
                var addAmount = total - ptsWthNoSpoints;
                Player.TotalPoints += addAmount;
            }

        }
    }
}

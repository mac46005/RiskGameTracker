using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RT_GUI.Models
{
    public class PlayerModel : Model
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        private int _zonesOccupied;
        public int ZonesOccupied 
        {
            get => _zonesOccupied;
            set
            {
                _zonesOccupied = value;
                OnPropertyChanged(nameof(ZonesOccupied),nameof(SoldierCount));
            }
        }
        
        public int SoldierCount 
        {
            get => ZonesOccupied / 3;
        }

        //public string[] BonusZones { get; set; }

        private int _totalPoints;
        public int TotalPoints 
        {
            get { return _totalPoints + SoldierCount; }
            set
            {
                _totalPoints =  value;
            }

        } 
    }
}

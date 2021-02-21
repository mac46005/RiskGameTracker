using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RT_GUI.Models
{
    public class PlayerModel
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ZonesOccupied { get; set; }
        public int SoldierCount { get; set; }
        public string[] BonusZones { get; set; }
    }
}

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
        public string Name { get; set; }
        public int ZonesOccupied { get; set; } = 0;
        public int SoldierCount { get; set; } = 0;
        public string[] BonusZones { get; set; }
    }
}

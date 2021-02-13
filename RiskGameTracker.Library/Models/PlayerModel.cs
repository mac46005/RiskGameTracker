using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiskGameTracker.Library.Models
{
    public class PlayerModel
    {
        [PrimaryKey,Unique]
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int ZonesOccupied { get; set; }
        public int BonusAmount { get; set; }
        public int SoldierAmount { get; set; }
    }
}

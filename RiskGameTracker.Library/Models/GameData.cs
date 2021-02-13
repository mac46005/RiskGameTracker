using System;
using System.Collections.Generic;
using System.Text;
using SQLitePCL;
using SQLite;

namespace RiskGameTracker.Library.Models
{
    public class GameData
    {
        [PrimaryKey,Unique]
        public int Id { get; set; }
        public int NumOfPlayers { get; set; } = 2;
    }
}

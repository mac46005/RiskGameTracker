﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RT_GUI.Models
{
    public class RiskModel
    {
        /// <summary>
        /// The bonus zone on the map.
        /// </summary>
        public static ObservableCollection<BonusZone> BonusZones = new ObservableCollection<BonusZone>
        {
            new BonusZone{Name = "North America", NameShort = "NA",ValueAmount = 5},
            new BonusZone{Name = "South America", NameShort = "SA",ValueAmount = 2},
            new BonusZone{Name = "Africa", NameShort = "AF",ValueAmount = 3},
            new BonusZone{Name = "Europe", NameShort = "EU",ValueAmount = 5},
            new BonusZone{Name = "Australia", NameShort = "AU",ValueAmount = 2},
            new BonusZone{Name = "Asia", NameShort = "AS",ValueAmount = 7}
        };
    }
}

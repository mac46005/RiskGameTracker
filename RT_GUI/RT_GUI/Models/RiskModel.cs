using System;
using System.Collections.Generic;
using System.Text;

namespace RT_GUI.Models
{
    public class RiskModel
    {
        /// <summary>
        /// The bonus zone on the map.
        /// </summary>
        public static readonly Dictionary<int, string> BonusZones = new Dictionary<int, string>()
        {
            {0,"NA" },{1,"SA" },{2,"AF" },{3,"EU" },{4,"AU" },{5,"AS" }
        };
    }
}

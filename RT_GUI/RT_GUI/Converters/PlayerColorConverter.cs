using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace RT_GUI.Converters
{
    public class PlayerColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] rCol = { "Green","Yellow","Orange","Black","Blue" };

            Color playerColor = Color.Default;
            string strVal = (string)value;
            if (strVal == rCol[0])
            {
                //Green
                playerColor = Color.FromHex("00cc00");
            }
            else if (strVal == rCol[1])
            {
                //Yellow
                playerColor = Color.FromHex("#cccc00");
            }
            else if (strVal == rCol[2])
            {
                //Orange
                playerColor = Color.FromHex("#ff531a");
            }
            else if (strVal == rCol[3])
            {
                //Black
                playerColor = Color.FromHex("#454545");
            }
            else if(strVal == rCol[4])
            {
                //Blue
                playerColor = Color.FromHex("#1a1aff");
            }
            return playerColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

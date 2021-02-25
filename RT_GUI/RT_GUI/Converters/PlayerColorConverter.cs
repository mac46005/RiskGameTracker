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
            string[] rCol = { "Green","Yellow","Red","Black","Blue" };

            Color playerColor = Color.Default;
            string strVal = (string)value;
            if (strVal == rCol[0])
            {
                playerColor = Color.Green;
            }
            else if (strVal == rCol[1])
            {
                playerColor = Color.Yellow;
            }
            else if (strVal == rCol[2])
            {
                playerColor = Color.Red;
            }
            else if (strVal == rCol[3])
            {
                playerColor = Color.Black;
            }
            return playerColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

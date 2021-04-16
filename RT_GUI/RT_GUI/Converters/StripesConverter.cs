using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace RT_GUI.Converters
{
    public class StripesConverter : IValueConverter
    {
        private static int flipCount = 0;
        public static string[] FlipColor = { };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (flipCount == 0)
            {
                flipCount = 1;
                return Color.FromHsla(0, 0, 0, 0);
            }
            else
            {
                flipCount = 0;
                return Color.FromHsla(0, 0, 0, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

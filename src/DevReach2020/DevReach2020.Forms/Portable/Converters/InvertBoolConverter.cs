using System;
using System.Globalization;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.Converters
{
    public class InvertBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool val)
            {
                return !val;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool val)
            {
                return !val;
            }
            return value;
        }
    }
}

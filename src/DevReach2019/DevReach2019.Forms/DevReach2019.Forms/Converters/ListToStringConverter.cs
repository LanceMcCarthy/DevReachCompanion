using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace DevReach2019.Forms.Converters
{
    public class ListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join(",", (IEnumerable<string>)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

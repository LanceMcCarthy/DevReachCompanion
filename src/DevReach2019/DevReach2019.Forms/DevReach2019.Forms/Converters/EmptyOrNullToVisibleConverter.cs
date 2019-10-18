using System;
using System.Globalization;
using Xamarin.Forms;

namespace DevReach2019.Forms.Converters
{
    public class EmptyOrNullToVisibleConverter : IValueConverter
    {
        public bool ShowWhenNull { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isVisible = true;

            switch (value)
            {
                case null:
                    isVisible = false;
                    break;
                case string textValue:
                    isVisible = !string.IsNullOrEmpty(textValue);
                    break;
                default:
                    isVisible = true;
                    break;
            }

            if (ShowWhenNull)
            {
                return !isVisible;
            }
            else
            {
                return isVisible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

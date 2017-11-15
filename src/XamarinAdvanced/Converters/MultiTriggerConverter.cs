using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinAdvanced.Converters
{
    public class MultiTriggerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrWhiteSpace((string)value))
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

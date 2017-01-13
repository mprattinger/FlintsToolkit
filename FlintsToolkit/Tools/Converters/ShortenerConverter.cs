using FlintsToolkit.Tools.Extensions;
using System;
using System.Globalization;
using System.Windows.Data;

namespace FlintsToolkit.Tools.Converters
{
    public class ShortenerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var v = (string)value;
                return v.Truncate(20);
            }
            catch (Exception)
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

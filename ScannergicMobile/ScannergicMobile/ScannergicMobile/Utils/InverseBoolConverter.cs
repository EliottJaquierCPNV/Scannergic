using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScannergicMobile.Utils
{
    /// <summary>
    /// Invert the value of an object / we can't simply ! in the form cause Xamarin is mean :)
    /// </summary>
    public class InverseBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScannergicMobile.Utils
{
    /// <summary>
    /// Invert the value of an object (used in XAML)
    /// </summary>
    public class InverseBoolConverter : IValueConverter
    {
        /// <summary>
        /// Convert the object to the new value (inverted)
        /// </summary>
        /// <param name="value">The initial value</param>
        /// <param name="targetType">The targetted type (not used)</param>
        /// <param name="parameter">Parameters (not used)</param>
        /// <param name="culture">The culture infos (not used)</param>
        /// <returns>The initial value inverted</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
        /// <summary>
        /// Reverse the conversion (inverted object)
        /// </summary>
        /// <param name="value">The initial value</param>
        /// <param name="targetType">The targetted type (not used)</param>
        /// <param name="parameter">Parameters (not used)</param>
        /// <param name="culture">The culture infos (not used)</param>
        /// <returns>The initial value inverted</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}

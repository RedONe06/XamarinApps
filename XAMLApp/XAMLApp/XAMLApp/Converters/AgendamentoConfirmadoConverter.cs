using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XAMLApp.Converters
{
    public class AgendamentoConfirmadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool confirmado = (bool)value;
            Color color = confirmado ? Color.Black : Color.Red;
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool confirmado = (bool)value;
            Color color = confirmado ? Color.Black : Color.Red;
            return color;
        }
    }
}

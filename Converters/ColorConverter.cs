using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var percentaje = (double)value;

            if (percentaje < 50) return Color.FromArgb("#17A100");
            if (percentaje < 75) return Color.FromArgb("#FFA012");
            if (percentaje < 90) return Color.FromArgb("#E46415");
            return Color.FromArgb("#E81D1D");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

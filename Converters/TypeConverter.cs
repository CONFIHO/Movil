using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.Converters
{
    public class TypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (int)value;

            switch (data)
            {
                case 4:
                    return "Ropa";
                case 5:
                    return "Personal";
                case 3:
                    return "Hogar";
                case 1:
                    return "Alimentacion";
                case 2:
                    return "Estudio";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

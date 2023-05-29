using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.Converters
{
    public class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (int)value;

            switch (data)
            {
                case 4:
                    return "icon_clothes.svg";
                case 5:
                    return "icon_personal.svg";
                case 3:
                    return "icon_home.svg";
                case 1:
                    return "icon_food.svg";
                case 2:
                    return "icon_study.svg";
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

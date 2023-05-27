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
            var data = value as string;

            switch (data)
            {
                case "Ropa":
                    return "icon_clothes.svg";
                case "Personal":
                    return "icon_personal.svg";
                case "Hogar":
                    return "icon_home.svg";
                case "Comida":
                    return "icon_food.svg";
                case "Estudio":
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

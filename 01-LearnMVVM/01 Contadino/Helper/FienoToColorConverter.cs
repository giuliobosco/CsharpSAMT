using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _01_Contadino.Helper
{
    public class FienoToColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is int) {
                int a = (int)value;

                if (a < 20) {
                    return new SolidColorBrush(Colors.Green);
                }
                if (a <= 35) {
                    return new SolidColorBrush(Colors.Yellow);
                }

                return new SolidColorBrush(Colors.Red);
            }

            return new SolidColorBrush(Colors.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}

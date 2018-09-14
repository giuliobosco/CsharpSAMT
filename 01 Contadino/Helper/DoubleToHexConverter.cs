using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _01_Contadino.Helper {
    public class DoubleToHexConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null)
                return "-";
            if (value is double) {
                double a = (double)value;
                int b = (int)a;
                return "#" + b.ToString("X2");

            }
            return "ERROR";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is string) {
                string a = (string)value;

                if (a.Length == 1) {
                    a = "0" + a;
                }

                if ((a.StartsWith("#") && a.Length == 3) || (a.Length == 2)) {
                    return System.Convert.ToInt32(a.Substring(a.Length - 2, 2), 16);
                }

                return -1;
            } else {
                return "XX";
            }
        }
    }
}

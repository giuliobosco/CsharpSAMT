using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _07_Password.Helper {
    class BytesToStringConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is byte[]) {
                byte[] bytes = (byte[]) value;
                string ret = "";

                for (int i = 0; i < bytes.Length; i++) {
                    ret += char.ToString((char)bytes [i]);
                }

                return ret;
            }
            else {
                return "ERROR";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is string) {
                string s = (string) value;
                byte[] bytes = new byte[s.Length];

                for (int i = 0; i < s.Length; i++) {
                    bytes[i] = System.Convert.ToByte(s[i]);
                }

                return bytes;
            }
            else {
                return null;
            }
        }
    }
}

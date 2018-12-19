using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using _08_CoffeeShop.DA.Model;

namespace _08_CoffeeShop.Helper {
    public class CoffeeToImageConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            try {
                int id = (int) value;

                string imgPath = "/Images/" + id + ".jpg";

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(imgPath, UriKind.RelativeOrAbsolute);
                img.EndInit();

                return img;

            }
            catch (FormatException fe) {
                throw fe;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}

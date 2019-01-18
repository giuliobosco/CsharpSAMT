using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace _04_Weather.Helper {
    public class WeatherIconConverter : IMultiValueConverter {
        public object Convert(object [] values, Type targetType, object parameter, CultureInfo culture) {
            if (values.Length == 2) {
                try {
                    int id = (int)values [0];
                    string iconId = (string)values [1];

                    if (id == 0 || string.IsNullOrWhiteSpace(iconId)) {
                        return Binding.DoNothing;
                    }

                    string timePeriod = iconId.Substring(2, 1);
                    string imgPath = "";

                    if (id >= 200 && id < 300) imgPath = "thunderstorm.png";
                    else if (id >= 300 && id < 500) imgPath = "drizzle.png";
                    else if (id >= 500 && id < 600) imgPath = "rain.png";
                    else if (id >= 600 && id < 700) imgPath = "snow.png";
                    else if (id >= 700 && id < 800) imgPath = "atmosphere.png";
                    else if (id == 800) imgPath = (timePeriod == "d") ? "clear_day.png" : "clear_night.png";
                    else if (id == 801) imgPath = (timePeriod == "d") ? "few_clouds_day.png" : "few_clouds_night.png";
                    else if (id == 802 || id == 803) imgPath = (timePeriod == "d") ? "broken_clouds_day.png" : "broken_clouds_night.png";
                    else if (id == 804) imgPath = "overcast_clouds.png";
                    else if (id >= 900 && id < 903) imgPath = "extreme.png";
                    else if (id == 903) imgPath = "cold.png";
                    else if (id == 904) imgPath = "hot.png";
                    else if (id == 905 || id >= 951) imgPath = "windy.png";
                    else if (id == 906) imgPath = "hail.png";

                    BitmapImage img = new BitmapImage();
                    img.BeginInit();
                    img.UriSource = new Uri("/Images/" + img, UriKind.RelativeOrAbsolute);
                    img.EndInit();

                    return img;
                } catch (FormatException fe) {
                    throw fe;
                }
            } else {
                return Binding.DoNothing;
            }
        }

        public object [] ConvertBack(object value, Type [] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}

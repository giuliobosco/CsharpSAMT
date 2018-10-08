using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model;
using System.Net.Http;
using System.Xml.Linq;
using System.IO;
using System.Windows;

namespace _04_Weather.Services {
    public class OwmService : IOwmService {
        #region =================== costanti ===================
        private const string BASEURL = "http://api.openweathermap.org/data/2.5/";
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private HttpClient client;
        private IKeyService ks;
        #endregion

        #region =================== costruttori ================
        public OwmService() {
            client = new HttpClient();
            client.BaseAddress = new Uri(BASEURL);
            ks = new KeyService();
        }
        #endregion

        #region =================== metodi aiuto ===============
        private string ConstructUrl(string city) {
            string query = "weather?q=" + city + "&appid=" + ks.GetKey();
            return BASEURL + query + "&mode=xml&units=metric";
        }

        private OpenWeatherMap getOwmFromXml(string stringElement) {
            var e = XElement.Load(new StringReader(stringElement));

            OpenWeatherMap owm = new OpenWeatherMap();

            // Load city elements
            owm.City.Id = int.Parse(e.Element("city").Attribute("id").Value);
            owm.City.Name = e.Element("city").Attribute("name").Value;
            owm.City.Country = e.Element("city").Element("country").Value;
            owm.City.Coordinates = new Point(
                double.Parse(e.Element("city").Element("coord").Attribute("lon").Value),
                double.Parse(e.Element("city").Element("coord").Attribute("lat").Value));
            owm.City.Sunrise = DateTime.Parse(e.Element("city").Element("sun").Attribute("rise").Value);
            owm.City.Sunset = DateTime.Parse(e.Element("city").Element("sun").Attribute("set").Value);

            // Load Temperature
            owm.Temperature.MinValue = double.Parse(e.Element("temperature").Attribute("min").Value);
            owm.Temperature.MaxValue = double.Parse(e.Element("temperature").Attribute("max").Value);
            owm.Temperature.Value = double.Parse(e.Element("temperature").Attribute("value").Value);

            // Humidity
            owm.Humidity = double.Parse(e.Element("humidity").Attribute("value").Value);

            // pressure
            owm.Pressure = double.Parse(e.Element("pressure").Attribute("value").Value);

            // wind
            owm.Wind.Speed = double.Parse(e.Element("wind").Element("speed").Attribute("value").Value);
            owm.Wind.Name = e.Element("wind").Element("speed").Attribute("name").Value;
            owm.Wind.WindDirection = double.Parse(e.Element("wind").Element("direction").Attribute("value").Value);
            owm.Wind.WindCode = e.Element("wind").Element("direction").Attribute("code").Value;
            owm.Wind.WindName = e.Element("wind").Element("direction").Attribute("name").Value;

            // clouds
            owm.Clouds.Value = double.Parse(e.Element("clouds").Attribute("value").Value);
            owm.Clouds.Name = e.Element("clouds").Attribute("name").Value;

            owm.Visibility = double.Parse(e.Element("visibility").Attribute("value").Value);
            owm.Precipitation = double.Parse(e.Element("precipitation").Attribute("value").Value);

            // Weather
            owm.Weather.Id = int.Parse(e.Element("weather").Attribute("number").Value);
            owm.Weather.Icon = e.Element("weather").Attribute("icon").Value;
            owm.Weather.Description = e.Element("Weather").Attribute("value").Value;

            // last update
            owm.LastUpdate = DateTime.Parse(e.Element("lastupdate").Attribute("value").Value);
            return owm;
        }
        #endregion

        #region =================== metodi generali ============
        public OpenWeatherMap GetWeatherForecast(string city) {
            if (!string.IsNullOrWhiteSpace(city)) {
                try {
                    string path = ConstructUrl(city);
                    var result = client.GetStringAsync(path).Result;

                    OpenWeatherMap owm = this.getOwmFromXml(result);
                    return owm;
                } catch (Exception) {

                    throw;
                }
            } else {
                throw new ArgumentNullException("City cannot be null");
            }
        }
        #endregion
    }
}

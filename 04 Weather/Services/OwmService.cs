using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model;
using System.Net.Http;
using System.Xml.Linq;
using System.IO;

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
        #endregion

        #region =================== metodi generali ============
        public OpenWeatherMap GetWeatherForecast(string city) {
            if (!string.IsNullOrWhiteSpace(city)) {
                try {
                    string path = ConstructUrl(city);
                    var result = client.GetStringAsync(path).Result;

                    var x = XElement.Load(new StringReader(result));

                    OpenWeatherMap owm = new OpenWeatherMap();

                    owm.City.Name = x.Element("city").Attribute("name").Value;

                    owm.Temperature.MinValue = double.Parse(x.Element("temperature").Attribute("min").Value);
                    owm.Temperature.MaxValue = double.Parse(x.Element("temperature").Attribute("max").Value);
                    owm.Temperature.Value = double.Parse(x.Element("temperature").Attribute("value").Value);

                    // ws.WindDirection = x.Element("wind").Element("direction").Attribute("name").Value;

                    owm.Weather.Id = int.Parse(x.Element("weather").Attribute("number").Value);
                    owm.Weather.Icon = x.Element("weather").Attribute("icon").Value;
                    owm.Weather.Description = x.Element("weather").Attribute("value").Value;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model;
using _04_Weather.Model.Weather;
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

        /*
         * Get the city object form the xml city element.
         * 
         * @param e XML city element.
         * @return City object with the information on the XML element.
         */
        public City getCity(XElement e) {
            // create city
            City city = new City();

            // Load elements
            city.Id = int.Parse(e.Attribute("id").Value);
            city.Name = e.Attribute("name").Value;
            city.Country = e.Element("country").Value;
            city.Coordinates = new Point(
                double.Parse(e.Element("coord").Attribute("lon").Value),
                double.Parse(e.Element("coord").Attribute("lat").Value));
            city.Sunrise = DateTime.Parse(e.Element("sun").Attribute("rise").Value);
            city.Sunset = DateTime.Parse(e.Element("sun").Attribute("set").Value);

            return city;
        }

        /**
         * Get the Temperature object form the XML temperature element.
         * 
         * @param e XML temperature element.
         * @return Temperature object with the information on the XML element.
         */
        private Temperature getTemperature(XElement e) {
            // create temperature object.
            Temperature t = new Temperature();

            // Load data
            t.MinValue = double.Parse(e.Attribute("min").Value);
            t.MaxValue = double.Parse(e.Attribute("max").Value);
            t.Value = double.Parse(e.Attribute("value").Value);

            return t;
        }

        /**
         * Get the Wind object form the XML temperature element.
         * 
         * @param e XML wind element.
         * @return Wind object with the information on the XML element.
         */
        private Wind getWind(XElement e) {
            // create wind object.
            Wind wind = new Wind();

            // Load data
            wind.Speed = double.Parse(e.Element("speed").Attribute("value").Value);
            wind.Name = e.Element("speed").Attribute("name").Value;
            wind.WindDirection = double.Parse(e.Element("direction").Attribute("value").Value);
            wind.WindCode = e.Element("direction").Attribute("code").Value;
            wind.WindName = e.Element("direction").Attribute("name").Value;

            return wind;
        }

        /**
         * Get the Weather object form the XML temperature element.
         * 
         * @param e XML weather element.
         * @return Weather object with the information on the XML element.
         */
         private Weather getWeather(XElement e) {
            // create weather element.
            Weather w = new Weather();

            // Load data
            w.Id = int.Parse(e.Attribute("number").Value);
            w.Icon = e.Attribute("icon").Value;
            w.Description = e.Attribute("value").Value;

            return w;
        }

        /**
         * Get the clouds object form the XML temperature element.
         * 
         * @param e XML clouds element.
         * @return clouds object with the information on the XML element.
         */
        private Clouds getClouds(XElement e) {
            // create clouds element
            Clouds c = new Clouds();

            // load data
            c.Value = double.Parse(e.Attribute("value").Value);
            c.Name = e.Attribute("name").Value;

            return c;
        }

        /**
         * Get the OpenWeatherMap object form the XML.
         * 
         * @param stringElement String XML data.
         * @return The OpenWeatherMap object.
         */
        private OpenWeatherMap getOwmFromXml(string stringElement) {
            var e = XElement.Load(new StringReader(stringElement));

            OpenWeatherMap owm = new OpenWeatherMap();

            // Load city elements
            owm.City = this.getCity(e.Element("city"));
            // Load Temperature
            owm.Temperature = this.getTemperature(e.Element("temperature"));
            // Humidity
            owm.Humidity = double.Parse(e.Element("humidity").Attribute("value").Value);
            // pressure
            owm.Pressure = double.Parse(e.Element("pressure").Attribute("value").Value);
            // wind
            owm.Wind = this.getWind(e.Element("wind"));
            // clouds
            owm.Clouds = this.getClouds(e.Element("clouds"));
            // visibility
            owm.Visibility = double.Parse(e.Element("visibility").Attribute("value").Value);
            // precipitation
            owm.Precipitation = double.Parse(e.Element("precipitation").Attribute("value").Value);
            // Weather
            owm.Weather = this.getWeather(e.Element("weather"));
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

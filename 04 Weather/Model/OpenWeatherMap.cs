using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model.Weather;

namespace _04_Weather.Model {
    public class OpenWeatherMap {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        public City City { get; set; }

        public Temperature Temperature { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        public Wind Wind { get; set; }

        public Clouds Clouds { get; set; }

        public double Visibility { get; set; }

        public string Precipitation { get; set; }

        public Weather.Weather Weather { get; set; }

        public DateTime LastUpdate { get; set; }
        #endregion

        #region =================== constructors ===============
        public OpenWeatherMap() {
            this.City = new City();
            this.Temperature = new Temperature();
            this.Wind = new Wind();
            this.Clouds = new Clouds();
            this.Weather = new Weather.Weather();
        }
        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

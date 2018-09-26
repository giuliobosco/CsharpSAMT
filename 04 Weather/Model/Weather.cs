using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _04_Weather.Model {
    public class Weather {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & propriet‡ =========

        /**
         * Weather coordinates.
         */
        private Point coordinates;
        public Point Coordinates {
            get { return this.coordinates; }
            set { this.coordinates = value; }
        }

        /**
         * More info Weather condition codes.
         */
        private WeatherCondition weatherCondition;
        public WeatherCondition WeatherCondition {
            get { return this.weatherCondition; }
            set { this.weatherCondition = value; }
        }

        /**
         * Internal parameter
         */
        private string baseParam;
        public string BaseParam {
            get { return this.baseParam; }
            set { this.baseParam = value; }
        }

        /**
         * Temperature. 
         * Unit Default: Kelvin.
         */
        private double temp;
        public double Temp {
            get { return temp; }
            set { temp = value; }
        }

        /**
         * Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data).
         * Unit: hPa.
         */
        private double pressure;
        public double Pressure {
            get { return pressure; }
            set { pressure = value; }
        }

        /**
         * Humidity.
         * Unit: %.
         */
        private double humidity;
        public double Humidity {
            get { return humidity; }
            set { humidity = value; }
        }

        /**
         * Minimum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). 
         * Unit Default: Kelvin.
         */
        private double tempMin;
        public double TempMin {
            get { return tempMin; }
            set { tempMin = value; }
        }

        /**
         * Maximum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). 
         * Unit Default: Kelvin.
         */
        private double tempMax;
        public double TempMax {
            get { return tempMax; }
            set { tempMax = value; }
        }

        /**
         * Atmospheric pressure on the sea level.
         * Unit: hPa.
         */
        private double seaLevel;
        public double SeaLevel {
            get { return seaLevel; }
            set { seaLevel = value; }
        }

        /**
         * Atmospheric pressure on the ground level.
         * Unit: hPa.
         */
        private double grndLevel;
        public double GrndLevel {
            get { return grndLevel; }
            set { grndLevel = value; }
        }

        /**
         * Wind
         */
        private Vector wind;
        public Vector Wind {
            get { return wind; }
            set { wind = value; }
        }

        /**
         * Cloudiness.
         * Unit: %.
         */
        private double clouds;
        public double Clouds {
            get { return clouds; }
            set { clouds = value; }
        }

        /**
         * Rain volume for the last 3 hours.
         */
        private double rain;
        public double Rain {
            get { return rain; }
            set { rain = value; }
        }

        /**
         * Snow volume for the last 3 hours.
         */
        private double snow;
        public double Snow {
            get { return snow; }
            set { snow = value; }
        }

        /**
         * Time of data calculation, unix, UTC
         */
        private long dt;
        public long Dt {
            get { return dt; }
            set { dt = value; }
        }

        /**
         * City ID.
         */
        private int id;
        public int Id {
            get { return id; }
            set { id = value; }
        }

        /**
         * City name.
         */
        private string city;
        public string City {
            get { return city; }
            set { city = value; }
        }

        /**
         * Internal parameter.
         */
        private string cod;
        public string Cod {
            get { return cod; }
            set { cod = value; }
        }


        #endregion

        #region =================== costruttori ================
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}

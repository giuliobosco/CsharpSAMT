using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _04_Weather.Model.Weather {
    public class City {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        private int id;
        public int Id {
            get { return this.id; }
            set {
                if (value > 0) {
                    this.id = value;
                }
            }
        }

        private string name;
        public string Name {
            get { return this.name; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.name = value;
                }
            }
        }

        private Point coordinates;
        public Point Coordinates {
            get { return this.coordinates; }
            set { this.coordinates = value; }
        }

        private string country;
        public string Country {
            get { return this.country; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.country = value;
                }
            }
        }

        private DateTime sunrise;
        public DateTime Sunrise {
            get { return this.sunrise; }
            set { this.sunrise = value; }
        }

        private DateTime sunset;
        public DateTime Sunset {
            get { return this.sunset; }
            set { this.sunset = value; }
        }
        #endregion

        #region =================== constructors ===============
        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

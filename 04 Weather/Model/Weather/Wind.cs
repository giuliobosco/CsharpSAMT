using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Weather.Model.Weather {
    public class Wind {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        private double speed;
        public double Speed {
            get { return this.speed; }
            set {
                if (value >= 0) {
                    this.speed = value;
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

        private double windDirection; 
        public double WindDirection {
            get { return this.windDirection; }
            set {
                if (value >= 0 && value < 360) {
                    this.windDirection = value;
                }
            }
        }

        private string windCode;
        public string WindCode {
            get { return this.windCode; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.windCode = value;
                }
            }
        }

        private string windName;
        public string WindName {
            get { return this.windName; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.windName = value;
                }
            }
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

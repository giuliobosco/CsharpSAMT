using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Weather.Model.Weather {
    public class Clouds {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        public double Value { get; set; }

        public string name;
        public string Name {
            get { return this.name; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.name = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Weather.Model {
    public class WeatherCondition {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & propriet‡ =========
        /**
         * Weather condition id.
         */
        public int Id { get; set; }
        /**
         * Group of weather parameters (Rain, Snow, Extreme etc.).
         */
        public string Main { get; set; }
        /**
         * Weather condition within the group.
         */
        public string Description { get; set; }
        /**
         * Weather icon id.
         */
        public int Icon { get; set; }
        #endregion

        #region =================== costruttori ================
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}

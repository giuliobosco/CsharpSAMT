using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Weather.Model.Weather {
    public class Weather {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        public int Id { get; set; }

        private string description;

        public string Description {
            get { return description; }
            set { description = value; }
        }

        private string icon;

        public string Icon {
            get { return icon; }
            set { icon = value; }
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

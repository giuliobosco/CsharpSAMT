using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_RSI.DA.Model;

namespace _09_RSI.DA {
    public class DataContext {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public List<Film> Films { get; private set; }

        #endregion

        #region =================== constructors ===============

        public DataContext() {
            Films = new List<Film>();
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

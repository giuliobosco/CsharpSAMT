using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_RSI.Model;

namespace _09_RSI.DA.Model {
    public class Film {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public double Duration { get; set; }

        public DateTime StartTime { get; set; }

        public FilmKind Kind { get; set; }

        #endregion

        #region =================== constructors ===============
        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

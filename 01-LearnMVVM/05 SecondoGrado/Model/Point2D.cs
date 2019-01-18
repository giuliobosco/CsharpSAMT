using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SecondoGrado.Model {
    public class Point2D {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        public double X { get; set; }

        public double Y { get; set; }
        #endregion

        #region =================== constructors ===============

        public Point2D(double x, double y) {
            this.X = x;
            this.Y = y;
        }
        public Point2D() : this(0,0) { }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ===========
        public override string ToString() {
            return "[" + X + "," + Y + "]";
        }
        #endregion
    }
}

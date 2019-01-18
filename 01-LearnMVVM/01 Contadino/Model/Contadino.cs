using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Contadino.Model
{
    public class Contadino {
        #region =================== costanti ===================
        private static int FIENO_INIZIALE = 30;
        private static int MUCCHE_INIZIALI = 30;
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========
        private int fieno;

        public int Fieno {
            get { return fieno; }
            set {
                if (value > 1)
                    fieno = value;
                else
                    fieno = 1;
            }
        }

        private int mucche;

        public int Mucche {
            get { return mucche; }
            set {
                if (value > 0)
                    mucche = value;
                else
                    mucche = 0;
            }
        }
        #endregion

        #region =================== costruttori ================
        public Contadino(int mucche, int fieno) {
            this.Mucche = mucche;
            this.Fieno = fieno;
        }
        public Contadino() : this(MUCCHE_INIZIALI, FIENO_INIZIALE) {

        }

        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============

        public int CalcolaFieno() {
            return this.Fieno * this.Mucche;
        }


        public override string ToString() {
            return "Sono necessarie " + this.CalcolaFieno() + "balle di fieno";
        }
        #endregion
    }
}

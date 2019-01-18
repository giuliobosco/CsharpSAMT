using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tariffa.Model {
    public class Tariffa {
        #region =================== costanti ===================
        public const double COSTO_MINORENNI = 0.5;
        public const double COSTO_NORMALE = 0.8;
        public const double COSTO_AVS = COSTO_NORMALE * 0.8;
        
        public const int MAX_MINORENNI = 18;
        public const int MIN_AVS = 65;
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========

        private double distanza;

        public double Distanza {
            get { return distanza; }
            set {
                if (value >= 0) {
                    this.distanza = value;
                }
            }
        }

        private int eta;

        public int Eta {
            get { return eta; }
            set {
                if (value >= 0 && value < 110) {
                    this.eta = value;
                }
            }
        }
        
        #endregion

        #region =================== costruttori ================
        public Tariffa() {

        }

        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        public double GetTotale() {
            if (this.Eta < MAX_MINORENNI) {
                return this.Distanza * COSTO_MINORENNI;
            } else if (this.Eta > MIN_AVS) {
                return this.Distanza * COSTO_AVS;
            } else {
                return this.Distanza * COSTO_NORMALE;
            }

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Party.Model {
    public class Compleanno {
        #region =================== costanti ===================
        private const double CIBO = 25.0;
        private const double PROFESSIONALE = 15.0;
        private const double SEMPLICE = 7.50;
        private const double DJPROF = 50.0;
        private const double DJSEMPLICE = 30.0;
        private const double TORTAPICCOLA = 20.0;
        private const double TORTAGRANDE = 32.0;
        private const double TESTOPICCOLA = 16.0;
        private const double TESTOGRANDE = 40.0;
        private const double BASEPICCOLA = 40.0;
        private const double BASEGRANDE = 70.0;
        private const double CARATTERE = 0.75;
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private int persone;

        public int Persone {
            get { return persone; }
            set {
                if (value >= 0) {
                    persone = value;
                } else {
                    persone = 0;
                }

                Diametro = 0;
            }
        }

        private int diametro;

        public int Diametro {
            get { return diametro; }
            private set {
                if (Persone > 4) {
                    diametro = (int)TORTAGRANDE;
                } else {
                    diametro = (int)TORTAPICCOLA;
                }

                Testo = Testo;
            }
        }

        private string testo;

        public string Testo {
            get { return testo; }
            set {
                int caratteri = 0;

                if (Diametro == TORTAGRANDE) {
                    caratteri = (int)TESTOGRANDE;
                } else {
                    caratteri = (int)TESTOPICCOLA;
                }

                if (value.Length > caratteri) {
                    testo = value.Substring(0, caratteri);
                } else {
                    testo = value;
                }
            }
        }

        public bool DecorazioneProfessionale { get; set; }
        #endregion

        #region =================== costruttori ================

        public Compleanno() {
            Testo = "";
        }

        #endregion

        #region ====== ============= metodi aiuto ===============
        private double CostoCibo() {
            return CIBO * Persone;
        }

        private double CostoDecorazione() {
            if (DecorazioneProfessionale) {
                return PROFESSIONALE + DJPROF;
            } else {
                return SEMPLICE + DJSEMPLICE;
            }
        }

        private double CostoTorta() {
            if (Diametro > TORTAPICCOLA) {
                return BASEGRANDE + (CARATTERE * Testo.Length);
            } else {
                return BASEPICCOLA + (CARATTERE * Testo.Length);
            }
        }
        #endregion

        #region =================== metodi generali ============

        public double CalcolaTotale() {
            return CostoCibo() + CostoDecorazione() + CostoTorta();
        }

        public override string ToString() {
            return (CalcolaTotale()).ToString();
        }

        #endregion
    }
}

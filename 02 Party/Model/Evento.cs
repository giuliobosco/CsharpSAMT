using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Party.Model {
    public class Evento {
        #region =================== costanti ===================

        private const double CIBO = 25.0;
        private const double ALCOOL = 20;
        private const double NONALCOOL = 5;
        private const double PROFESSIONALE = 15;
        private const double SEMPLICE = 7.5;
        private const double DJPROF = 50;
        private const double DJSEMPLICE = 30;
        private const double SCONTO = 0.05;

        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========

        private int persone;

        public int Persone {
            get { return persone; }
            set {
                if (value > 0) {
                    persone = value;
                } else {
                    persone = 0;
                }
            }
        }

        public bool Alcool { get; set; }

        public bool DecorazioneProfessionale { get; set; }

        #endregion

        #region =================== costruttori ================
        #endregion

        #region =================== metodi aiuto ===============

        private double CostoBevande() {
            if (Alcool) {
                return ALCOOL * Persone;
            } else {
                return NONALCOOL * Persone;
            }
        }

        private double CostoCibo() {
            return CIBO * Persone;
        }

        private double CostoDecorazioni() {
            if (DecorazioneProfessionale) {
                return PROFESSIONALE * Persone + DJPROF;
            } else {
                return SEMPLICE * Persone + DJSEMPLICE;
            }
        }

        private double ScontoDaApplicare() {
            if (!Alcool) {
                return SCONTO;
            } else {
                return 0.0;
            }
        }

        #endregion

        #region =================== metodi generali ============

        public double CostoTotale() {
            return (CostoCibo() + CostoBevande() + CostoDecorazioni()) * (1 - ScontoDaApplicare());
        }

        public override string ToString() {
            return (CostoTotale()).ToString();
        }

        #endregion
    }
}

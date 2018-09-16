using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Tariffa.Model;

namespace _03_Tariffa.ViewModel {
    public class TariffaViewModel : INotifyPropertyChanged {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========
        public event PropertyChangedEventHandler PropertyChanged;

        private Tariffa model;

        public double Distanza {
            get { return model.Distanza; }
            set {
                if (model.Distanza == (double)value) {
                    return;
                }

                model.Distanza = (double)value;

                OnPropertyChanged("Distanza");
                OnPropertyChanged("Totale");
            }
        }

        public int Eta {
            get { return model.Eta; }
            set {
                if (model.Eta == (int)value) {
                    return;
                }

                model.Eta = (int)value;

                OnPropertyChanged("Eta");
                OnPropertyChanged("Totale");
            }
        }

        public double Totale {
            get {
                return model.GetTotale();
            }
        }

        #endregion

        #region =================== costruttori ================
        public TariffaViewModel() {
            model = new Tariffa();
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============

        protected void OnPropertyChanged(string propertyName) {
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}

        #endregion
    }
}

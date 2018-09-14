using _02_Party.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Party.ViewModel {
    class CompleannoViewModel : INotifyPropertyChanged {

        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========
        public event PropertyChangedEventHandler PropertyChanged;

        private Compleanno model;


        public int Persone {
            get { return model.Persone; }
            set {
                if (model.Persone == (int)value) {
                    return;
                }
                model.Persone = value;
                OnPropertyChanged("Persone");
                OnPropertyChanged("Totale");
            }
        }

        public string Testo {
            get { return model.Testo; }
            set {
                if (model.Testo == (string)value) {
                    return;
                }
                model.Testo = value;
                OnPropertyChanged("Testo");
                OnPropertyChanged("Totale");
            }
        }

        public bool DecorazioneProfessionale {
            get { return model.DecorazioneProfessionale; }
            set {
                if (model.DecorazioneProfessionale == (bool)value) {
                    return;
                }
                model.DecorazioneProfessionale = value;
                OnPropertyChanged("DecorazioneProfessionale");
                OnPropertyChanged("Totale");
            }
        }

        public double Totale {
            get { return model.CalcolaTotale(); }
        }

        #endregion

        #region =================== costruttori ================

        public CompleannoViewModel() {
            model = new Compleanno();
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

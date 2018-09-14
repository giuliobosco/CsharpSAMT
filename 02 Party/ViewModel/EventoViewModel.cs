using _02_Party.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Party.ViewModel {
    public class EventoViewModel : INotifyPropertyChanged {

        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========
        public event PropertyChangedEventHandler PropertyChanged;

        private Evento model;

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

        public bool Alcool {
            get { return model.Alcool; }
            set {
                if (model.Alcool == (bool)value) {
                    return;
                }
                model.Alcool = value;
                OnPropertyChanged("Alcool");
                OnPropertyChanged("Totale");
            }
        }

        public double Totale {
            get { return model.CostoTotale(); }
        }
        #endregion

        #region =================== costruttori ================
        public EventoViewModel() {
            model = new Evento();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using _01_Contadino.Model;

namespace _01_Contadino.ViewModel {
    public class ContadinoUpDownViewModel : INotifyPropertyChanged {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprieta =========
        public event PropertyChangedEventHandler PropertyChanged;

        private Contadino model;

        public int Fieno {
            get {
                return model.Fieno;
            }
            set {
                if (model.Fieno == (int)value) {
                    return;
                }
                model.Fieno = value;
                OnPropertyChanged("Fieno");
                OnPropertyChanged("Descrizione");
            }
        }

        public int Mucche {
            get { return model.Mucche; } 
            set {
                if (model.Mucche == (int)value) {
                    return;
                }
                model.Mucche = value;
                OnPropertyChanged("Mucche");
                OnPropertyChanged("Descrizione");
            }
        }

        public string Descrizione {
            get { return model.ToString(); }
        }
        #endregion

        #region =================== costruttori ================
        public ContadinoUpDownViewModel() {
            model = new Contadino();
            OnPropertyChanged("Descrizione");
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

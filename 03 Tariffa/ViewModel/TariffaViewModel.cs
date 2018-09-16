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

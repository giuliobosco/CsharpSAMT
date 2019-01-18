using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Numeri.ViewModel {
    public class NumeroViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        private String model;
        public String Model {
            get { return this.model; }
            set {
                if (this.model == value) {
                    return;
                }

                this.model = value;
                OnPropertyChanged(() => Model);
            }
        }
        #endregion

        #region =================== constructors ===============

        public NumeroViewModel() {
            model = "";
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

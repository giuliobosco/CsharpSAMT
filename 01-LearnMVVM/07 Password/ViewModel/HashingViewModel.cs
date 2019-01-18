using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;
using _07_Password.Model;

namespace _07_Password.ViewModel{
    public class HashingViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        private Hashing model;

        public string PlainText {
            get { return model.PlainText; }
            set {
                if (model.PlainText == value) {
                    return;
                }

                model.PlainText = value;
                OnPropertyChanged(() => PlainText);
            }
        }

        public string Salt {
            get { return model.Salt; }
            set {
                if (model.Salt == value) {
                    return;
                }

                model.Salt = value;
                OnPropertyChanged(() => Salt);
            }
        }

        public string Result {
            get { return model.Hash; }
        }

        public IDelegateCommand ComputeCommand { get; private set; }

        #endregion

        #region =================== constructors ===============

        public HashingViewModel() {
            model = new Hashing();

            ComputeCommand = new DelegateCommand(OnCompute);
        }

        #endregion

        #region =================== help methods ===============

        private void OnCompute(object obj) {
            OnPropertyChanged(() => PlainText);
            OnPropertyChanged(() => Salt);

            model.ComputeHash();

            OnPropertyChanged(() => Result);
        }

        #endregion

        #region =================== general methods ============

        #endregion
    }
}

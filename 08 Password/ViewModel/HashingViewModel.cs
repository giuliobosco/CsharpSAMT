using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_Password.Model;

namespace _08_Password.ViewModel {
    public class HashingViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        private Hashing model;

        private string computedHash;

        public string ComputedHash {
            get { return computedHash; }
            set { computedHash = value; }
        }

        public string PlainText {
            get { return model.PlainText; }
            set {
                if (value == model.PlainText) {
                    return;
                }

                model.PlainText = value;
                OnPropertyChanged(() => PlainText);
            }
        }

        public string Salt {
            get { return model.Salt; }
            set {
                if (value == model.Salt) {
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
        }

        #endregion

        #region =================== help methods ===============

        private void OnCompute() {
            this.model.PlainText = this.PlainText;
            this.model.ComputeHash();
            this.ComputedHash = this.model.Hash;

            this.OnPropertyChanged(() => this.Result);
        }

        #endregion

        #region =================== general methods ============
        #endregion
    }
}

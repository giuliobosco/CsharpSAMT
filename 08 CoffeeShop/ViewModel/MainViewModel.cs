using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;

namespace _08_CoffeeShop.ViewModel {
    public class MainViewModel: BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        private CoffeeListViewModel clvm;

        private AboutViewModel avm;

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        #endregion

        #region =================== constructors ===============

        public MainViewModel() {
            clvm = new CoffeeListViewModel();
            avm = new AboutViewModel();

            CurrentViewModel = clvm;
        }

        #endregion

        #region =================== help methods ===============

        #endregion

        #region =================== general methods ============

        #endregion
    }
}

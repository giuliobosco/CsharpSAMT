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

        public IDelegateCommand CoffeeListCommand { get; private set; }

        private AboutViewModel avm;

        public IDelegateCommand AboutCommand { get; private set; }

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        #endregion

        #region =================== constructors ===============

        public MainViewModel() {
            RegisterCommands();

            clvm = new CoffeeListViewModel();
            avm = new AboutViewModel();

            CurrentViewModel = clvm;
        }

        #endregion

        #region =================== help methods ===============

        private void OnCoffeeList(object obj) {
            CurrentViewModel = clvm;
        }

        private bool CanCoffeeList(object arg) {
            return true;
        }

        private void OnAbout(object obj) {
            CurrentViewModel = avm;
        }

        private bool CanAbout(object arg) {
            return true;
        }

        private void RegisterCommands() {
            CoffeeListCommand = new DelegateCommand(OnCoffeeList, CanCoffeeList);
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
        }

        #endregion

        #region =================== general methods ============

        #endregion
    }
}

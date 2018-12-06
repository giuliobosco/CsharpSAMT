using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;
using System.Windows;
using _09_RSI.Service;

namespace _09_RSI.ViewModel {
    public class MainViewModel : BindableBase {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private BindableBase currentViewModelBase;
        public BindableBase CurrentViewModel {
            get { return currentViewModelBase; }
            set {
                SetProperty(ref currentViewModelBase, value);
            }
        }
        public IDelegateCommand AboutCommand { get; private set; }
        public IDelegateCommand FilmListCommand { get; private set; }
        public IDelegateCommand ShutdownCommand { get; private set; }
        #endregion

        #region =================== costruttori ================

        public MainViewModel() {
            RegisterCommands();
            CurrentViewModel = ViewModelLocator.About;
        }

        #endregion

        #region =================== metodi aiuto ===============
        private void RegisterCommands() {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            FilmListCommand = new DelegateCommand(OnFilmList, CanFilmList);
            ShutdownCommand = new DelegateCommand(OnShutdown);
        }

        private void OnShutdown(object obj) {
            ShutdownService.RequestShutdown();
        }

        private bool CanAbout(object arg) {
            return true;
        }

        private void OnAbout(object obj) {
            CurrentViewModel = ViewModelLocator.About;
        }

        private bool CanFilmList(object obj) {
            return true;
        }

        private void OnFilmList(object obj) {
            CurrentViewModel = ViewModelLocator.FilmList;
        }

        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;
using _09_RSI.DA.Model;
using _09_RSI.DA.Service;

namespace _09_RSI.ViewModel {
    public class FilmListViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public ObservableCollection<Film> Films { get; set; }

        #endregion

        #region =================== constructors ===============

        public FilmListViewModel() {
            FilmDataRepository filmDataRepository = new FilmDataRepository();
            Films = new ObservableCollection<Film>(filmDataRepository.Get());
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

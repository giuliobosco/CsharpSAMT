using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;
using _08_CoffeeShop.DA.Model;
using _08_CoffeeShop.DA.Service;

namespace _08_CoffeeShop.ViewModel {
    public class CoffeeListViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public ObservableCollection<Coffee> Coffees { get; set; }

        #endregion

        #region =================== constructors ===============

        public CoffeeListViewModel() {
            CoffeeDataRepository cdr = new CoffeeDataRepository();
            
            this.Coffees = new ObservableCollection<Coffee>(cdr.Get());
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}

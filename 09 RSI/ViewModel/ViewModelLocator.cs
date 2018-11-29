using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using MVVM;

namespace _09_RSI.ViewModel {
    public class ViewModelLocator {
        public static MainViewModel Main {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public static AboutViewModel About {
            get { return ServiceLocator.Current.GetInstance<AboutViewModel>(); }
        }

        public ViewModelLocator() {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<AboutViewModel>();
        }
    }
}

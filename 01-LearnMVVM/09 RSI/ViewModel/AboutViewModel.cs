using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVM;
using _09_RSI.Service;

namespace _09_RSI.ViewModel {
    public class AboutViewModel : BindableBase {
        #region =================== costanti ===================
        private readonly string HOMEPAGE = "http://www.cpt-ti.ch";
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========

        public string LegalCopyright {
            get { return ApplicationVersionService.LegalCopyright; }
        }

        public string ProductVersion {
            get { return "Versione: " + ApplicationVersionService.ProductVersion; }
        }

        public string CompanyName {
            get { return "CompanyName: " + ApplicationVersionService.CompanyName; }
        }
        public string Comments {
            get { return "Comments: " + ApplicationVersionService.Comments; }
        }
        public string FileDescription {
            get { return "FileDescription: " + ApplicationVersionService.FileDescription; }
        }
        public string FileName {
            get { return "FileName: " + ApplicationVersionService.FileName; }
        }
        public string FileVersion {
            get { return "FileVersion: " + ApplicationVersionService.FileVersion; }
        }
        public string LegalTrademarks {
            get { return "LegalTrademarks: " + ApplicationVersionService.LegalTrademarks; }
        }
        public string OriginalFilename {
            get { return "OriginalFilename: " + ApplicationVersionService.OriginalFilename; }
        }
        public string ProductName {
            get { return "ProductName: " + ApplicationVersionService.ProductName; }
        }
        public string Language {
            get { return "Language: " + ApplicationVersionService.Language; }
        }
        public string ProductMajorPart {
            get { return "ProductMajorPart: " + ApplicationVersionService.ProductMajorPart; }
        }
        public string ProductMinorPart {
            get { return "ProductMinorPart: " + ApplicationVersionService.ProductMinorPart; }
        }
        public IDelegateCommand HomePageCommand { get; private set; }
        #endregion

        #region =================== costruttori ================

        public AboutViewModel() {
            HomePageCommand = new DelegateCommand(OnHomePage);
        }

        #endregion

        #region =================== metodi aiuto ===============
        private void OnHomePage(object obj) {
            try {
                System.Diagnostics.Process.Start(HOMEPAGE);
            } catch (System.ComponentModel.Win32Exception noBrowser) {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            } catch (System.Exception other) {
                MessageBox.Show(other.Message);
            }
        }
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.Service {
    public class ApplicationVersionService {
        // va prendere le info da <progetto>/Properties/AssemblyInfo.cs
        private static FileVersionInfo fvi =
            FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);

        //[assembly: AssemblyFileVersion("1.0.0.0")]
        public static string ProductVersion {
            get { return fvi.ProductVersion; }
        }

        //[assembly: AssemblyCopyright("Copyright © SAMT 2017")]
        public static string LegalCopyright {
            get { return fvi.LegalCopyright; }
        }
        //[assembly: AssemblyCompany("")]
        public static string CompanyName {
            get { return fvi.CompanyName; }
        }
        //[assembly: AssemblyDescription("")]
        public static string Comments {
            get { return fvi.Comments; }
        }
        //[assembly: AssemblyTitle("<progetto>")]
        public static string FileDescription {
            get { return fvi.FileDescription; }
        }
        public static string FileName {
            get { return fvi.FileName; }
        }
        //[assembly: AssemblyVersion("1.0.0.0")]
        public static string FileVersion {
            get { return fvi.FileVersion; }
        }
        //[assembly: AssemblyTrademark("")]
        public static string LegalTrademarks {
            get { return fvi.LegalTrademarks; }
        }
        public static string OriginalFilename {
            get { return fvi.OriginalFilename; }
        }
        //[assembly: AssemblyProduct("<progetto>")]
        public static string ProductName {
            get { return fvi.ProductName; }
        }
        public static string Language {
            get { return fvi.Language; }
        }
        //[assembly: AssemblyFileVersion("1.*.*.*")]
        public static int ProductMajorPart {
            get { return fvi.ProductMajorPart; }
        }
        //[assembly: AssemblyFileVersion("*.0.*.*")]
        public static int ProductMinorPart {
            get { return fvi.ProductMinorPart; }
        }

    }
}

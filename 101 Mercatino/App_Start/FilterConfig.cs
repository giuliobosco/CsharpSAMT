using System.Web;
using System.Web.Mvc;

namespace _101_Mercatino {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

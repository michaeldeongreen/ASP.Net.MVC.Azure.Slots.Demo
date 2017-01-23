using System.Web;
using System.Web.Mvc;

namespace ASP.Net.MVC.Azure.Slots.Demo.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace VuThuan_2080600058
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

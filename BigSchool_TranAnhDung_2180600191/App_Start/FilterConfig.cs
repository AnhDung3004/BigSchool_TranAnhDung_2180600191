using System.Web;
using System.Web.Mvc;

namespace BigSchool_TranAnhDung_2180600191
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

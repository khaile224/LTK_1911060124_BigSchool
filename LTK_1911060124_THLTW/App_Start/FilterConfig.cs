using System.Web;
using System.Web.Mvc;

namespace LTK_1911060124_THLTW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

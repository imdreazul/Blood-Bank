using System.Web;
using System.Web.Mvc;

namespace MdReazulIslam_298652
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

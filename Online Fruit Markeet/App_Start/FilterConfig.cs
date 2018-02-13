using System.Web;
using System.Web.Mvc;

namespace Online_Fruit_Markeet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

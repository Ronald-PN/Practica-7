using System.Web;
using System.Web.Mvc;

namespace AppCRUD_EmpleadoDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

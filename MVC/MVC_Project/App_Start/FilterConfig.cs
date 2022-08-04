using System.Web;
using System.Web.Mvc;

namespace Murat_Yücedağ_MVC_Katmanlı_Mimari
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

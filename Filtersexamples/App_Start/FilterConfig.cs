using Filtersexamples.Filters;
using System.Web;
using System.Web.Mvc;

namespace Filtersexamples
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute(),1);
            //filters.Add(new CustomeException(),2);//register filter on globally
            //filters.Add(new CustomeException(),3);
            
        }
    }
}

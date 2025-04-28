using System.Web;
using System.Web.Optimization;

namespace JavaScriptexamples
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {



            bundles.Add(new ScriptBundle("~/bundles/jquery")
                        .IncludeDirectory("~/Scripts/", "*.js", true));


            var cdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js";
            bundles.Add(new StyleBundle("~/bundles/boostrap").Include(
                "~/Content/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery", cdnPath)
              .Include("~/Scripts/jquery.js"));




            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css"));


            BundleTable.EnableOptimizations = true;
            
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace PruebaHereMaps
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                   "~/Content/Scripts/HereMaps/mapsjs-core.js",
                   "~/Content/Scripts/HereMaps/mapsjs-service.js",
                   "~/Content/Scripts/HereMaps/mapsjs-ui.js",
                   "~/Content/Scripts/HereMaps/mapsjs-mapevents.js",
                   "~/Content/Scripts/Map.js"
                   ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css",
                      "~/Content/mapsjs-ui.css"
                      ));

            BundleTable.EnableOptimizations = true;

        }
    }
}

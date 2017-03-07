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
                   "~/Content/Scripts/HereMaps/mapsjs-mapevents.js"
                   ));

            BundleTable.EnableOptimizations = true;

        }
    }
}

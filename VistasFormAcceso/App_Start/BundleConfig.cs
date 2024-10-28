using System.Web;
using System.Web.Optimization;

namespace VistasFormAcceso.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/wwwroot/css").Include(
                "~/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css",
                "~/wwwroot/css/site.css"));
        }
    }
}

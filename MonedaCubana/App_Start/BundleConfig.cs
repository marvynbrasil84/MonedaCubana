using System.Web;
using System.Web.Optimization;

namespace MonedaCubana
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/jquery.maskedinput.js",
                        "~/Scripts/dataTables.js",
                        "~/Scripts/sweetalert.min.js",
                        "~/res/jsGenerico.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/jquery.dataTables.min.css",
                         "~/Content/jquery-ui-min.css",
                         "~/Content/jquery-ui-1.10.4.css",
                          "~/Content/datatables.css",
                          "~/Content/subpaginas.css",
                          "~/Content/font-awesome-4.7.0/css/font-awesome.min.css",
                          "~/css/sweetalert.css",
                      "~/Content/site.css"));
        }
    }
}

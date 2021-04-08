
using System.Web.Optimization;


namespace SchoolEMS.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.6.0.min.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jtable/jquery.jtable.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"));


            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/demo.js",
                        "~/Scripts/admin.js",
                        "~/Scripts/waves.min.js",
                        "~/Scripts/script.js",
                        "~/Scripts/helpers.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/jquery-ui.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/all-themes.min.css",
                      "~/Content/jtable.min.css",
                      "~/Content/style.css",
                      "~/Content/Site.css"
                      ));

            BundleTable.EnableOptimizations = true;
        }

    }
}
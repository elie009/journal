using System.Web;
using System.Web.Optimization;

namespace Journal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.




            bundles.Add(new Bundle("~/bundles/chart").Include(
                        "~/Scripts/lib/chart/chart.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/easing").Include(
                        "~/Scripts/lib/easing/easing.js",
                        "~/Scripts/lib/easing/easing.min.js"
                        ));
       
            bundles.Add(new ScriptBundle("~/bundles/owlcarousel").Include(
                        "~/Scripts/lib/owlcarousel/owl.carousel.js",
                        "~/Scripts/lib/owlcarousel/owl.carousel.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/tempusdominus").Include(
                        "~/Scripts/lib/tempusdominus/moment-timezone.min.js",
                        "~/Scripts/lib/tempusdominus/moment.min.js",
                        "~/Scripts/lib/tempusdominus/tempusdominus-bootstrap-4.js",
                        "~/Scripts/lib/tempusdominus/tempusdominus-bootstrap-4.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/waypoints").Include(
                        "~/Scripts/lib/waypoints/waypoints.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/Scripts/main.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/script/journal").Include(
                        "~/Scripts/journalItem.js"
                        ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap-lumen.css",
            //          "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/style.css"
                      ));

            bundles.Add(new StyleBundle("~/css/owlcarousel").Include(
                      "~/Scripts/lib/owlcarousel/assets/owl.carousel.min.css"
                      ));
            bundles.Add(new StyleBundle("~/css/tempusdominus").Include(
                      "~/Scripts/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css"
                      ));
        }
    }
}

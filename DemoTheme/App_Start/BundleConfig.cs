using System.Web;
using System.Web.Optimization;

namespace DemoTheme
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

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Themes/Gentelella/vendors/jquery/dist/jquery.min.js",
                        "~/Themes/Gentelella/vendors/bootstrap/dist/js/bootstrap.min.js",
                        "~/Themes/Gentelella/vendors/nprogress/nprogress.js",
                        "~/Themes/Gentelella/vendors/Chart.js/dist/Chart.min.js",
                        "~/Themes/Gentelella/vendors/gauge.js/dist/gauge.min.js",
                        "~/Themes/Gentelella/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                        "~/Themes/Gentelella/vendors/iCheck/icheck.min.js",
                        "~/Themes/Gentelella/vendors/skycons/skycons.js",
                        "~/Themes/Gentelella/vendors/datatables.net/js/jquery.dataTables.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-buttons/js/buttons.print.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                        "~/Themes/Gentelella/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                        "~/Themes/Gentelella/vendors/datatables.net-scroller/js/dataTables.scroller.min.js",
                        "~/Themes/Gentelella/vendors/raphael/raphael.min.js",
                        "~/Themes/Gentelella/vendors/morris.js/morris.min.js",
                        "~/Themes/Gentelella/build/js/custom.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Themes/Gentelella/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/Themes/Gentelella/vendors/font-awesome/css/font-awesome.min.css",
                      "~/Themes/Gentelella/vendors/nprogress/nprogress.css",
                      "~/Themes/Gentelella/vendors/iCheck/skins/flat/green.css",
                      "~/Themes/Gentelella/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                      "~/Themes/Gentelella/vendors/jqvmap/dist/jqvmap.min.css",
                      "~/Themes/Gentelella/vendors/bootstrap-daterangepicker/daterangepicker.css",
                      "~/Themes/Gentelella/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",
                      "~/Themes/Gentelella/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                      "~/Themes/Gentelella/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
                      "~/Themes/Gentelella/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
                      "~/Themes/Gentelella/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css",
                      "~/Themes/Gentelella/build/css/custom.min.css"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace Bitcoin
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/AdminJs").Include(
                          "~/ContentAdmin/js/bootstrap.min.js",
                          "~/ContentAdmin/js/plugins/metismenu/jquery.metisMenu.js",
                          "~/ContentAdmin/js/plugins/blockui-master/jquery-ui.js",
                          "~/ContentAdmin/js/plugins/blockui-master/jquery.blockUI.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.tooltip.min.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.resize.min.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.selection.min.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.pie.min.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.time.min.js",
                          "~/ContentAdmin/js/plugins/flot/jquery.flot.min.js",
                          "~/ContentAdmin/js/functions.js",
                          "~/ContentAdmin/js/plugins/wizard/jquery.bootstrap.wizard.min.js",

                           "~/ContentAdmin/js/plugins/chartjs/Chart.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/FrontJs").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/CommonJs").Include(
                        "~/Scripts/jquery-{version}.js"));

            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // -----------------------------------------------------------------------------------------------
            bundles.Add(new StyleBundle("~/ContentAdmin/Admincss").Include(
                     
                      "~/ContentAdmin/css/entypo.css",
                     
                      "~/ContentAdmin/css/fontawesome.min.css",
                      "~/ContentAdmin/css/fontawesome.css",
                     

                      "~/ContentAdmin/css/bootstrap.min.css",
                      "~/ContentAdmin/css/mouldifi-core.css",
                      "~/ContentAdmin/css/mouldifi-forms.css",
                       "~/Content/font-awesome.min.css",
                       "~/Content/font-awesome.css"
                      ));

            bundles.Add(new StyleBundle("~/ContentAdmin/Frontcss").Include(
                    
                    ));
            bundles.Add(new StyleBundle("~/ContentAdmin/Commoncss").Include(
                    
                    ));

        }
    }
}

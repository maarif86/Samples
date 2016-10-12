using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Realestate.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS: bootstrap, fontawesome, application style
            bundles.Add(new StyleBundle("~/css").Include(
                    "~/Content/bootstrap.min.css",
                    "~/Fonts/font-awesome/css/font-awesome.min.css",
                    "~/Content/css/style.css"
                ));

            // Scripts: jquery, bootstrap
            bundles.Add(new ScriptBundle("~/scripts").Include(
                    "~/Scripts/jquery-1.9.1.min.js", 
                    "~/Scripts/bootstrap.min.js", 
                    "~/Scripts/plugins/metisMenu/jquery.metisMenu.js",
                    "~/Scripts/plugins/slimscroll/jquery.slimscroll.min.js",
                    "~/Scripts/plugins/pace/pace.min.js",
                    "~/Scripts/js/app/realestate.js"
                ));


            // Scripts: angular, angular-bootstrap
            bundles.Add(new ScriptBundle("~/angular").Include(
                    "~/Scripts/angular/angular.min.js",
                    "~/Scripts/angular/angular-route.min.js",
                    "~/Scripts/plugins/ui-router/angular-ui-router.min.js",
                    "~/Scripts/plugins/bootstrap/ui-bootstrap-tpls-2.1.4.min.js"
                ));

            // Scripts: app, controllers
            bundles.Add(new ScriptBundle("~/app").Include(
                    "~/Scripts/js/app/app.module.js",
                    "~/Scripts/js/app/app.config.js",
                    "~/Scripts/js/controllers/dashboard.controller.js",
                    "~/Scripts/js/directives/dashboard.directive.js"
                ));

            // Scripts: Dashboard Page
            bundles.Add(new ScriptBundle("~/script/dashboard").Include(
                    "~/Scripts/plugins/flot/jquery.flot.js",
                    "~/Scripts/plugins/flot/jquery.flot.spline.js",
                    "~/Scripts/plugins/sparkline/jquery.sparkline.min.js"
                ));

            // Angular: Dashboard Page
            bundles.Add(new ScriptBundle("~/angular/dashboard").Include(
                    "~/Scripts/plugins/flot/angular-flot.js"
                ));
        }
    }
}
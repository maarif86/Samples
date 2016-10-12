using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Realestate.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Global CSS
            bundles.Add(new StyleBundle("~/css").Include(
                        "~/Content/css/icons/icomoon/styles.css",
                        "~/Content/bootstrap.css",
                        "~/Content/css/core.css",
                        "~/Content/css/components.css",
                        "~/Content/css/colors.css"
                    ));

            // Global JS Scripts
            bundles.Add(new ScriptBundle("~/scripts").Include(
                        "~/Scripts/jquery-1.9.1.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/core/app.js"
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

            // Scripts: Dashboard
            bundles.Add(new ScriptBundle("~/scripts/dashboard").Include(
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
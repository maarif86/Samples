using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Areas.Management.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Management/Project
        
        public ActionResult New()
        {
            return PartialView();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}
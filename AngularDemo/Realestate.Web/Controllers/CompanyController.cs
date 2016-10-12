using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult List()
        {
            return PartialView("_List");
        }
    }
}
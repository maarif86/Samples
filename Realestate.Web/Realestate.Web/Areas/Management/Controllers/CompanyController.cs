﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Areas.Management.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Management/Company
        
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
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Areas.Management.Controllers
{
    public class BookingController : Controller
    {
        // GET: Management/Booking
        public ActionResult Create()
        {
            return PartialView("_ApplicantDetails");
        }

        public ActionResult List()
        {
            return PartialView("_List");
        }

        public ActionResult ChangeStatus()
        {
            return PartialView("_TransferDetails");
        }
    }
}
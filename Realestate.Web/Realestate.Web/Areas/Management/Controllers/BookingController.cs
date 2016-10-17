using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Areas.Management.Controllers
{
    public class BookingController : Controller
    {
        // GET: Management/Booking
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
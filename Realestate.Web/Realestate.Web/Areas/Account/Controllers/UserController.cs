using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realestate.Web.Areas.Account.Controllers
{
    public class UserController : Controller
    {
        // GET: Account/User

        public ActionResult Index()
        {
            return View();
        }

        new public ActionResult Profile()
        {
            return null;
        }

        public ActionResult Settings()
        {
            return null;
        }

        public void Logout()
        {
            
        }
    }
}
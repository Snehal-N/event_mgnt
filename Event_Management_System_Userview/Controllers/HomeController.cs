using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management_System_Userview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //hello hi
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
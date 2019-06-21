using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMVCIntro.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {

            ViewBag.Title = "About Us";
            ViewBag.MyName = "Paul Fox";
            ViewBag.MyInfo = "Has A big boi";
            return View();
        }
    }
}
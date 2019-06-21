using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IxcameyC_sections.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(String layout = "_Layout.cshtml")
        {
            ViewBag.Layout = "~/Views/Shared/"+layout;

            return View();
        }        

    }
}
using MemeStoreService.Models;
using MemeStoreService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeStoreDemo.Controllers
{
    public class HomeController : Controller
    {
        IMemeStoreService service = new EFMemeStoreService();
        public ActionResult Index()
        {
            var model = service.GetFeaturedMeme();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
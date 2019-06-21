using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InputDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult GetBookById(string id)
        {
            //var id = RouteData.Values["bookId"];
            //var name = Request.QueryString["Name"];
            id = Request.Form["id"];

            //Do book lookup stuff

            return View("Index");
        }
    }
}